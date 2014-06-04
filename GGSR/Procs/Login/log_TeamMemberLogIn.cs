using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GGSR.Procs
{
    class log_TeamMemberLogIn : StoredProcBase
    {
        private String email;
        private String pass;

        public ResultStruct Result;

        public struct ResultStruct
        {
            public int TM_ID;
            public string TM_EMAIL;
            public string TM_FIRST_NAME;
            public string TM_LAST_NAME;
        }

        public log_TeamMemberLogIn(MySqlConnection c, String em, String p)
        {
            base.Connection = c;
            email = em;
            pass = p;
        }

        public override void Execute()
        {
            Command = new MySqlCommand(GenerateQuery(), Connection);
            MySqlDataReader read = Command.ExecuteReader();
            Result = new ResultStruct();

            if (!read.Read())
            {
                //Incorect Login
                Result.TM_ID = -1;
            }
            else
            {
                Result.TM_ID = read.GetInt32(0);
                Result.TM_EMAIL = read.GetString(1);
                Result.TM_FIRST_NAME = read.GetString(2);
                Result.TM_LAST_NAME = read.GetString(3);
            }          
            read.Close();
            
        }

        public override string GenerateQuery()
        {
            return "SELECT employee_id , email , first_name , last_name FROM team_members " +
                        "WHERE email = '" + email + "' AND password = '" + pass + "'";
        }
    }
}
