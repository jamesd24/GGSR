using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GGSR.Common;
using GGSR.Procs;

namespace GGSR.DeptManagerApp
{
    public partial class MainDeptManagerApp : Form
    {
        private MainLogin logForm;
        public DataBaseManager Database;

        private bool logout = false;

        private sm_GetDepartmentManagers RosterListProc;
        private dm_GetTeamMembers TeamListProc;

        public MainDeptManagerApp(MainLogin lg, DataBaseManager dbm)
        {
            InitializeComponent();
            logForm = lg;
            Database = dbm;
            Database.ChangeConnectionUser(Database.ConnectedUser.UserType);

            SetUserStoreDept();

            RefreshDeptManagersList();
            RefreshTeamList();
            
        }

        private void SetUserStoreDept()
        {
            UserNameLbl.Text = Database.ConnectedUser.FirstName + " " + Database.ConnectedUser.LastName;

            var proc = new dm_GetStoreAndDeptDetails(Database.Connection, Database.StoreId, Database.DeptId);
            proc.Execute();

            StoreLbl.Text = proc.Result.DM_STORE.Name;
            DeptLbl.Text = proc.Result.DM_DEPT.Name;
            
        }
        private void AddDeptBtn_Click(object sender, EventArgs e)
        {
            var teamPP = new TeamMemberPP(Database.Connection,this);
            teamPP.Show();
        }

        private List<DeptManager> GetValidDeptManagers()
        {
            RosterListProc = new sm_GetDepartmentManagers(Database.Connection, Database.StoreId);
            RosterListProc.Execute();
            List<DeptManager> list = RosterListProc.Result;
            return list;
        }

        private void EditDeptBtn_Click(object sender, EventArgs e)
        {
            if (TeamListView.SelectedIndices.Count == 1)
            {
                var selTeam = TeamListProc.Result[TeamListView.SelectedIndices[0]];
                var teamPP = new TeamMemberPP(Database.Connection, selTeam, this);
                teamPP.Show();
            }        
        }

        private void AddDptMngBtn_Click(object sender, EventArgs e)
        {
            //var DepMgnPP = new DepartmentManagerPP(Database.Connection,this);
            //DepMgnPP.Show();
        }

        private void EditDeptManagerBtn_Click(object sender, EventArgs e)
        {
            if (RostersListView.SelectedIndices.Count == 1)
            {
                //var selManager = DeptManagersProc.Result[RostersListView.SelectedIndices[0]];
                //var DepMgnPP = new DepartmentManagerPP(Database.Connection, selManager, this);
                //DepMgnPP.Show();
            }
        }

        private void DelDeptManagerBtn_Click(object sender, EventArgs e)
        {
            if (RostersListView.SelectedIndices.Count == 1)
            {
                //var selManager = DeptManagersProc.Result[RostersListView.SelectedIndices[0]];
                //var proc = new sm_DelDepartmentManager(Database.Connection, selManager.UserId);
                //proc.Execute();
            }
            RefreshDeptManagersList();
            RefreshTeamList();
        }

        private void RefreshTeamList()
        {
            TeamListProc = new dm_GetTeamMembers(Database.Connection, Database.StoreId);
            TeamListProc.Execute();
            List<TeamMember> list = TeamListProc.Result;

            TeamListView.Items.Clear();

            foreach (TeamMember t in list)
            {
                string[] itm = new string[6];
                itm[0] = t.UserId.ToString();
                itm[1] = t.FirstName;
                itm[2] = t.LastName;
                itm[3] = "None";
                itm[4] = "None";
                itm[5] = "0 hrs";
                
                TeamListView.Items.Add(new ListViewItem(itm));
            }
        }

        private DeptManager FindDepartmentManager(int deptId)
        {
            RosterListProc = new sm_GetDepartmentManagers(Database.Connection, Database.StoreId);
            RosterListProc.Execute();
            List<DeptManager> list = RosterListProc.Result;

            foreach (DeptManager dm in list)
            {
                if(dm.Dept != null)
                {
                    if (dm.Dept.DepartmentId == deptId) return dm;
                }
            }
            
            return null;
        }

        private void RefreshDeptManagersList()
        {
            RosterListProc = new sm_GetDepartmentManagers(Database.Connection, Database.StoreId);
            RosterListProc.Execute();
            List<DeptManager> list = RosterListProc.Result;

            RostersListView.Items.Clear();

            foreach (DeptManager dm in list)
            {
                string[] itm = new string[4];
                itm[0] = dm.UserId.ToString();
                itm[1] = dm.FirstName;
                itm[2] = dm.LastName;

                if (dm.Dept == null)
                {
                    itm[3] = "None";
                }
                else
                {
                    itm[3] = dm.Dept.Name;
                }

                RostersListView.Items.Add(new ListViewItem(itm));
            }
        }
        public void OnPropertyPageClosed()
        {
            RefreshDeptManagersList();
            RefreshTeamList();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            logForm.ResetLoginForm();
            logForm.Show();
            Database.ConnectedUser = null;
            logout = true;
            this.Dispose();       
        }

        private void DelTeamBtn_Click(object sender, EventArgs e)
        {
            if (TeamListView.SelectedIndices.Count == 1)
            {
                var selTeam = TeamListProc.Result[TeamListView.SelectedIndices[0]];
                var proc = new dm_DelTeamMember(Database.Connection, selTeam.UserId);
                proc.Execute();
                          
            }
            RefreshTeamList();
            RefreshDeptManagersList();
        }      
    } 
}
