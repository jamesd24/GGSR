using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using GGSR.Procs;

namespace GGSR.Common
{
    public class User
    {
        public String FirstName;
        public String LastName;
        public String Email;
        public UserType UserType;
        public Int32 UserId;

        public User(String fn, String ln, String em, UserType ut, int id)
        {
            FirstName = fn;
            LastName = ln;
            Email = em;
            UserType = ut;
            UserId = id;
        }

        public User()
        {
        }
    }

    public class StoreManager : User
    {
    }

    public class DeptManager : User
    {
        public Department Dept;

        public DeptManager(String fn, String ln, String em, int id, Department dept)
        {
            FirstName = fn;
            LastName = ln;
            Email = em;
            UserType = UserType.DEPT_MANAGER;
            UserId = id;
            Dept = dept;
        }
    }

    public class TeamMember : User
    {

    }


    public enum UserType
    {
        TEAM_MEMBER = 0,
        DEPT_MANAGER = 1,
        STORE_MANAGER = 2,
        INVALID = 3
    }
}
