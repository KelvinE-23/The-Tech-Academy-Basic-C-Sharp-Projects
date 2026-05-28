using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    public abstract class Person
    // The Person class is declared as abstract, which means it cannot be instantiated directly.
    {
        public string FirstName { get; set; }
        // The FirstName property is defined with a getter and setter, allowing you to store and retrieve the first name of a person.
        public string LastName { get; set; }
        // The LastName property is defined similarly to FirstName, allowing you to store and retrieve the last name of a person.

        public void SayName()
        // The SayName method is defined to print the full name of the person to the console.
        {
            Console.WriteLine("The employee's name is " + FirstName + " " + LastName + ".");
            Console.WriteLine("\nPress Enter to see their employment status.");
                Console.ReadLine();
        }


    }
}
