using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GGSR.Procs
{
    class StoredProcBase
    {
        public MySqlCommand Command;

        public MySqlConnection Connection;

        public StoredProcBase(MySqlConnection c)
        {
            Connection = c;
        }

        public StoredProcBase()
        {
        }

        public virtual void Execute()
        {
            throw new NotImplementedException();
        }

        public virtual String GenerateQuery()
        {
            throw new NotImplementedException();
        }
    }
}
