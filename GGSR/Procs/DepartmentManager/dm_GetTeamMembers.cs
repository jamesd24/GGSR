using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using GGSR.Common;

namespace GGSR.Procs
{
    class dm_GetTeamMembers : StoredProcBase
    {
        private int deptId;
        public List<TeamMember> Result;

        public dm_GetTeamMembers(MySqlConnection c, int d)
        {
            base.Connection = c;
            deptId = d;
        }

        public override void Execute()
        {
            Command = new MySqlCommand(GenerateQuery(), Connection);
            MySqlDataReader read = Command.ExecuteReader();
            Result = new List<TeamMember>();

            while (read.Read())
            {
                int id = read.GetInt32(0);
                string fn = read.GetString(1);
                string ln = read.GetString(2);
                string em = read.GetString(3);

                Result.Add(new TeamMember(fn, ln, em, id));
            }
            read.Close();
        }

        public override string GenerateQuery()
        {
            return String.Format("SELECT tm.employee_id,tm.first_name,tm.last_name,tm.email,tm.roster " +
                    "FROM team_members AS tm WHERE tm.department = {0}", deptId);
        }
    }
}
