using System;

namespace Polymorphism_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee= new Employee();
            employee.FirstName = "Ken";
            employee.LastName = "Adams";
            employee.SayName();


            IQuittable quittableEmployee = new Employee();
            employee.FirstName = "Ken";
            employee.LastName = "Adams";
            quittableEmployee.Quit();

        }

        
       
            
        }
}

