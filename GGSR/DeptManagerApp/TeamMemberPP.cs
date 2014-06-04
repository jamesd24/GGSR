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

namespace GGSR.DeptManagerApp
{
    public partial class TeamMemberPP : Form
    {
        private MySqlConnection connection;
        private User teamMember = null;
        private MainDeptManagerApp parentForm;

        public TeamMemberPP(MySqlConnection c, MainDeptManagerApp pf)
        {
            //New Team Member
            InitializeComponent();
            connection = c;
            parentForm = pf;
        }
        public TeamMemberPP(MySqlConnection c, TeamMember tm, MainDeptManagerApp pf)
        {
            InitializeComponent();
            connection = c;
            teamMember = tm;
            parentForm = pf;
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
            int d = parentForm.Database.StoreId;

            if (teamMember == null)
            {
                var proc = new dm_NewTeamMember(connection, em, p, fn, ln, d);
                proc.Execute();
                teamMember = new User(fn, ln, em, UserType.TEAM_MEMBER, proc.Id);
            }
            else
            {
                var proc = new dm_EditTeamMember(connection, em, fn, ln, teamMember.UserId);
                proc.Execute();
                teamMember = new User(fn, ln, em, UserType.TEAM_MEMBER, teamMember.UserId);
            }
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            Save();
            RefreshFields();
            parentForm.OnPropertyPageClosed();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshFields()
        {
            TitleLbl.Text = "Editing Team Member: " + teamMember.FirstName + " " + teamMember.LastName;
            FirstInputBox.Text = teamMember.FirstName;
            LastInputBox.Text = teamMember.LastName;
            EmailInputBox.Text = teamMember.Email;
            PassInputBox.Visible = false;
            PassLbl.Visible = false;
        }

        private void DepartmentManagerPP_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.OnPropertyPageClosed();
        }
    }
}
