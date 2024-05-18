using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LSP.Before
{
    //states that subtypes must be substitutable for their base types.

    //Violation of (LSP) is indicated by:
    //Type checks using is or as keywords indicate potential LSP violations.
    // Similarity between null checks and type checks also suggests LSP issues.
    // Presence of NotImplementedException indicates incomplete support for an interface or base class.
   
    public class Employee
    {
        public string Name { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"Employee: {Name}");
        }
    }

    public class Manager : Employee
    {
        public override void Print()
        {
            Console.WriteLine($"Manager: {Name}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Ahmed" },
            new Manager { Name = "Samy" }
        };

            foreach (var employee in employees)
            {
                if (employee is Manager)
                {
                    ((Manager)employee).Print(); // LSP Violation: Type check
                }
                else
                {
                    employee.Print();
                }
            }
        }
    }

}
