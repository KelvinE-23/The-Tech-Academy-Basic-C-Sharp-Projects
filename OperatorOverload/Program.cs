 using System;
 using System.Collections.Generic;
 using System.IO;
 using System.Linq;
 using System.Net.Http;
 using System.Threading;
 using System.Threading.Tasks;

namespace OperatorOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object.
            Employee employee1 = new Employee();

            // Set the Id property for the first employee.
            employee1.Id = 101;

            // Set the FirstName property for the first employee.
            employee1.FirstName = "Alice";

            // Set the LastName property for the first employee.
            employee1.LastName = "Johnson";

            // Create the second Employee object.
            Employee employee2 = new Employee();

            // Set the Id property for the second employee.
            employee2.Id = 102;

            // Set the FirstName property for the second employee.
            employee2.FirstName = "Bob";

            // Set the LastName property for the second employee.
            employee2.LastName = "Smith";

            // Compare the two employees with the overloaded == operator.
            bool employeesAreEqual = employee1 == employee2;

            // Compare the two employees with the overloaded != operator.
            bool employeesAreNotEqual = employee1 != employee2;

            // Display the first employee's full name and Id.
            Console.WriteLine($"Employee 1: {employee1.FirstName} {employee1.LastName}, Id: {employee1.Id}");

            // Display the second employee's full name and Id.
            Console.WriteLine($"Employee 2: {employee2.FirstName} {employee2.LastName}, Id: {employee2.Id}");

            // Display the result of using the overloaded == operator.
            Console.WriteLine($"employee1 == employee2: {employeesAreEqual}");

            // Display the result of using the overloaded != operator.
            Console.WriteLine($"employee1 != employee2: {employeesAreNotEqual}");
        }

    }
}
