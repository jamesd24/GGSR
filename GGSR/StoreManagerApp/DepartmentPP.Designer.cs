namespace GGSR.StoreManagerApp
{
    partial class DepartmentPP
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLbl = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.PassLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.DeptNameInputBox = new System.Windows.Forms.TextBox();
            this.ManagerComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(13, 13);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(144, 25);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "New Department";
            // 
            // OkBtn
            // 
            this.OkBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBtn.Location = new System.Drawing.Point(392, 137);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 29);
            this.OkBtn.TabIndex = 5;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyBtn.Location = new System.Drawing.Point(311, 137);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(75, 29);
            this.ApplyBtn.TabIndex = 6;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(230, 137);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 29);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLbl.Location = new System.Drawing.Point(16, 91);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(137, 20);
            this.PassLbl.TabIndex = 11;
            this.PassLbl.Text = "Department Manager:";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.Location = new System.Drawing.Point(16, 54);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(120, 20);
            this.EmailLbl.TabIndex = 10;
            this.EmailLbl.Text = "Department Name:";
            // 
            // DeptNameInputBox
            // 
            this.DeptNameInputBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptNameInputBox.Location = new System.Drawing.Point(159, 51);
            this.DeptNameInputBox.Name = "DeptNameInputBox";
            this.DeptNameInputBox.Size = new System.Drawing.Size(297, 26);
            this.DeptNameInputBox.TabIndex = 8;
            // 
            // ManagerComboBox
            // 
            this.ManagerComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerComboBox.FormattingEnabled = true;
            this.ManagerComboBox.Location = new System.Drawing.Point(159, 88);
            this.ManagerComboBox.Name = "ManagerComboBox";
            this.ManagerComboBox.Size = new System.Drawing.Size(297, 28);
            this.ManagerComboBox.TabIndex = 12;
            // 
            // DepartmentPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 175);
            this.Controls.Add(this.ManagerComboBox);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.DeptNameInputBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.TitleLbl);
            this.Name = "DepartmentPP";
            this.Text = "DepartmentPP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DepartmentPP_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox DeptNameInputBox;
        private System.Windows.Forms.ComboBox ManagerComboBox;
    }
}