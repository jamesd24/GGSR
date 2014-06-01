using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GGSR.Procs
{
    class sm_NewDepartmentManager : StoredProcBase
    {
        private String firstName;
        private String lastName;
        private String email;
        private String pass;

        public int Id = 0;

        public sm_NewDepartmentManager(MySqlConnection c, String em, String p, String fn, String ln)
        {
            base.Connection = c;
            firstName = fn;
            lastName = ln;
            email = em;
            pass = p;
        }

        public override void Execute()
        {
            Command = new MySqlCommand(GenerateQuery(), Connection);
            Command.Prepare();
            Command.ExecuteNonQuery();

            Command = new MySqlCommand(GetIdQuery(), Connection);
            MySqlDataReader read = Command.ExecuteReader();

            read.Read();
            Id = read.GetInt32(0);        
            read.Close();

        }

        public override string GenerateQuery()
        {
            return "INSERT INTO dept_managers(first_name,last_name,email,password) VALUES('"
                    + firstName + "','"
                    + lastName + "','"
                    + email + "','"
                    + pass + "')";
        }

        private string GetIdQuery()
        {
            return "SELECT manager_id FROM dept_managers ORDER BY manager_id DESC LIMIT 1";
        }
    }
}
