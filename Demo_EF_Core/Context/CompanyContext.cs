    using Demo_EF_Core.Entitis;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Demo_EF_Core.Context
    {
        public class CompanyContext:DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("data source=ZIAD-YOUSEF\\SQLEXPRESS;Initial Catalog=CompanyDB;integrated Security=true;Encrypt=false");
            public virtual DbSet<Department> Departments { get; set; }
            public virtual DbSet<Employee> Employees { get; set; }
        
        }
    }
