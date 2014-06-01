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
        private DataBaseManager database;

        private sm_GetDepartmentManagers DeptManagersProc;

        public MainStoreManagerApp(MainLogin lg, DataBaseManager dbm)
        {
            InitializeComponent();
            logForm = lg;
            database = dbm;
            database.ChangeConnectionUser(database.ConnectedUser.UserType);

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
            var DepMgnPP = new DepartmentManagerPP(database.Connection);
            DepMgnPP.Show();
        }

        private void RefreshDeptManagersList()
        {
            DeptManagersProc = new sm_GetDepartmentManagers(database.Connection, database.StoreId);
            DeptManagersProc.Execute();
            List<DeptManager> list = DeptManagersProc.Result;

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
    }
}
