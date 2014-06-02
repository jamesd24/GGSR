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
using GGSR.Procs;

namespace GGSR.StoreManagerApp
{
    public partial class DepartmentPP : Form
    {
        private MySqlConnection connection;
        private Department dept = null;
        private MainStoreManagerApp parentForm;
        private List<DeptManager> deptManagers;

        public DepartmentPP(MySqlConnection c, List<DeptManager> l, MainStoreManagerApp pf)
        {
            //New Department
            InitializeComponent();
            connection = c;
            parentForm = pf;
            deptManagers = l;
        }

        public DepartmentPP(MySqlConnection c, List<DeptManager> l, Department d, MainStoreManagerApp pf)
        {
            InitializeComponent();
            connection = c;
            dept = d;
            parentForm = pf;
            RefreshFields();
        }

        private void RefreshFields()
        {
            TitleLbl.Text = "Editing Department: " + dept.Name;
            //TODO More
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Save();
            this.Dispose();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            Save();
            RefreshFields();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Save()
        {
            String n = DeptNameInputBox.Text.Trim();
            int m = 1;
            int s = parentForm.Database.StoreId;

            if (dept == null)
            {
                var proc = new sm_NewDepartment(connection, n , m , s);
                proc.Execute();
                dept = new Department(proc.Id,n);
            }
            else
            {
                var proc = new sm_EditDepartment(connection, n, m, dept.DepartmentId);
                proc.Execute();
                dept = new Department(dept.DepartmentId,n);
            }
        }

        private void DepartmentPP_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.OnPropertyPageClosed();
        }
    }
}
