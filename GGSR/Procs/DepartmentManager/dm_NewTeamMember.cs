using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GGSR.Procs
{
    class dm_NewTeamMember : StoredProcBase
    {
        private String firstName;
        private String lastName;
        private String email;
        private String pass;
        private int dept;

        public int Id = 0;

        public dm_NewTeamMember(MySqlConnection c, String em, String p, String fn, String ln, int d)
        {
            base.Connection = c;
            firstName = fn;
            lastName = ln;
            email = em;
            pass = p;
            dept = d;
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
            return "INSERT INTO team_members(first_name,last_name,email,password,department) VALUES('"
                    + firstName + "','"
                    + lastName + "','"
                    + email + "','"
                    + pass + "',"
                    + dept + ")";
        }

        private string GetIdQuery()
        {
            return "SELECT employee_id FROM team_members ORDER BY employee_id DESC LIMIT 1";
        }
    }
}
