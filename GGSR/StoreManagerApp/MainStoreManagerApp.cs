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

        private sm_GetDepartmentManagers DeptManagersProc;

        public MainStoreManagerApp(MainLogin lg, DataBaseManager dbm)
        {
            InitializeComponent();
            logForm = lg;
            Database = dbm;
            Database.ChangeConnectionUser(Database.ConnectedUser.UserType);

            RefreshDeptManagersList();
            
        }

        private void AddDeptBtn_Click(object sender, EventArgs e)
        {
            var DeptPP = new DepartmentPP();
            DeptPP.Show();
        }

        private void EditDeptBtn_Click(object sender, EventArgs e)
        {
            var DeptPP = new DepartmentPP(true);
            DeptPP.Show();
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
            //TODO Refresh other list
        }      
    } 
}
