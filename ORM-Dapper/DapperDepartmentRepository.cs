using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public class DapperDepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection conn;

        public DapperDepartmentRepository(IDbConnection conn)
        {
            this.conn = conn;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return this.conn.Query<Department>("SELECT * FROM departments");
        }

        public void InsertDepartment(string name) 
        {
            this.conn.Execute("INSERT INTO departments (Name) VALUES (@name)", new {name = name });
        }
    }
}
