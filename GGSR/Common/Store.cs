using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GGSR.Common
{
    class Store
    {
        public int StoreId;
        public String Name;
        public int StoreManagerId;
        public String Address;

        public Store(int id, String n, int sm, String a)
        {
            StoreId = id;
            Name = n;
            StoreManagerId = sm;
            Address = a;
        }

        public Store(int id)
        {
            StoreId = id;
        }
    }
}
