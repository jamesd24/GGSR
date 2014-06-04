using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using GGSR.Common;

namespace GGSR.Procs
{
    class sm_GetStoreDetails : StoredProcBase
    {
        private int storeId;
        public Store Result;

        public sm_GetStoreDetails(MySqlConnection c, int s)
        {
            base.Connection = c;
            storeId = s;
        }

        public override void Execute()
        {
            Command = new MySqlCommand(GenerateQuery(), Connection);
            MySqlDataReader read = Command.ExecuteReader();
            Result = new Store(storeId);

            read.Read();    

            Result.StoreManagerId = read.GetInt32(0);
            Result.Name = read.GetString(1);
            Result.Address = read.GetString(2);

            read.Close();
        }

        public override string GenerateQuery()
        {
            return "SELECT store_manager , store_name , address FROM stores WHERE store_id = " + storeId;
        }
    }
}
