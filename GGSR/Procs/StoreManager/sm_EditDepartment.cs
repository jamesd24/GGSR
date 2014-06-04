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
        private int newManagerId; 
        private int oldManagerId;
        private int deptId;

        public sm_EditDepartment(MySqlConnection c, String n, int m, int o, int d)
        {
            base.Connection = c;
            Name = n;
            newManagerId = m;
            oldManagerId = o;
            deptId = d;
        }

        public override void Execute()
        {
            Command = new MySqlCommand(GenerateQuery(), Connection);
            Command.Prepare();
            Command.ExecuteNonQuery();

            if (oldManagerId != -1)
            {
                Command = new MySqlCommand(UpdateOldManagerQuery(), Connection);
                Command.Prepare();
                Command.ExecuteNonQuery();
            }
           
            Command = new MySqlCommand(UpdateNewManagerQuery(), Connection);
            Command.Prepare();
            Command.ExecuteNonQuery();

        }

        public override string GenerateQuery()
        {
            return string.Format("UPDATE department SET dept_name = '{0}' WHERE dept_id = {1}", Name, deptId);
        }

        private string UpdateOldManagerQuery()
        {
            return string.Format("UPDATE dept_managers SET dept = null WHERE manager_id = {0}", oldManagerId);
        }

        private string UpdateNewManagerQuery()
        {
            return string.Format("UPDATE dept_managers SET dept = {0} WHERE manager_id = {1}",deptId,newManagerId);
        }
    }
}
