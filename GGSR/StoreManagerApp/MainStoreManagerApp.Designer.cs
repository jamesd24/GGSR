﻿namespace GGSR.StoreManagerApp
{
    partial class MainStoreManagerApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

            if (!logout)
            {
                logForm.Dispose();
            }          
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabDptManagers = new System.Windows.Forms.TabControl();
            this.tabDepartments = new System.Windows.Forms.TabPage();
            this.DeptsListView = new System.Windows.Forms.ListView();
            this.IDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ManagerCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DelDepartBtn = new System.Windows.Forms.Button();
            this.EditDeptBtn = new System.Windows.Forms.Button();
            this.AddDeptBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DeptManagersListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DelDeptManagerBtn = new System.Windows.Forms.Button();
            this.EditDeptManagerBtn = new System.Windows.Forms.Button();
            this.AddDptMngBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StoreLbl = new System.Windows.Forms.Label();
            this.tabDptManagers.SuspendLayout();
            this.tabDepartments.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDptManagers
            // 
            this.tabDptManagers.Controls.Add(this.tabDepartments);
            this.tabDptManagers.Controls.Add(this.tabPage2);
            this.tabDptManagers.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDptManagers.Location = new System.Drawing.Point(12, 79);
            this.tabDptManagers.Name = "tabDptManagers";
            this.tabDptManagers.SelectedIndex = 0;
            this.tabDptManagers.Size = new System.Drawing.Size(662, 465);
            this.tabDptManagers.TabIndex = 0;
            // 
            // tabDepartments
            // 
            this.tabDepartments.BackColor = System.Drawing.SystemColors.Control;
            this.tabDepartments.Controls.Add(this.DeptsListView);
            this.tabDepartments.Controls.Add(this.DelDepartBtn);
            this.tabDepartments.Controls.Add(this.EditDeptBtn);
            this.tabDepartments.Controls.Add(this.AddDeptBtn);
            this.tabDepartments.Location = new System.Drawing.Point(4, 25);
            this.tabDepartments.Name = "tabDepartments";
            this.tabDepartments.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepartments.Size = new System.Drawing.Size(654, 436);
            this.tabDepartments.TabIndex = 0;
            this.tabDepartments.Text = "Departments";
            // 
            // DeptsListView
            // 
            this.DeptsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDCol,
            this.NameCol,
            this.ManagerCol});
            this.DeptsListView.FullRowSelect = true;
            this.DeptsListView.Location = new System.Drawing.Point(6, 6);
            this.DeptsListView.MultiSelect = false;
            this.DeptsListView.Name = "DeptsListView";
            this.DeptsListView.Size = new System.Drawing.Size(496, 396);
            this.DeptsListView.TabIndex = 4;
            this.DeptsListView.UseCompatibleStateImageBehavior = false;
            this.DeptsListView.View = System.Windows.Forms.View.Details;
            // 
            // IDCol
            // 
            this.IDCol.Text = "ID";
            this.IDCol.Width = 56;
            // 
            // NameCol
            // 
            this.NameCol.Text = "Name";
            this.NameCol.Width = 142;
            // 
            // ManagerCol
            // 
            this.ManagerCol.Text = "Manager";
            this.ManagerCol.Width = 145;
            // 
            // DelDepartBtn
            // 
            this.DelDepartBtn.Location = new System.Drawing.Point(506, 63);
            this.DelDepartBtn.Name = "DelDepartBtn";
            this.DelDepartBtn.Size = new System.Drawing.Size(142, 23);
            this.DelDepartBtn.TabIndex = 3;
            this.DelDepartBtn.Text = "Delete";
            this.DelDepartBtn.UseVisualStyleBackColor = true;
            this.DelDepartBtn.Click += new System.EventHandler(this.DelDepartBtn_Click);
            // 
            // EditDeptBtn
            // 
            this.EditDeptBtn.Location = new System.Drawing.Point(506, 35);
            this.EditDeptBtn.Name = "EditDeptBtn";
            this.EditDeptBtn.Size = new System.Drawing.Size(142, 23);
            this.EditDeptBtn.TabIndex = 2;
            this.EditDeptBtn.Text = "Edit";
            this.EditDeptBtn.UseVisualStyleBackColor = true;
            this.EditDeptBtn.Click += new System.EventHandler(this.EditDeptBtn_Click);
            // 
            // AddDeptBtn
            // 
            this.AddDeptBtn.Location = new System.Drawing.Point(506, 6);
            this.AddDeptBtn.Name = "AddDeptBtn";
            this.AddDeptBtn.Size = new System.Drawing.Size(143, 23);
            this.AddDeptBtn.TabIndex = 1;
            this.AddDeptBtn.Text = "Add";
            this.AddDeptBtn.UseVisualStyleBackColor = true;
            this.AddDeptBtn.Click += new System.EventHandler(this.AddDeptBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.DeptManagersListView);
            this.tabPage2.Controls.Add(this.DelDeptManagerBtn);
            this.tabPage2.Controls.Add(this.EditDeptManagerBtn);
            this.tabPage2.Controls.Add(this.AddDptMngBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(654, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Department Managers";
            // 
            // DeptManagersListView
            // 
            this.DeptManagersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.DeptManagersListView.FullRowSelect = true;
            this.DeptManagersListView.Location = new System.Drawing.Point(5, 6);
            this.DeptManagersListView.MultiSelect = false;
            this.DeptManagersListView.Name = "DeptManagersListView";
            this.DeptManagersListView.Size = new System.Drawing.Size(496, 396);
            this.DeptManagersListView.TabIndex = 8;
            this.DeptManagersListView.UseCompatibleStateImageBehavior = false;
            this.DeptManagersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 56;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 142;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 145;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Department";
            this.columnHeader4.Width = 120;
            // 
            // DelDeptManagerBtn
            // 
            this.DelDeptManagerBtn.Location = new System.Drawing.Point(506, 63);
            this.DelDeptManagerBtn.Name = "DelDeptManagerBtn";
            this.DelDeptManagerBtn.Size = new System.Drawing.Size(142, 23);
            this.DelDeptManagerBtn.TabIndex = 7;
            this.DelDeptManagerBtn.Text = "Delete";
            this.DelDeptManagerBtn.UseVisualStyleBackColor = true;
            this.DelDeptManagerBtn.Click += new System.EventHandler(this.DelDeptManagerBtn_Click);
            // 
            // EditDeptManagerBtn
            // 
            this.EditDeptManagerBtn.Location = new System.Drawing.Point(506, 35);
            this.EditDeptManagerBtn.Name = "EditDeptManagerBtn";
            this.EditDeptManagerBtn.Size = new System.Drawing.Size(142, 23);
            this.EditDeptManagerBtn.TabIndex = 6;
            this.EditDeptManagerBtn.Text = "Edit";
            this.EditDeptManagerBtn.UseVisualStyleBackColor = true;
            this.EditDeptManagerBtn.Click += new System.EventHandler(this.EditDeptManagerBtn_Click);
            // 
            // AddDptMngBtn
            // 
            this.AddDptMngBtn.Location = new System.Drawing.Point(506, 6);
            this.AddDptMngBtn.Name = "AddDptMngBtn";
            this.AddDptMngBtn.Size = new System.Drawing.Size(143, 23);
            this.AddDptMngBtn.TabIndex = 5;
            this.AddDptMngBtn.Text = "Add";
            this.AddDptMngBtn.UseVisualStyleBackColor = true;
            this.AddDptMngBtn.Click += new System.EventHandler(this.AddDptMngBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loged In As:";
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(595, 9);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogOutBtn.TabIndex = 2;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "GRMS: Store Manager";
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLbl.Location = new System.Drawing.Point(453, 36);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(0, 20);
            this.UserNameLbl.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Store:";
            // 
            // StoreLbl
            // 
            this.StoreLbl.AutoSize = true;
            this.StoreLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreLbl.Location = new System.Drawing.Point(67, 42);
            this.StoreLbl.Name = "StoreLbl";
            this.StoreLbl.Size = new System.Drawing.Size(0, 20);
            this.StoreLbl.TabIndex = 7;
            // 
            // MainStoreManagerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 556);
            this.Controls.Add(this.StoreLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabDptManagers);
            this.Name = "MainStoreManagerApp";
            this.Text = "GRMS: Store Manager App";
            this.tabDptManagers.ResumeLayout(false);
            this.tabDepartments.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabDptManagers;
        private System.Windows.Forms.TabPage tabDepartments;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView DeptsListView;
        private System.Windows.Forms.ColumnHeader IDCol;
        private System.Windows.Forms.ColumnHeader NameCol;
        private System.Windows.Forms.ColumnHeader ManagerCol;
        private System.Windows.Forms.Button DelDepartBtn;
        private System.Windows.Forms.Button EditDeptBtn;
        private System.Windows.Forms.Button AddDeptBtn;
        private System.Windows.Forms.ListView DeptManagersListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button DelDeptManagerBtn;
        private System.Windows.Forms.Button EditDeptManagerBtn;
        private System.Windows.Forms.Button AddDptMngBtn;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StoreLbl;
    }
}