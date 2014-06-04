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
        private DeptManager currentManager;

        public DepartmentPP(MySqlConnection c, List<DeptManager> l, MainStoreManagerApp pf)
        {
            //New Department
            InitializeComponent();
            connection = c;
            parentForm = pf;
            deptManagers = l;
            SetManagerItems();
        }

        public DepartmentPP(MySqlConnection c, List<DeptManager> l, Department d, DeptManager cm, MainStoreManagerApp pf)
        {
            InitializeComponent();
            connection = c;
            dept = d;
            parentForm = pf;
            deptManagers = l;
            currentManager = cm;
            RefreshFields();
            SetManagerItems();
            AddCurrentlySetManager();
        }

        private void RefreshFields()
        {
            TitleLbl.Text = "Editing Department: " + dept.Name;
            DeptNameInputBox.Text = dept.Name;
        }

        private void SetManagerItems()
        {
            ManagerComboBox.Items.Clear();
            foreach (var d in deptManagers)
            {
                ManagerComboBox.Items.Add(d.ToNameString());
            }
            ManagerComboBox.SelectedIndex = 0;
        }

        private void AddCurrentlySetManager()
        {
            if (currentManager != null)
            {
                deptManagers.Add(currentManager);
                ManagerComboBox.Items.Add(currentManager.ToNameString());
                ManagerComboBox.SelectedIndex = ManagerComboBox.Items.Count - 1;
            }      
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
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

        private void Save()
        {
            String n = DeptNameInputBox.Text.Trim();
            int m = deptManagers[ManagerComboBox.SelectedIndex].UserId;
            int s = parentForm.Database.StoreId;

            if (dept == null)
            {
                var proc = new sm_NewDepartment(connection, n , m , s);
                proc.Execute();
                dept = new Department(proc.Id,n);
            }
            else
            {
                var proc = new StoredProcBase();
                if (currentManager == null)
                {
                    proc = new sm_EditDepartment(connection, n, m, -1, dept.DepartmentId);
                }
                else
                {
                    proc = new sm_EditDepartment(connection, n, m, currentManager.UserId, dept.DepartmentId);
                }
                
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
