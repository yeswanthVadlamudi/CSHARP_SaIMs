namespace NeaApp
{
    partial class Form6
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
            this.lblForgetPassword = new System.Windows.Forms.Label();
            this.lblForgotPasswordMessage = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmailbox = new System.Windows.Forms.TextBox();
            this.lblverificationcode = new System.Windows.Forms.Label();
            this.txtVerificationCode = new System.Windows.Forms.TextBox();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.btnCloseandOpenMainPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblForgetPassword
            // 
            this.lblForgetPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblForgetPassword.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForgetPassword.Location = new System.Drawing.Point(0, 0);
            this.lblForgetPassword.Name = "lblForgetPassword";
            this.lblForgetPassword.Size = new System.Drawing.Size(1125, 83);
            this.lblForgetPassword.TabIndex = 3;
            this.lblForgetPassword.Text = "Forgot Password";
            this.lblForgetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblForgotPasswordMessage
            // 
            this.lblForgotPasswordMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForgotPasswordMessage.Location = new System.Drawing.Point(64, 83);
            this.lblForgotPasswordMessage.Name = "lblForgotPasswordMessage";
            this.lblForgotPasswordMessage.Size = new System.Drawing.Size(600, 147);
            this.lblForgotPasswordMessage.TabIndex = 4;
            this.lblForgotPasswordMessage.Text = "Since you are trying to access sensitive info \r\nby changing the password, we need" +
    " email verification to change\r\nthe password\r\n\r\nClick the \"send code button\" to s" +
    "end a code to your email";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(78, 287);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(110, 36);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email address";
            // 
            // txtEmailbox
            // 
            this.txtEmailbox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmailbox.Location = new System.Drawing.Point(206, 285);
            this.txtEmailbox.Name = "txtEmailbox";
            this.txtEmailbox.Size = new System.Drawing.Size(499, 38);
            this.txtEmailbox.TabIndex = 6;
            // 
            // lblverificationcode
            // 
            this.lblverificationcode.Location = new System.Drawing.Point(64, 378);
            this.lblverificationcode.Name = "lblverificationcode";
            this.lblverificationcode.Size = new System.Drawing.Size(124, 36);
            this.lblverificationcode.TabIndex = 7;
            this.lblverificationcode.Text = "Verification Code";
            // 
            // txtVerificationCode
            // 
            this.txtVerificationCode.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVerificationCode.Location = new System.Drawing.Point(206, 366);
            this.txtVerificationCode.Name = "txtVerificationCode";
            this.txtVerificationCode.PasswordChar = '*';
            this.txtVerificationCode.Size = new System.Drawing.Size(499, 38);
            this.txtVerificationCode.TabIndex = 8;
            this.txtVerificationCode.UseSystemPasswordChar = true;
            this.txtVerificationCode.WordWrap = false;
            // 
            // btnSendCode
            // 
            this.btnSendCode.Location = new System.Drawing.Point(711, 287);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(94, 29);
            this.btnSendCode.TabIndex = 9;
            this.btnSendCode.Text = "Send Code";
            this.btnSendCode.UseVisualStyleBackColor = true;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(711, 374);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(94, 29);
            this.btnok.TabIndex = 10;
            this.btnok.Text = "Verify";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnCloseandOpenMainPage
            // 
            this.btnCloseandOpenMainPage.Location = new System.Drawing.Point(206, 427);
            this.btnCloseandOpenMainPage.Name = "btnCloseandOpenMainPage";
            this.btnCloseandOpenMainPage.Size = new System.Drawing.Size(256, 42);
            this.btnCloseandOpenMainPage.TabIndex = 19;
            this.btnCloseandOpenMainPage.Text = "Quit and move to Main Page";
            this.btnCloseandOpenMainPage.UseVisualStyleBackColor = true;
            this.btnCloseandOpenMainPage.Click += new System.EventHandler(this.btnCloseandOpenMainPage_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 615);
            this.Controls.Add(this.btnCloseandOpenMainPage);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.txtVerificationCode);
            this.Controls.Add(this.lblverificationcode);
            this.Controls.Add(this.txtEmailbox);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblForgotPasswordMessage);
            this.Controls.Add(this.lblForgetPassword);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form6_FormClosed);
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblForgetPassword;
        private Label lblForgotPasswordMessage;
        private Label lblEmail;
        private TextBox txtEmailbox;
        private Label lblverificationcode;
        private TextBox txtVerificationCode;
        private Button btnSendCode;
        private Button btnok;
        private Button btnCloseandOpenMainPage;
    }
}