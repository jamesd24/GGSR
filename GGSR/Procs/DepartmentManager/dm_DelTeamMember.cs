using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GGSR.Procs
{
    class dm_DelTeamMember : StoredProcBase
    {
        private int id;

        public dm_DelTeamMember(MySqlConnection c, int id)
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
            return "DELETE FROM team_members WHERE employee_id="+id;
        }
    }
}
