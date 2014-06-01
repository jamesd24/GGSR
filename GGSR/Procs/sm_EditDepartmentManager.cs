using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GGSR.Procs
{
    class sm_EditDepartmentManager : StoredProcBase
    {
        private String firstName;
        private String lastName;
        private String email;
        private int id;

        public sm_EditDepartmentManager(MySqlConnection c, String em, String fn, String ln, int id)
        {
            base.Connection = c;
            firstName = fn;
            lastName = ln;
            email = em;
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
            return "UPDATE dept_managers " + 
                "SET first_name='"+ firstName + "'," +
                "last_name='" + lastName + "'," +
                "email='" + email + "' WHERE manager_id="+id;
        }
    }
}
