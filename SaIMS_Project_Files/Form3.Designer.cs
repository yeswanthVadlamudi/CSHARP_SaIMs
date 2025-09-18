namespace NeaApp
{
    partial class Form3
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
            this.lblCreateLogin = new System.Windows.Forms.Label();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnCreateNewLogin = new System.Windows.Forms.Button();
            this.lblPasswordRequirements = new System.Windows.Forms.Label();
            this.cmbSelectEmployee = new System.Windows.Forms.ComboBox();
            this.lblSelectedStaff_id = new System.Windows.Forms.Label();
            this.lblSelectEmployeeName = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.btnCloseandOpenMainPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreateLogin
            // 
            this.lblCreateLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCreateLogin.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreateLogin.Location = new System.Drawing.Point(0, 0);
            this.lblCreateLogin.Name = "lblCreateLogin";
            this.lblCreateLogin.Size = new System.Drawing.Size(1082, 83);
            this.lblCreateLogin.TabIndex = 0;
            this.lblCreateLogin.Text = "Create Logins";
            this.lblCreateLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCreateLogin.Click += new System.EventHandler(this.lblCreateLogin_Click);
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewUsername.Location = new System.Drawing.Point(67, 259);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(195, 55);
            this.lblNewUsername.TabIndex = 1;
            this.lblNewUsername.Text = "New Username";
            this.lblNewUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewPassword.Location = new System.Drawing.Point(67, 370);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(195, 55);
            this.lblNewPassword.TabIndex = 3;
            this.lblNewPassword.Text = "New Password";
            this.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewUsername.Location = new System.Drawing.Point(303, 267);
            this.txtNewUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(677, 39);
            this.txtNewUsername.TabIndex = 4;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewPassword.Location = new System.Drawing.Point(303, 378);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(677, 39);
            this.txtNewPassword.TabIndex = 5;
            // 
            // btnCreateNewLogin
            // 
            this.btnCreateNewLogin.Location = new System.Drawing.Point(309, 767);
            this.btnCreateNewLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateNewLogin.Name = "btnCreateNewLogin";
            this.btnCreateNewLogin.Size = new System.Drawing.Size(318, 56);
            this.btnCreateNewLogin.TabIndex = 7;
            this.btnCreateNewLogin.Text = "Create new login";
            this.btnCreateNewLogin.UseVisualStyleBackColor = true;
            this.btnCreateNewLogin.Click += new System.EventHandler(this.btnCreateNewLogin_Click);
            // 
            // lblPasswordRequirements
            // 
            this.lblPasswordRequirements.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordRequirements.Location = new System.Drawing.Point(303, 421);
            this.lblPasswordRequirements.Name = "lblPasswordRequirements";
            this.lblPasswordRequirements.Size = new System.Drawing.Size(644, 129);
            this.lblPasswordRequirements.TabIndex = 8;
            this.lblPasswordRequirements.Text = "Your new Password has a few requirements:\r\n1.Capital Letters\r\n2.Small Letters\r\n3." +
    "Numbers\r\n4.Symbols\r\n";
            // 
            // cmbSelectEmployee
            // 
            this.cmbSelectEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSelectEmployee.FormattingEnabled = true;
            this.cmbSelectEmployee.Location = new System.Drawing.Point(303, 151);
            this.cmbSelectEmployee.Name = "cmbSelectEmployee";
            this.cmbSelectEmployee.Size = new System.Drawing.Size(677, 36);
            this.cmbSelectEmployee.TabIndex = 9;
            // 
            // lblSelectedStaff_id
            // 
            this.lblSelectedStaff_id.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedStaff_id.Location = new System.Drawing.Point(303, 200);
            this.lblSelectedStaff_id.Name = "lblSelectedStaff_id";
            this.lblSelectedStaff_id.Size = new System.Drawing.Size(175, 35);
            this.lblSelectedStaff_id.TabIndex = 10;
            this.lblSelectedStaff_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectEmployeeName
            // 
            this.lblSelectEmployeeName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectEmployeeName.Location = new System.Drawing.Point(67, 140);
            this.lblSelectEmployeeName.Name = "lblSelectEmployeeName";
            this.lblSelectEmployeeName.Size = new System.Drawing.Size(195, 55);
            this.lblSelectEmployeeName.TabIndex = 11;
            this.lblSelectEmployeeName.Text = "Select Employee";
            this.lblSelectEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmailAddress.Location = new System.Drawing.Point(67, 630);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(195, 55);
            this.lblEmailAddress.TabIndex = 21;
            this.lblEmailAddress.Text = "Email Address";
            this.lblEmailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmailAddress.Location = new System.Drawing.Point(309, 638);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(671, 39);
            this.txtEmailAddress.TabIndex = 22;
            // 
            // btnCloseandOpenMainPage
            // 
            this.btnCloseandOpenMainPage.Location = new System.Drawing.Point(691, 767);
            this.btnCloseandOpenMainPage.Name = "btnCloseandOpenMainPage";
            this.btnCloseandOpenMainPage.Size = new System.Drawing.Size(289, 56);
            this.btnCloseandOpenMainPage.TabIndex = 23;
            this.btnCloseandOpenMainPage.Text = "Quit and move to Main Page";
            this.btnCloseandOpenMainPage.UseVisualStyleBackColor = true;
            this.btnCloseandOpenMainPage.Click += new System.EventHandler(this.btnCloseandOpenMainPage_Click);
            // 
            // Form3
            // 
            this.AcceptButton = this.btnCreateNewLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 853);
            this.Controls.Add(this.btnCloseandOpenMainPage);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblSelectEmployeeName);
            this.Controls.Add(this.lblSelectedStaff_id);
            this.Controls.Add(this.cmbSelectEmployee);
            this.Controls.Add(this.lblPasswordRequirements);
            this.Controls.Add(this.btnCreateNewLogin);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblNewUsername);
            this.Controls.Add(this.lblCreateLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCreateLogin;
        private Label lblNewUsername;
        private Label lblNewPassword;
        private TextBox txtNewUsername;
        private TextBox txtNewPassword;
        private Button btnCreateNewLogin;
        private Label lblPasswordRequirements;
        private ComboBox cmbSelectEmployee;
        private Label lblSelectedStaff_id;
        private Label lblSelectEmployeeName;
        private Label lblEmailAddress;
        private TextBox txtEmailAddress;
        private Button btnCloseandOpenMainPage;
    }
}