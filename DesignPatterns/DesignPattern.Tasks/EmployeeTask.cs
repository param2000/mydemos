using System;
using System.Collections.Generic;
using System.Data;
using DesignPattern.DataAccess;

namespace DesignPattern.Tasks
{
    public class EmployeeTask:IEmployeeTask
    {
        private IDbProviderFactory _providerfactory;

        public EmployeeTask():this(DBProviderFactory .Instance)
            {}

        public EmployeeTask(IDbProviderFactory providerfactory)
            {this._providerfactory = providerfactory;}

        public IList<IEmployee> GetAllEmployees()
        {
            DataTable rawData = GetDataRowsFromDb();
            IList<IEmployee> results = MapEmployeeFromDatabaseRow(rawData);
         
            return results;
        }

        private IList<IEmployee> MapEmployeeFromDatabaseRow(DataTable rawData)
        {
            IList<IEmployee> results = new List<IEmployee>();
             
            foreach (DataRow row in rawData.Rows)
                results.Add(new Employee(row["FirstName"].ToString(), row["LastName"].ToString(),Convert.ToDateTime(row["BirthDate"])));
            
            return results;
        }

        private DataTable GetDataRowsFromDb()
        {
            DataTable rawData = new DataTable();
            using (IDbConnection connection = _providerfactory.CreateConnection())
            {
                using (IDbCommand command = _providerfactory.CreateCommand())
                {
                    command.CommandText = "Select * from Employees";
                    command.CommandType = CommandType.Text;
                    command.Connection = connection;
                    connection.Open();

                    IDataReader reader = command.ExecuteReader();
                   
                    using (reader)
                    {rawData.Load(reader);}   
                }
            }
            return rawData;
        }
    }
}