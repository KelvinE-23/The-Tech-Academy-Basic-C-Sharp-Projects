using System;
using System.Linq;
using System.Threading.Tasks;
using CarInsurance.Data;
using CarInsurance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
    {
        private readonly CarInsuranceContext _context;

        public InsureesController(CarInsuranceContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Insurees.ToListAsync());
        }

        public async Task<IActionResult> Admin()
        {
            return View(await _context.Insurees
                .OrderBy(i => i.LastName)
                .ThenBy(i => i.FirstName)
                .ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);

            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                _context.Add(insuree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(insuree);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees.FindAsync(id);

            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (id != insuree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    insuree.Quote = CalculateQuote(insuree);
                    _context.Update(insuree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsureeExists(insuree.Id))
                    {
                        return NotFound();
                    }

                    throw;
                }

                return RedirectToAction(nameof(Index));
            }

            return View(insuree);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);

            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var insuree = await _context.Insurees.FindAsync(id);

            if (insuree != null)
            {
                _context.Insurees.Remove(insuree);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsureeExists(int id)
        {
            return _context.Insurees.Any(e => e.Id == id);
        }

        private static decimal CalculateQuote(Insuree insuree)
        {
            decimal quote = 50m;
            int age = CalculateAge(insuree.DateOfBirth);

            if (age <= 18)
            {
                quote += 100m;
            }
            else if (age <= 25)
            {
                quote += 50m;
            }
            else
            {
                quote += 25m;
            }

            if (insuree.CarYear < 2000)
            {
                quote += 25m;
            }

            if (insuree.CarYear > 2015)
            {
                quote += 25m;
            }

            if (string.Equals(insuree.CarMake, "Porsche", StringComparison.OrdinalIgnoreCase))
            {
                quote += 25m;

                if (string.Equals(insuree.CarModel, "911 Carrera", StringComparison.OrdinalIgnoreCase))
                {
                    quote += 25m;
                }
            }

            quote += insuree.SpeedingTickets * 10m;

            if (insuree.DUI)
            {
                quote *= 1.25m;
            }

            if (insuree.CoverageType)
            {
                quote *= 1.50m;
            }

            return Math.Round(quote, 2);
        }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;

            if (dateOfBirth.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}
