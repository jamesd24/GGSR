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
            public int DM_STORE_ID;
            public int DM_DEPT_ID;
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
                Result.DM_STORE_ID = read.GetInt32(4);
                Result.DM_DEPT_ID = read.GetInt32(5);
            }          
            read.Close();
            
        }

        public override string GenerateQuery()
        {
            return String.Format(
                "SELECT dm.manager_id , dm.email , dm.first_name , dm.last_name, d.store, dm.dept " + 
                "FROM dept_managers AS dm, department AS d " + 
                "WHERE dm.email = '{0}' AND dm.password = '{1}' " +
                "AND dm.dept = d.dept_id", email,pass);
        }
    }
}
