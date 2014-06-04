namespace GGSR.DeptManagerApp
{
    partial class MainDeptManagerApp
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
            this.tabTeamMembers = new System.Windows.Forms.TabControl();
            this.tabTeamMem = new System.Windows.Forms.TabPage();
            this.TeamListView = new System.Windows.Forms.ListView();
            this.IDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RosterCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DelTeamBtn = new System.Windows.Forms.Button();
            this.EditTeamBtn = new System.Windows.Forms.Button();
            this.AddTeamBtn = new System.Windows.Forms.Button();
            this.tabRosters = new System.Windows.Forms.TabPage();
            this.RostersListView = new System.Windows.Forms.ListView();
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
            this.label4 = new System.Windows.Forms.Label();
            this.DeptLbl = new System.Windows.Forms.Label();
            this.tabTeamMembers.SuspendLayout();
            this.tabTeamMem.SuspendLayout();
            this.tabRosters.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTeamMembers
            // 
            this.tabTeamMembers.Controls.Add(this.tabTeamMem);
            this.tabTeamMembers.Controls.Add(this.tabRosters);
            this.tabTeamMembers.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTeamMembers.Location = new System.Drawing.Point(8, 105);
            this.tabTeamMembers.Name = "tabTeamMembers";
            this.tabTeamMembers.SelectedIndex = 0;
            this.tabTeamMembers.Size = new System.Drawing.Size(814, 505);
            this.tabTeamMembers.TabIndex = 0;
            // 
            // tabTeamMem
            // 
            this.tabTeamMem.BackColor = System.Drawing.SystemColors.Control;
            this.tabTeamMem.Controls.Add(this.TeamListView);
            this.tabTeamMem.Controls.Add(this.DelTeamBtn);
            this.tabTeamMem.Controls.Add(this.EditTeamBtn);
            this.tabTeamMem.Controls.Add(this.AddTeamBtn);
            this.tabTeamMem.Location = new System.Drawing.Point(4, 25);
            this.tabTeamMem.Name = "tabTeamMem";
            this.tabTeamMem.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeamMem.Size = new System.Drawing.Size(806, 476);
            this.tabTeamMem.TabIndex = 0;
            this.tabTeamMem.Text = "Team Members";
            // 
            // TeamListView
            // 
            this.TeamListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDCol,
            this.fNameCol,
            this.lNameCol,
            this.RosterCol,
            this.columnHeader5,
            this.Hours});
            this.TeamListView.FullRowSelect = true;
            this.TeamListView.Location = new System.Drawing.Point(6, 6);
            this.TeamListView.MultiSelect = false;
            this.TeamListView.Name = "TeamListView";
            this.TeamListView.Size = new System.Drawing.Size(645, 464);
            this.TeamListView.TabIndex = 4;
            this.TeamListView.UseCompatibleStateImageBehavior = false;
            this.TeamListView.View = System.Windows.Forms.View.Details;
            // 
            // IDCol
            // 
            this.IDCol.Text = "ID";
            this.IDCol.Width = 56;
            // 
            // fNameCol
            // 
            this.fNameCol.Text = "First Name";
            this.fNameCol.Width = 89;
            // 
            // lNameCol
            // 
            this.lNameCol.Text = "Last Name";
            this.lNameCol.Width = 100;
            // 
            // RosterCol
            // 
            this.RosterCol.Text = "Roster ID";
            this.RosterCol.Width = 83;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Roster Name";
            this.columnHeader5.Width = 78;
            // 
            // Hours
            // 
            this.Hours.Text = "Hours";
            this.Hours.Width = 80;
            // 
            // DelTeamBtn
            // 
            this.DelTeamBtn.Location = new System.Drawing.Point(657, 63);
            this.DelTeamBtn.Name = "DelTeamBtn";
            this.DelTeamBtn.Size = new System.Drawing.Size(142, 23);
            this.DelTeamBtn.TabIndex = 3;
            this.DelTeamBtn.Text = "Delete";
            this.DelTeamBtn.UseVisualStyleBackColor = true;
            this.DelTeamBtn.Click += new System.EventHandler(this.DelTeamBtn_Click);
            // 
            // EditTeamBtn
            // 
            this.EditTeamBtn.Location = new System.Drawing.Point(657, 35);
            this.EditTeamBtn.Name = "EditTeamBtn";
            this.EditTeamBtn.Size = new System.Drawing.Size(142, 23);
            this.EditTeamBtn.TabIndex = 2;
            this.EditTeamBtn.Text = "Edit";
            this.EditTeamBtn.UseVisualStyleBackColor = true;
            this.EditTeamBtn.Click += new System.EventHandler(this.EditDeptBtn_Click);
            // 
            // AddTeamBtn
            // 
            this.AddTeamBtn.Location = new System.Drawing.Point(657, 6);
            this.AddTeamBtn.Name = "AddTeamBtn";
            this.AddTeamBtn.Size = new System.Drawing.Size(143, 23);
            this.AddTeamBtn.TabIndex = 1;
            this.AddTeamBtn.Text = "Add";
            this.AddTeamBtn.UseVisualStyleBackColor = true;
            this.AddTeamBtn.Click += new System.EventHandler(this.AddDeptBtn_Click);
            // 
            // tabRosters
            // 
            this.tabRosters.BackColor = System.Drawing.SystemColors.Control;
            this.tabRosters.Controls.Add(this.RostersListView);
            this.tabRosters.Controls.Add(this.DelDeptManagerBtn);
            this.tabRosters.Controls.Add(this.EditDeptManagerBtn);
            this.tabRosters.Controls.Add(this.AddDptMngBtn);
            this.tabRosters.Location = new System.Drawing.Point(4, 25);
            this.tabRosters.Name = "tabRosters";
            this.tabRosters.Padding = new System.Windows.Forms.Padding(3);
            this.tabRosters.Size = new System.Drawing.Size(806, 476);
            this.tabRosters.TabIndex = 1;
            this.tabRosters.Text = "Rosters";
            // 
            // RostersListView
            // 
            this.RostersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.RostersListView.FullRowSelect = true;
            this.RostersListView.Location = new System.Drawing.Point(5, 6);
            this.RostersListView.MultiSelect = false;
            this.RostersListView.Name = "RostersListView";
            this.RostersListView.Size = new System.Drawing.Size(646, 464);
            this.RostersListView.TabIndex = 8;
            this.RostersListView.UseCompatibleStateImageBehavior = false;
            this.RostersListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 56;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 142;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 145;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hours";
            this.columnHeader4.Width = 120;
            // 
            // DelDeptManagerBtn
            // 
            this.DelDeptManagerBtn.Location = new System.Drawing.Point(657, 63);
            this.DelDeptManagerBtn.Name = "DelDeptManagerBtn";
            this.DelDeptManagerBtn.Size = new System.Drawing.Size(142, 23);
            this.DelDeptManagerBtn.TabIndex = 7;
            this.DelDeptManagerBtn.Text = "Delete";
            this.DelDeptManagerBtn.UseVisualStyleBackColor = true;
            this.DelDeptManagerBtn.Click += new System.EventHandler(this.DelDeptManagerBtn_Click);
            // 
            // EditDeptManagerBtn
            // 
            this.EditDeptManagerBtn.Location = new System.Drawing.Point(657, 35);
            this.EditDeptManagerBtn.Name = "EditDeptManagerBtn";
            this.EditDeptManagerBtn.Size = new System.Drawing.Size(142, 23);
            this.EditDeptManagerBtn.TabIndex = 6;
            this.EditDeptManagerBtn.Text = "Edit";
            this.EditDeptManagerBtn.UseVisualStyleBackColor = true;
            this.EditDeptManagerBtn.Click += new System.EventHandler(this.EditDeptManagerBtn_Click);
            // 
            // AddDptMngBtn
            // 
            this.AddDptMngBtn.Location = new System.Drawing.Point(657, 6);
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
            this.label1.Location = new System.Drawing.Point(600, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loged In As:";
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(747, 6);
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
            this.label2.Size = new System.Drawing.Size(211, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "GRMS: Department Manager";
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLbl.Location = new System.Drawing.Point(603, 31);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Department:";
            // 
            // DeptLbl
            // 
            this.DeptLbl.AutoSize = true;
            this.DeptLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptLbl.Location = new System.Drawing.Point(103, 71);
            this.DeptLbl.Name = "DeptLbl";
            this.DeptLbl.Size = new System.Drawing.Size(0, 20);
            this.DeptLbl.TabIndex = 9;
            // 
            // MainDeptManagerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 622);
            this.Controls.Add(this.DeptLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StoreLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabTeamMembers);
            this.Name = "MainDeptManagerApp";
            this.Text = "GRMS: Store Manager App";
            this.tabTeamMembers.ResumeLayout(false);
            this.tabTeamMem.ResumeLayout(false);
            this.tabRosters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabTeamMembers;
        private System.Windows.Forms.TabPage tabTeamMem;
        private System.Windows.Forms.TabPage tabRosters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView TeamListView;
        private System.Windows.Forms.ColumnHeader IDCol;
        private System.Windows.Forms.ColumnHeader fNameCol;
        private System.Windows.Forms.ColumnHeader RosterCol;
        private System.Windows.Forms.Button DelTeamBtn;
        private System.Windows.Forms.Button EditTeamBtn;
        private System.Windows.Forms.Button AddTeamBtn;
        private System.Windows.Forms.ListView RostersListView;
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
        private System.Windows.Forms.ColumnHeader lNameCol;
        private System.Windows.Forms.ColumnHeader Hours;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DeptLbl;
    }
}