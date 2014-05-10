namespace GGSR
{
    partial class MainLogin
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
            this.components = new System.ComponentModel.Container();
            this.HeadingLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.UserNameInputBox = new System.Windows.Forms.TextBox();
            this.PassInputBox = new System.Windows.Forms.TextBox();
            this.UserLoginLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.PassLbl = new System.Windows.Forms.Label();
            this.loginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.loadingLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadingLbl
            // 
            this.HeadingLbl.AutoSize = true;
            this.HeadingLbl.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLbl.Location = new System.Drawing.Point(95, 9);
            this.HeadingLbl.Name = "HeadingLbl";
            this.HeadingLbl.Size = new System.Drawing.Size(302, 29);
            this.HeadingLbl.TabIndex = 0;
            this.HeadingLbl.Text = "General Grocery Store Rosters";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(100, 167);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(86, 29);
            this.LoginBtn.TabIndex = 1;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            // 
            // UserNameInputBox
            // 
            this.UserNameInputBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameInputBox.Location = new System.Drawing.Point(100, 103);
            this.UserNameInputBox.Name = "UserNameInputBox";
            this.UserNameInputBox.Size = new System.Drawing.Size(297, 26);
            this.UserNameInputBox.TabIndex = 2;
            // 
            // PassInputBox
            // 
            this.PassInputBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassInputBox.Location = new System.Drawing.Point(100, 135);
            this.PassInputBox.Name = "PassInputBox";
            this.PassInputBox.Size = new System.Drawing.Size(297, 26);
            this.PassInputBox.TabIndex = 3;
            // 
            // UserLoginLbl
            // 
            this.UserLoginLbl.AutoSize = true;
            this.UserLoginLbl.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLoginLbl.Location = new System.Drawing.Point(12, 56);
            this.UserLoginLbl.Name = "UserLoginLbl";
            this.UserLoginLbl.Size = new System.Drawing.Size(103, 25);
            this.UserLoginLbl.TabIndex = 4;
            this.UserLoginLbl.Text = "User Login:";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.Location = new System.Drawing.Point(13, 106);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(46, 20);
            this.EmailLbl.TabIndex = 5;
            this.EmailLbl.Text = "Email:";
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLbl.Location = new System.Drawing.Point(13, 138);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(72, 20);
            this.PassLbl.TabIndex = 6;
            this.PassLbl.Text = "Password:";
            // 
            // loginErrorProvider
            // 
            this.loginErrorProvider.ContainerControl = this;
            // 
            // loadingLbl
            // 
            this.loadingLbl.AutoSize = true;
            this.loadingLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLbl.Location = new System.Drawing.Point(192, 171);
            this.loadingLbl.Name = "loadingLbl";
            this.loadingLbl.Size = new System.Drawing.Size(69, 20);
            this.loadingLbl.TabIndex = 7;
            this.loadingLbl.Text = "Loading...";
            this.loadingLbl.Visible = false;
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 262);
            this.Controls.Add(this.loadingLbl);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.UserLoginLbl);
            this.Controls.Add(this.PassInputBox);
            this.Controls.Add(this.UserNameInputBox);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.HeadingLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GGSR";
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadingLbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox UserNameInputBox;
        private System.Windows.Forms.TextBox PassInputBox;
        private System.Windows.Forms.Label UserLoginLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.ErrorProvider loginErrorProvider;
        private System.Windows.Forms.Label loadingLbl;
    }
}

