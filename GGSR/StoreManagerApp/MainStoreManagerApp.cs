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

namespace GGSR.StoreManagerApp
{
    public partial class MainStoreManagerApp : Form
    {
        private MainLogin logForm;
        public DataBaseManager Database;

        private bool logout = false;

        private sm_GetDepartmentManagers DeptManagersProc;
        private sm_GetDepartments DeptsProc;

        public MainStoreManagerApp(MainLogin lg, DataBaseManager dbm)
        {
            InitializeComponent();
            logForm = lg;
            Database = dbm;
            Database.ChangeConnectionUser(Database.ConnectedUser.UserType);

            SetUserAndStore();

            RefreshDeptManagersList();
            RefreshDeptsList();
            
        }

        private void SetUserAndStore()
        {
            UserNameLbl.Text = Database.ConnectedUser.FirstName + " " + Database.ConnectedUser.LastName;

            var proc = new sm_GetStoreDetails(Database.Connection, Database.StoreId);
            proc.Execute();

            StoreLbl.Text = proc.Result.Name;
        }
        private void AddDeptBtn_Click(object sender, EventArgs e)
        {
            var DeptPP = new DepartmentPP(Database.Connection,GetValidDeptManagers(),this);
            DeptPP.Show();
        }

        private List<DeptManager> GetValidDeptManagers()
        {
            DeptManagersProc = new sm_GetDepartmentManagers(Database.Connection, Database.StoreId);
            DeptManagersProc.Execute();
            List<DeptManager> list = DeptManagersProc.Result;
            return list;
        }

        private void EditDeptBtn_Click(object sender, EventArgs e)
        {
            if (DeptsListView.SelectedIndices.Count == 1)
            {
                var selDept = DeptsProc.Result[DeptsListView.SelectedIndices[0]];
                var DeptPP = new DepartmentPP(Database.Connection, GetValidDeptManagers(), selDept, FindDepartmentManager(selDept.DepartmentId), this);
                DeptPP.Show();
            }        
        }

        private void AddDptMngBtn_Click(object sender, EventArgs e)
        {
            var DepMgnPP = new DepartmentManagerPP(Database.Connection,this);
            DepMgnPP.Show();
        }

        private void EditDeptManagerBtn_Click(object sender, EventArgs e)
        {
            if (DeptManagersListView.SelectedIndices.Count == 1)
            {
                var selManager = DeptManagersProc.Result[DeptManagersListView.SelectedIndices[0]];
                var DepMgnPP = new DepartmentManagerPP(Database.Connection, selManager, this);
                DepMgnPP.Show();
            }
        }

        private void DelDeptManagerBtn_Click(object sender, EventArgs e)
        {
            if (DeptManagersListView.SelectedIndices.Count == 1)
            {
                var selManager = DeptManagersProc.Result[DeptManagersListView.SelectedIndices[0]];
                var proc = new sm_DelDepartmentManager(Database.Connection, selManager.UserId);
                proc.Execute();
            }
            RefreshDeptManagersList();
            RefreshDeptsList();
        }

        private void RefreshDeptsList()
        {
            DeptsProc = new sm_GetDepartments(Database.Connection, Database.StoreId);
            DeptsProc.Execute();
            List<Department> list = DeptsProc.Result;

            DeptsListView.Items.Clear();

            foreach (Department d in list)
            {
                string[] itm = new string[3];
                itm[0] = d.DepartmentId.ToString();
                itm[1] = d.Name;

                DeptManager dm = FindDepartmentManager(d.DepartmentId);

                if (dm == null)
                {
                    itm[2] = "None";
                }
                else
                {
                    itm[2] = dm.ToNameString();
                }
                
                DeptsListView.Items.Add(new ListViewItem(itm));
            }
        }

        private DeptManager FindDepartmentManager(int deptId)
        {
            DeptManagersProc = new sm_GetDepartmentManagers(Database.Connection, Database.StoreId);
            DeptManagersProc.Execute();
            List<DeptManager> list = DeptManagersProc.Result;

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
            DeptManagersProc = new sm_GetDepartmentManagers(Database.Connection, Database.StoreId);
            DeptManagersProc.Execute();
            List<DeptManager> list = DeptManagersProc.Result;

            DeptManagersListView.Items.Clear();

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

                DeptManagersListView.Items.Add(new ListViewItem(itm));
            }
        }
        public void OnPropertyPageClosed()
        {
            RefreshDeptManagersList();
            RefreshDeptsList();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            logForm.ResetLoginForm();
            logForm.Show();
            Database.ConnectedUser = null;
            logout = true;
            this.Dispose();       
        }

        private void DelDepartBtn_Click(object sender, EventArgs e)
        {
            if (DeptsListView.SelectedIndices.Count == 1)
            {
                var selDept = DeptsProc.Result[DeptsListView.SelectedIndices[0]];
                var m = FindDepartmentManager(selDept.DepartmentId);
                if (m == null)
                {
                    var proc = new sm_DelDepartment(Database.Connection, selDept.DepartmentId, -1);
                    proc.Execute();
                }
                else
                {
                    var proc = new sm_DelDepartment(Database.Connection, selDept.DepartmentId,m.UserId);
                    proc.Execute();
                }            
            }

            RefreshDeptsList();
            RefreshDeptManagersList();
        }      
    } 
}
