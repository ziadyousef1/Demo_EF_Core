namespace Demo_EF_Core.Entitis
{
    public class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
       
    }
}
