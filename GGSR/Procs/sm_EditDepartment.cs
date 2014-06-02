using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GGSR.Procs
{
    class sm_EditDepartment : StoredProcBase
    {
        private String Name;
        private int managerId;
        private int deptId;

        public sm_EditDepartment(MySqlConnection c, String n, int m, int d)
        {
            base.Connection = c;
            Name = n;
            managerId = m;
            deptId = d;
        }

        public override void Execute()
        {
            Command = new MySqlCommand(GenerateQuery(), Connection);
            Command.Prepare();
            Command.ExecuteNonQuery();

            Command = new MySqlCommand(GetIdQuery(), Connection);
            MySqlDataReader read = Command.ExecuteReader();

            Command = new MySqlCommand(UpdateManagerQuery(), Connection);
            Command.Prepare();
            Command.ExecuteNonQuery();

        }

        public override string GenerateQuery()
        {
            return string.Format("INSERT INTO department(dept_name,store) VALUES({0},{1})", Name, deptId);
        }

        private string GetIdQuery()
        {
            return "SELECT dept_id FROM department ORDER BY dept_id DESC LIMIT 1";
        }

        private string UpdateManagerQuery()
        {
            return string.Format("UPDATE dept_managers SET dept = {0} WHERE manager_id = {1}",deptId,managerId);
        }
    }
}
