namespace NeaApp
{
    partial class Form11
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
            this.lblNewAdminUsername = new System.Windows.Forms.Label();
            this.lblNewAdminPassword = new System.Windows.Forms.Label();
            this.txtNewAdminUsername = new System.Windows.Forms.TextBox();
            this.lblCreateAdminLogin = new System.Windows.Forms.Label();
            this.txtNewAdminPassword = new System.Windows.Forms.TextBox();
            this.btnCreateNewAdminLogin = new System.Windows.Forms.Button();
            this.btnCloseandOpenMainPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewAdminUsername
            // 
            this.lblNewAdminUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewAdminUsername.Location = new System.Drawing.Point(61, 155);
            this.lblNewAdminUsername.Name = "lblNewAdminUsername";
            this.lblNewAdminUsername.Size = new System.Drawing.Size(253, 55);
            this.lblNewAdminUsername.TabIndex = 2;
            this.lblNewAdminUsername.Text = "New Admin Username";
            this.lblNewAdminUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewAdminPassword
            // 
            this.lblNewAdminPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewAdminPassword.Location = new System.Drawing.Point(61, 261);
            this.lblNewAdminPassword.Name = "lblNewAdminPassword";
            this.lblNewAdminPassword.Size = new System.Drawing.Size(253, 55);
            this.lblNewAdminPassword.TabIndex = 3;
            this.lblNewAdminPassword.Text = "New Admin Password";
            this.lblNewAdminPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewAdminUsername
            // 
            this.txtNewAdminUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewAdminUsername.Location = new System.Drawing.Point(351, 163);
            this.txtNewAdminUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewAdminUsername.Name = "txtNewAdminUsername";
            this.txtNewAdminUsername.Size = new System.Drawing.Size(677, 39);
            this.txtNewAdminUsername.TabIndex = 5;
            // 
            // lblCreateAdminLogin
            // 
            this.lblCreateAdminLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCreateAdminLogin.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreateAdminLogin.Location = new System.Drawing.Point(0, 0);
            this.lblCreateAdminLogin.Name = "lblCreateAdminLogin";
            this.lblCreateAdminLogin.Size = new System.Drawing.Size(1082, 83);
            this.lblCreateAdminLogin.TabIndex = 6;
            this.lblCreateAdminLogin.Text = "Create Admin Logins";
            this.lblCreateAdminLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewAdminPassword
            // 
            this.txtNewAdminPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewAdminPassword.Location = new System.Drawing.Point(351, 269);
            this.txtNewAdminPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewAdminPassword.Name = "txtNewAdminPassword";
            this.txtNewAdminPassword.Size = new System.Drawing.Size(677, 39);
            this.txtNewAdminPassword.TabIndex = 7;
            // 
            // btnCreateNewAdminLogin
            // 
            this.btnCreateNewAdminLogin.Location = new System.Drawing.Point(351, 358);
            this.btnCreateNewAdminLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateNewAdminLogin.Name = "btnCreateNewAdminLogin";
            this.btnCreateNewAdminLogin.Size = new System.Drawing.Size(333, 56);
            this.btnCreateNewAdminLogin.TabIndex = 8;
            this.btnCreateNewAdminLogin.Text = "Create new admin login";
            this.btnCreateNewAdminLogin.UseVisualStyleBackColor = true;
            this.btnCreateNewAdminLogin.Click += new System.EventHandler(this.btnCreateNewAdminLogin_Click);
            // 
            // btnCloseandOpenMainPage
            // 
            this.btnCloseandOpenMainPage.Location = new System.Drawing.Point(716, 358);
            this.btnCloseandOpenMainPage.Name = "btnCloseandOpenMainPage";
            this.btnCloseandOpenMainPage.Size = new System.Drawing.Size(312, 56);
            this.btnCloseandOpenMainPage.TabIndex = 19;
            this.btnCloseandOpenMainPage.Text = "Quit and move to Main Page";
            this.btnCloseandOpenMainPage.UseVisualStyleBackColor = true;
            this.btnCloseandOpenMainPage.Click += new System.EventHandler(this.btnCloseandOpenMainPage_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.btnCloseandOpenMainPage);
            this.Controls.Add(this.btnCreateNewAdminLogin);
            this.Controls.Add(this.txtNewAdminPassword);
            this.Controls.Add(this.lblCreateAdminLogin);
            this.Controls.Add(this.txtNewAdminUsername);
            this.Controls.Add(this.lblNewAdminPassword);
            this.Controls.Add(this.lblNewAdminUsername);
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form11_FormClosed);
            this.Load += new System.EventHandler(this.Form11_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNewAdminUsername;
        private Label lblNewAdminPassword;
        private TextBox txtNewAdminUsername;
        private Label lblCreateAdminLogin;
        private TextBox txtNewAdminPassword;
        private Button btnCreateNewAdminLogin;
        private Button btnCloseandOpenMainPage;
    }
}