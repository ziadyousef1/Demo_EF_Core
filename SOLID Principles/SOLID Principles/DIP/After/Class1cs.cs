using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DIP.After
{
    // what if we want to change the database from SQL to Cassandra ?
    // we would have to change the SalesReport class
    // this is a violation of the DIP principle
    // we should depend on abstractions not on concretions
    public interface IDatabase
    {
        void Connect();
        void Insert(string data);
        string Select(string query);
    }


    // Low level modules
    public class SqlServerDatabase : IDatabase
    {
        public void Connect() { }
        public void Insert(string data) { }
        public string Select(string query) { return ""; }
    }

    public class CassandraDatabase : IDatabase
    {
        public void Connect() {  }
        public void Insert(string data) { }
        public string Select(string query) { return ""; }
    }
    // high level module


    public class SalesReport
    {
        private readonly IDatabase _database;

        public SalesReport(IDatabase database)
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

            // Switching to Cassandra Database
            var cassandraDatabase = new CassandraDatabase();
            var salesReportCassandra = new SalesReport(cassandraDatabase);
            salesReportCassandra.GenerateReport();
        }
    }           
}
