using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GGSR.Procs
{
    class log_StoreManagerLogIn : StoredProcBase
    {
        private String email;
        private String pass;

        public ResultStruct Result;

        public struct ResultStruct
        {
            public int SM_ID;
            public string SM_EMAIL;
            public string SM_FIRST_NAME;
            public string SM_LAST_NAME;
        }

        public log_StoreManagerLogIn(MySqlConnection c, String em, String p)
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
                Result.SM_ID = -1;
            }
            else
            {
                Result.SM_ID = read.GetInt32(0);
                Result.SM_EMAIL = read.GetString(1);
                Result.SM_FIRST_NAME = read.GetString(2);
                Result.SM_LAST_NAME = read.GetString(3);
            }          
            read.Close();
            
        }

        public override string GenerateQuery()
        {
            return "SELECT sm_id , email , first_name , last_name FROM store_managers " +
                        "WHERE email = '" + email + "' AND password = '" + pass + "'";
        }
    }
}
