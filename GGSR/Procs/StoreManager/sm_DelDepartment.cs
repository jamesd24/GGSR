using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GGSR.Procs
{
    class sm_DelDepartment : StoredProcBase
    {
        private int deptId;
        private int managerId;

        public sm_DelDepartment(MySqlConnection c, int deptId, int managerId)
        {
            base.Connection = c;
            this.deptId = deptId;
            this.managerId = managerId;
        }

        public override void Execute()
        {
            if (managerId != -1)
            {
                Command = new MySqlCommand(GenerateQuery(), Connection);
                Command.Prepare();
                Command.ExecuteNonQuery();
            }
            
            Command = new MySqlCommand(SecondQuery(), Connection);
            Command.Prepare();
            Command.ExecuteNonQuery();
        }

        public override string GenerateQuery()
        {
            return string.Format("UPDATE dept_managers SET dept = null WHERE manager_id = {0}", managerId);
        }

        public string SecondQuery()
        {
            return string.Format("DELETE FROM department WHERE dept_id = {0}", deptId);
        }
    }
}
