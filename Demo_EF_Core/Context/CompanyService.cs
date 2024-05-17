using Demo_EF_Core.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_EF_Core.Context
{
  
        public class CompanyService
        {
            private readonly CompanyContext _context;

            public CompanyService()
            {
                _context = new CompanyContext();
            }

            public void AddDepartment(Department department)
            {
                _context.Departments.Add(department);
                _context.SaveChanges();
            }

            public Department FindDepartment(int id)
            {
                return _context.Departments.FirstOrDefault(d => d.DepartmentID == id);
            }

            public void UpdateDepartment(Department department)
            {
                _context.Departments.Update(department);
                _context.SaveChanges();
            }

            public void RemoveDepartment(int id)
            {
                var department = FindDepartment(id);
                if (department != null)
                {
                    _context.Departments.Remove(department);
                    _context.SaveChanges();
                }
            }

            public void AddEmployee(Employee employee)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
            }

            public Employee FindEmployee(int id)
            {
                return _context.Employees.FirstOrDefault(e => e.ID == id);
            }

            public void UpdateEmployee(Employee employee)
            {
                _context.Employees.Update(employee);
                _context.SaveChanges();
            }

            public void RemoveEmployee(int id)
            {
                var employee = FindEmployee(id);
                if (employee != null)
                {
                    _context.Employees.Remove(employee);
                    _context.SaveChanges();
                }
            }
        
    }
}
