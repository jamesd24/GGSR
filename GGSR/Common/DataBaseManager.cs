using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using GGSR.Procs;

namespace GGSR.Common
{
    public class DataBaseManager
    {
        private String LoginConnStr;

        public MySqlConnection Connection = null;

        public User ConnectedUser;

        public void Connect(String Email, String Pass, String Server, int LoginType )
        {
            LoginConnStr = @"server=" + Server + ";userid=Login;password=loginmanager;database=ggsr";

            try
            {
                Connection = new MySqlConnection(LoginConnStr);
                Connection.Open();
                Login(Email, Pass, LoginType);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                Connection.Close();
            }
        }

        private void Login(String Email, String Pass, int Type)
        {
            var userType = new UserType();

            switch (Type)
            {
                case 0:
                    userType = UserType.TEAM_MEMBER;
                    break;
                case 1:
                    userType = UserType.DEPT_MANAGER;
                    break;
                case 2:
                    userType = UserType.STORE_MANAGER;
                    break;
            }
            LoginCommand(userType, Email, Pass);
        }

        private void LoginCommand(UserType Type, String Email, String Pass)
        {
            if (Type == UserType.STORE_MANAGER)
            {
                var loginProc = new log_StoreManagerLogIn(Connection, Email, Pass);
                loginProc.Execute();

                if (loginProc.Result.SM_ID > 0)
                {
                    ConnectedUser = new User(loginProc.Result.SM_FIRST_NAME,
                            loginProc.Result.SM_LAST_NAME,
                            loginProc.Result.SM_EMAIL,
                            Type,
                            loginProc.Result.SM_ID);
                }
                else
                {
                    ConnectedUser = IncorectLogin();
                }
            }
            else if (Type == UserType.DEPT_MANAGER)
            {
                var loginProc = new log_DeptManagerLogIn(Connection, Email, Pass);
                loginProc.Execute();

                if (loginProc.Result.DM_ID > 0)
                {
                    ConnectedUser = new User(loginProc.Result.DM_FIRST_NAME,
                            loginProc.Result.DM_LAST_NAME,
                            loginProc.Result.DM_EMAIL,
                            Type,
                            loginProc.Result.DM_ID);
                }
                else
                {
                    ConnectedUser = IncorectLogin();
                }
            }
            else if (Type == UserType.TEAM_MEMBER)
            {
                var loginProc = new log_TeamMemberLogIn(Connection, Email, Pass);
                loginProc.Execute();

                if (loginProc.Result.TM_ID > 0)
                {
                    ConnectedUser = new User(loginProc.Result.TM_FIRST_NAME,
                            loginProc.Result.TM_LAST_NAME,
                            loginProc.Result.TM_EMAIL,
                            Type,
                            loginProc.Result.TM_ID);
                }
                else
                {
                    ConnectedUser = IncorectLogin();
                }
            }
        }

        private User IncorectLogin()
        {
            return new User("INCORECT","LOGIN","ERROR",UserType.INVALID,-1);
        }
    }
}
