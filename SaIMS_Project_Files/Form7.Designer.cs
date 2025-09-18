namespace NeaApp
{
    partial class Form7
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
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.txtRetypeNewPassword = new System.Windows.Forms.TextBox();
            this.txtTypeNewPassword = new System.Windows.Forms.TextBox();
            this.lblRetypeNewPassword = new System.Windows.Forms.Label();
            this.lblTypeNewPassword = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.chkShowPasswordRetype = new System.Windows.Forms.CheckBox();
            this.btnCloseandOpenMainPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChangePassword.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChangePassword.Location = new System.Drawing.Point(0, 0);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(1125, 83);
            this.lblChangePassword.TabIndex = 4;
            this.lblChangePassword.Text = "Change Password";
            this.lblChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRetypeNewPassword
            // 
            this.txtRetypeNewPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRetypeNewPassword.Location = new System.Drawing.Point(513, 268);
            this.txtRetypeNewPassword.Name = "txtRetypeNewPassword";
            this.txtRetypeNewPassword.Size = new System.Drawing.Size(499, 38);
            this.txtRetypeNewPassword.TabIndex = 7;
            this.txtRetypeNewPassword.UseSystemPasswordChar = true;
            // 
            // txtTypeNewPassword
            // 
            this.txtTypeNewPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTypeNewPassword.Location = new System.Drawing.Point(513, 138);
            this.txtTypeNewPassword.Name = "txtTypeNewPassword";
            this.txtTypeNewPassword.Size = new System.Drawing.Size(499, 38);
            this.txtTypeNewPassword.TabIndex = 8;
            this.txtTypeNewPassword.UseSystemPasswordChar = true;
            // 
            // lblRetypeNewPassword
            // 
            this.lblRetypeNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRetypeNewPassword.Location = new System.Drawing.Point(140, 268);
            this.lblRetypeNewPassword.Name = "lblRetypeNewPassword";
            this.lblRetypeNewPassword.Size = new System.Drawing.Size(258, 38);
            this.lblRetypeNewPassword.TabIndex = 9;
            this.lblRetypeNewPassword.Text = "Retype new password";
            this.lblRetypeNewPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTypeNewPassword
            // 
            this.lblTypeNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTypeNewPassword.Location = new System.Drawing.Point(162, 143);
            this.lblTypeNewPassword.Name = "lblTypeNewPassword";
            this.lblTypeNewPassword.Size = new System.Drawing.Size(236, 42);
            this.lblTypeNewPassword.TabIndex = 10;
            this.lblTypeNewPassword.Text = "Type new password";
            this.lblTypeNewPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(513, 435);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(163, 43);
            this.btnChangePassword.TabIndex = 11;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(513, 199);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(132, 24);
            this.chkShowPassword.TabIndex = 12;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // chkShowPasswordRetype
            // 
            this.chkShowPasswordRetype.AutoSize = true;
            this.chkShowPasswordRetype.Location = new System.Drawing.Point(513, 346);
            this.chkShowPasswordRetype.Name = "chkShowPasswordRetype";
            this.chkShowPasswordRetype.Size = new System.Drawing.Size(132, 24);
            this.chkShowPasswordRetype.TabIndex = 13;
            this.chkShowPasswordRetype.Text = "Show Password";
            this.chkShowPasswordRetype.UseVisualStyleBackColor = true;
            this.chkShowPasswordRetype.CheckedChanged += new System.EventHandler(this.chkShowPasswordRetype_CheckedChanged);
            // 
            // btnCloseandOpenMainPage
            // 
            this.btnCloseandOpenMainPage.Location = new System.Drawing.Point(703, 436);
            this.btnCloseandOpenMainPage.Name = "btnCloseandOpenMainPage";
            this.btnCloseandOpenMainPage.Size = new System.Drawing.Size(256, 42);
            this.btnCloseandOpenMainPage.TabIndex = 18;
            this.btnCloseandOpenMainPage.Text = "Quit and move to Main Page";
            this.btnCloseandOpenMainPage.UseVisualStyleBackColor = true;
            this.btnCloseandOpenMainPage.Click += new System.EventHandler(this.btnCloseandOpenMainPage_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 615);
            this.Controls.Add(this.btnCloseandOpenMainPage);
            this.Controls.Add(this.chkShowPasswordRetype);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblTypeNewPassword);
            this.Controls.Add(this.lblRetypeNewPassword);
            this.Controls.Add(this.txtTypeNewPassword);
            this.Controls.Add(this.txtRetypeNewPassword);
            this.Controls.Add(this.lblChangePassword);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form7_FormClosed);
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblChangePassword;
        private TextBox txtRetypeNewPassword;
        private TextBox txtTypeNewPassword;
        private Label lblRetypeNewPassword;
        private Label lblTypeNewPassword;
        private Button btnChangePassword;
        private CheckBox chkShowPassword;
        private CheckBox chkShowPasswordRetype;
        private Button btnCloseandOpenMainPage;
    }
}