using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DIP
{
    // states that high level modules should not depend on low level modules. Both should depend on abstractions.
    // Abstractions should not depend on details.Details should depend on abstractions.

    //Structure your solution so that high-level projects (business logic) depend on abstractions (interfaces)
    //and low level projects (infrastructure) implement these abstractions.

    //Abstractions means interfaces or abstract classes that define what should be done without specifying how.
    //Details means concrete implementations that specify how the tasks are performed.
    //real world and new example of DIP


    // Low level module
    public class SqlServerDatabase
    {
        public void Connect() {  }
        public void Insert(string data) { }
        public string Select(string query) { return ""; }
    }

    // high level module
    public class SalesReport
    {
        private readonly SqlServerDatabase _database;

        public SalesReport(SqlServerDatabase database)
        {
            _database = database;
        }

        public void GenerateReport()
        {
            _database.Connect();
            var data = _database.Select("SELECT * FROM Sales");
        }
    }

    
    class program
    {
        static void Main(string[] args)
        {    
            var sqlDatabase = new SqlServerDatabase();
            var salesReport = new SalesReport(sqlDatabase);
            salesReport.GenerateReport();

        }
    }   


}
