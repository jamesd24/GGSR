using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using GGSR.Common;
using GGSR.StoreManagerApp;

namespace GGSR
{
    public struct LoginDetails
    {
        public String Email;
        public String Pass;
        public String Server;
        public int LoginType;
    }

    public partial class MainLogin : Form
    {
        private DataBaseManager DataBase;

        public MainLogin(DataBaseManager db)
        {
            InitializeComponent();
            DataBase = db;
            LoginTypeComboBox.SelectedIndex = 0;

            //Default
            serverTextBox.Text = "localhost";
            PassInputBox.Text = "admin";
            UserNameInputBox.Text = "jamesdahms@gmail.com";
            LoginTypeComboBox.SelectedIndex = 2;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            loadingLbl.Text = "Login In...";
            LoginBtn.Enabled = false;
            backgroundWorker.RunWorkerAsync(LoginArgs());
        }

        private LoginDetails LoginArgs()
        {
            return new LoginDetails()
            {
                Email = UserNameInputBox.Text.Trim(),
                Pass = PassInputBox.Text.Trim(),
                Server = serverTextBox.Text.Trim(),
                LoginType = LoginTypeComboBox.SelectedIndex
            };
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var args = (LoginDetails)e.Argument;
            DataBase.Connect(args.Email,args.Pass,args.Server,args.LoginType);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (DataBase.Connection.State == ConnectionState.Open)
            {
                if (DataBase.ConnectedUser.UserId == -1)
                {
                    MessageBox.Show("Incorrect Login Details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetLoginForm();
                }
                else
                {
                    loadingLbl.Text = "Loading Application...";
                    LaunchApplication();
                }
            }
            else
            {
                ResetLoginForm();
            }
        }

        private void ResetLoginForm()
        {
            loadingLbl.Text = "";
            LoginBtn.Enabled = true;
            DataBase.Connection.Close();
        }

        private void LaunchApplication()
        {
            switch(DataBase.ConnectedUser.UserType)
            {
                case UserType.TEAM_MEMBER:
                    LaunchTeamMemberApp();
                    break;
                case UserType.STORE_MANAGER:
                    LaunchStoreManagerApp();
                    break;
                case UserType.DEPT_MANAGER:
                    LaunchDeptManagerApp();
                    break;
            }
        }

        private void LaunchStoreManagerApp()
        {
            var app = new MainStoreManagerApp(this,DataBase);
            app.Show();
            this.Hide();
        }

        private void LaunchDeptManagerApp()
        {

        }

        private void LaunchTeamMemberApp()
        {

        }
    }   
}
