using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GGSR.Common
{
    public class Department
    {
        public int DepartmentId;
        public String Name;

        public Department(int id, String n)
        {
            DepartmentId = id;
            Name = n;
        }
    }
}
