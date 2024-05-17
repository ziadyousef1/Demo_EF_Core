using Demo_EF_Core.Context;
using Demo_EF_Core.Entitis;

namespace Demo_EF_Core
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //note:
            // the code can be refactored to use the command pattern to remove the conditional statements 
            // the command pattern will be implemented in the next version of the code

            var service = new CompanyService();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Department");
                Console.WriteLine("2. Find Department");
                Console.WriteLine("3. Update Department");
                Console.WriteLine("4. Remove Department");
                Console.WriteLine("5. Add Employee");
                Console.WriteLine("6. Find Employee");
                Console.WriteLine("7. Update Employee");
                Console.WriteLine("8. Remove Employee");
                Console.WriteLine("9. Exit");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddDepartment(service);
                        break;
                    case "2":
                        FindDepartment(service);
                        break;
                    case "3":
                        UpdateDepartment(service);
                        break;
                    case "4":
                        RemoveDepartment(service);
                        break;
                    case "5":
                        AddEmployee(service);
                        break;
                    case "6":
                        FindEmployee(service);
                        break;
                    case "7":
                        UpdateEmployee(service);
                        break;
                    case "8":
                        RemoveEmployee(service);
                        break;
                    case "9":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please again.");
                        break;
                }
            }
        }

        private static void AddDepartment(CompanyService service)
        {
            Console.Write("Enter Department Name: ");
            var name = Console.ReadLine();

            var department = new Department { Name = name };
            service.AddDepartment(department);
            Console.WriteLine("Department added.");
        }

        private static void FindDepartment(CompanyService service)
        {
            Console.Write("Enter Department ID: ");
            var id = int.Parse(Console.ReadLine());

            var department = service.FindDepartment(id);
            if (department != null)
            {
                Console.WriteLine($"Department: {department.Name}");
            }
            else
            {
                Console.WriteLine("Department not found.");
            }
        }

        private static void UpdateDepartment(CompanyService service)
        {
            Console.Write("Enter Department ID to update: ");
            var id = int.Parse(Console.ReadLine());

            var department = service.FindDepartment(id);
            if (department != null)
            {
                Console.Write("Enter new Department Name: ");
                department.Name = Console.ReadLine();

                service.UpdateDepartment(department);
                Console.WriteLine("Department updated.");
            }
            else
            {
                Console.WriteLine("Department not found.");
            }
        }

        private static void RemoveDepartment(CompanyService service)
        {
            Console.Write("Enter Department ID to remove: ");
            var id = int.Parse(Console.ReadLine());

            service.RemoveDepartment(id);
            Console.WriteLine("Department removed.");
        }

        private static void AddEmployee(CompanyService service)
        {
            Console.Write("Enter Employee First Name: ");
            var firstName = Console.ReadLine();

            Console.Write("Enter Employee Last Name: ");
            var lastName = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            var salary = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Department ID: ");
            var departmentId = int.Parse(Console.ReadLine());

            var department = service.FindDepartment(departmentId);
            if (department != null)
            {
                var employee = new Employee
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Salary = salary,
                    Department = department
                };
                service.AddEmployee(employee);
                Console.WriteLine("Employee added.");
            }
            else
            {
                Console.WriteLine("Department not found.");
            }
        }

        private static void FindEmployee(CompanyService service)
        {
            Console.Write("Enter Employee ID: ");
            var id = int.Parse(Console.ReadLine());

            var employee = service.FindEmployee(id);
            if (employee != null)
            {
                Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}, Salary: {employee.Salary}");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        private static void UpdateEmployee(CompanyService service)
        {
            Console.Write("Enter Employee ID to update: ");
            var id = int.Parse(Console.ReadLine());

            var employee = service.FindEmployee(id);
            if (employee != null)
            {
                Console.Write("Enter new Employee First Name: ");
                employee.FirstName = Console.ReadLine();

                Console.Write("Enter new Employee Last Name: ");
                employee.LastName = Console.ReadLine();

                Console.Write("Enter new Employee Salary: ");
                employee.Salary = decimal.Parse(Console.ReadLine());

                service.UpdateEmployee(employee);
                Console.WriteLine("Employee updated.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        private static void RemoveEmployee(CompanyService service)
        {
            Console.Write("Enter Employee ID to remove: ");
            var id = int.Parse(Console.ReadLine());

            service.RemoveEmployee(id);
            Console.WriteLine("Employee removed.");
        }






    }
    
}