using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GGSR.Procs
{
    class sm_DelDepartmentManager : StoredProcBase
    {
        private int id;

        public sm_DelDepartmentManager(MySqlConnection c, int id)
        {
            base.Connection = c;
            this.id = id;
        }

        public override void Execute()
        {
            Command = new MySqlCommand(GenerateQuery(), Connection);
            Command.Prepare();
            Command.ExecuteNonQuery();        
        }

        public override string GenerateQuery()
        {
            return "DELETE FROM dept_managers WHERE manager_id="+id;
        }
    }
}
