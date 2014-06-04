using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using GGSR.Common;

namespace GGSR.Procs
{
    class dm_GetStoreAndDeptDetails : StoredProcBase
    {
        private int storeId;
        private int deptId;
        
        public struct ResultStruct
        {
            public Store DM_STORE;
            public Department DM_DEPT;
        };

        public ResultStruct Result;

        public dm_GetStoreAndDeptDetails(MySqlConnection c, int s, int d)
        {
            base.Connection = c;
            storeId = s;
            deptId = d;
        }

        public override void Execute()
        {
            Command = new MySqlCommand(GenerateQuery(), Connection);
            MySqlDataReader read = Command.ExecuteReader();
            
            Result.DM_STORE = new Store(storeId);
            
            read.Read();    

            Result.DM_STORE.StoreManagerId = read.GetInt32(0);
            Result.DM_STORE.Name = read.GetString(1);
            Result.DM_STORE.Address = read.GetString(2);

            Result.DM_DEPT = new Department(read.GetInt32(3), read.GetString(4));

            read.Close();
        }

        public override string GenerateQuery()
        {
            return String.Format("SELECT s.store_manager , s.store_name , s.address, d.dept_id, d.dept_name " +
                    "FROM stores AS s , department AS d WHERE s.store_id =  {0} AND d.dept_id = {1}", storeId,deptId);
        }
    }
}
