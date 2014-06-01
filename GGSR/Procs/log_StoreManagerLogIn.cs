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
            public int SM_STORE_ID;
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
                Result.SM_STORE_ID = read.GetInt32(4);
            }          
            read.Close();
            
        }

        public override string GenerateQuery()
        {
            return "SELECT sm.sm_id , sm.email , sm.first_name , sm.last_name, s.store_id FROM store_managers AS sm, stores AS s " +
                        "WHERE sm.email = '" + email + "' AND sm.password = '" + pass + "'" + "AND s.store_manager = sm.sm_id";
        }
    }
}
