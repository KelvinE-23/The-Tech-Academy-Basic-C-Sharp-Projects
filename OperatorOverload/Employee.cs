using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    // This class represents one employee.
    public class Employee
    {
        // This property stores the employee's ID number.
        public int Id { get; set; }

        // This property stores the employee's first name.
        public string? FirstName { get; set; }

        // This property stores the employee's last name.
        public string? LastName { get; set; }

        // This overload changes how the == operator compares two Employee objects.
        public static bool operator ==(Employee? employee1, Employee? employee2)
        {
            return employee1.Id == employee2.Id;
        }

        // This overload changes how the != operator compares two Employee objects.
        public static bool operator !=(Employee? employee1, Employee? employee2)
        {
            return employee1.Id != employee2.Id;
        }
    }
}
