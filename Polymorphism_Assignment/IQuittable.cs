using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    interface IQuittable
    {
        public void Quit()
        {
            {
                Console.WriteLine("This employee has quit.");
                Console.ReadLine();
            }
        }

    }
}
