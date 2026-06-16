using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentDatabase_ConsoleApp
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {

        }
        // Entities        
        public DbSet<Student> Students { get; set; }
        //public DbSet<DateOfBirth> DateOfBirth { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
