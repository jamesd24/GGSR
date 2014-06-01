using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GGSR.Procs
{
    class log_DeptManagerLogIn : StoredProcBase
    {
        private String email;
        private String pass;

        public ResultStruct Result;

        public struct ResultStruct
        {
            public int DM_ID;
            public string DM_EMAIL;
            public string DM_FIRST_NAME;
            public string DM_LAST_NAME;
        }

        public log_DeptManagerLogIn(MySqlConnection c, String em, String p)
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
                Result.DM_ID = -1;
            }
            else
            {
                Result.DM_ID = read.GetInt32(0);
                Result.DM_EMAIL = read.GetString(1);
                Result.DM_FIRST_NAME = read.GetString(2);
                Result.DM_LAST_NAME = read.GetString(3);
            }          
            read.Close();
            
        }

        public override string GenerateQuery()
        {
            return "SELECT manager_id , email , first_name , last_name FROM dept_managers " +
                        "WHERE email = '" + email + "' AND password = '" + pass + "'";
        }
    }
}
