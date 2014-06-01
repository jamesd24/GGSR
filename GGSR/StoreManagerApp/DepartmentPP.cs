using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GGSR.StoreManagerApp
{
    public partial class DepartmentPP : Form
    {
        private Boolean isNew = false;

        public DepartmentPP()
        {
            InitializeComponent();
        }
        public DepartmentPP(Boolean isNew)
        {
            InitializeComponent();
            this.isNew = isNew;
            TitleLbl.Text = "Edit Department";

        }

    }
}
