using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GGSR.Procs;
using MySql.Data.MySqlClient;
using GGSR.Common;

namespace GGSR.StoreManagerApp
{
    public partial class DepartmentManagerPP : Form
    {
        private MySqlConnection connection;

        private User manager = null;

        public DepartmentManagerPP(MySqlConnection c)
        {
            //New Manager
            InitializeComponent();
            connection = c;
        }
        public DepartmentManagerPP(MySqlConnection c, User u)
        {
            InitializeComponent();
            manager = u;
            RefreshFields();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }

        private void Save()
        {
            String fn = FirstInputBox.Text.Trim();
            String ln = LastInputBox.Text.Trim();
            String em = EmailInputBox.Text.Trim();
            String p = PassInputBox.Text;

            if (manager == null)
            {
                var proc = new sm_NewDepartmentManager(connection, em, p, fn, ln);
                proc.Execute();
                manager = new User(fn, ln, em, UserType.STORE_MANAGER, proc.Id);
            }
            else
            {
                var proc = new sm_EditDepartmentManager(connection, em, fn, ln, manager.UserId);
                proc.Execute();
                manager = new User(fn, ln, em, UserType.STORE_MANAGER, manager.UserId);
            }
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            Save();
            RefreshFields();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshFields()
        {
            TitleLbl.Text = "Editing Department Manager: " + manager.FirstName + " " + manager.LastName;
            FirstInputBox.Text = manager.FirstName;
            LastInputBox.Text = manager.LastName;
            EmailInputBox.Text = manager.Email;
            PassInputBox.Visible = false;
            PassLbl.Visible = false;
        }
    }
}
