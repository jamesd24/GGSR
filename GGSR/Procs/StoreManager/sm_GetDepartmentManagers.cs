using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using GGSR.Common;

namespace GGSR.Procs
{
    class sm_GetDepartmentManagers : StoredProcBase
    {
        private int storeId;
        public List<DeptManager> Result;

        public sm_GetDepartmentManagers(MySqlConnection c, int s)
        {
            base.Connection = c;
            storeId = s;
        }

        public override void Execute()
        {
            Command = new MySqlCommand(GenerateQuery(), Connection);
            MySqlDataReader read = Command.ExecuteReader();
            Result = new List<DeptManager>();

            while (read.Read())
            {
                int id = read.GetInt32(0);
                string fn = read.GetString(1);
                string ln = read.GetString(2);
                string em = read.GetString(3);

                int deptId = read.GetInt32(4);
                string deptName = read.GetString(5);

                var d = new Department(deptId,deptName);
                
                Result.Add(new DeptManager(fn,ln,em,id,d));
            }
            read.Close();

            Command = new MySqlCommand(GenerateSecondQuery(), Connection);
            read = Command.ExecuteReader();

            while (read.Read())
            {
                int id = read.GetInt32(0);
                string fn = read.GetString(1);
                string ln = read.GetString(2);
                string em = read.GetString(3);

                Result.Add(new DeptManager(fn, ln, em, id, null));
            }
            read.Close();

        }

        public override string GenerateQuery()
        {
            return "SELECT dm.manager_id,dm.first_name,dm.last_name,dm.email,d.dept_id,d.dept_name FROM dept_managers AS dm, department AS d WHERE dm.store = "+ 
                storeId +" AND dm.dept = d.dept_id";
        }

        private string GenerateSecondQuery()
        {
            return "SELECT manager_id,first_name,last_name,email FROM dept_managers WHERE dept is null AND store = " + storeId;
        }
    }
}
