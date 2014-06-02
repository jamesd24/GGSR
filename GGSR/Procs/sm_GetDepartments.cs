using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using GGSR.Common;

namespace GGSR.Procs
{
    class sm_GetDepartments : StoredProcBase
    {
        private int storeId;
        public List<Department> Result;

        public sm_GetDepartments(MySqlConnection c, int s)
        {
            base.Connection = c;
            storeId = s;
        }

        public override void Execute()
        {
            Command = new MySqlCommand(GenerateQuery(), Connection);
            MySqlDataReader read = Command.ExecuteReader();
            Result = new List<Department>();

            while (read.Read())
            {
                int deptId = read.GetInt32(0);
                string deptName = read.GetString(1);

                var d = new Department(deptId,deptName);
                
                Result.Add(d);
            }
            read.Close();
        }

        public override string GenerateQuery()
        {
            return "SELECT dept_id , dept_name FROM department WHERE store = " + storeId;
        }
    }
}
