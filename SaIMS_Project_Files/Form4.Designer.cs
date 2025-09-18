namespace NeaApp
{
    partial class Form4
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
            this.lblNewEmployeeDetails = new System.Windows.Forms.Label();
            this.lblNewEmployeename = new System.Windows.Forms.Label();
            this.txtNewEmployeeName = new System.Windows.Forms.TextBox();
            this.lblNewEmployeeAge = new System.Windows.Forms.Label();
            this.lblNewEmployeePhoneNumber = new System.Windows.Forms.Label();
            this.lblNewEmployeeGender = new System.Windows.Forms.Label();
            this.txtNewEmployeePhoneNumber = new System.Windows.Forms.TextBox();
            this.txtNewEmployeeGender = new System.Windows.Forms.TextBox();
            this.txtNewEmployeeDoB = new System.Windows.Forms.TextBox();
            this.btnAddEmployeeDetails = new System.Windows.Forms.Button();
            this.lblDateMessage = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.btnCloseandOpenMainPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewEmployeeDetails
            // 
            this.lblNewEmployeeDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNewEmployeeDetails.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewEmployeeDetails.Location = new System.Drawing.Point(0, 0);
            this.lblNewEmployeeDetails.Name = "lblNewEmployeeDetails";
            this.lblNewEmployeeDetails.Size = new System.Drawing.Size(1125, 83);
            this.lblNewEmployeeDetails.TabIndex = 1;
            this.lblNewEmployeeDetails.Text = "New employee details";
            this.lblNewEmployeeDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNewEmployeeDetails.Click += new System.EventHandler(this.lblNewEmployeeDetails_Click);
            // 
            // lblNewEmployeename
            // 
            this.lblNewEmployeename.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewEmployeename.Location = new System.Drawing.Point(125, 123);
            this.lblNewEmployeename.Name = "lblNewEmployeename";
            this.lblNewEmployeename.Size = new System.Drawing.Size(195, 55);
            this.lblNewEmployeename.TabIndex = 2;
            this.lblNewEmployeename.Text = "Name";
            this.lblNewEmployeename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewEmployeeName
            // 
            this.txtNewEmployeeName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewEmployeeName.Location = new System.Drawing.Point(396, 139);
            this.txtNewEmployeeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewEmployeeName.Name = "txtNewEmployeeName";
            this.txtNewEmployeeName.Size = new System.Drawing.Size(638, 39);
            this.txtNewEmployeeName.TabIndex = 5;
            this.txtNewEmployeeName.TextChanged += new System.EventHandler(this.txtNewEmployeeName_TextChanged);
            // 
            // lblNewEmployeeAge
            // 
            this.lblNewEmployeeAge.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewEmployeeAge.Location = new System.Drawing.Point(125, 196);
            this.lblNewEmployeeAge.Name = "lblNewEmployeeAge";
            this.lblNewEmployeeAge.Size = new System.Drawing.Size(195, 55);
            this.lblNewEmployeeAge.TabIndex = 6;
            this.lblNewEmployeeAge.Text = "Date of birth";
            this.lblNewEmployeeAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewEmployeePhoneNumber
            // 
            this.lblNewEmployeePhoneNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewEmployeePhoneNumber.Location = new System.Drawing.Point(125, 320);
            this.lblNewEmployeePhoneNumber.Name = "lblNewEmployeePhoneNumber";
            this.lblNewEmployeePhoneNumber.Size = new System.Drawing.Size(195, 55);
            this.lblNewEmployeePhoneNumber.TabIndex = 8;
            this.lblNewEmployeePhoneNumber.Text = "Phone Number";
            this.lblNewEmployeePhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewEmployeeGender
            // 
            this.lblNewEmployeeGender.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewEmployeeGender.Location = new System.Drawing.Point(125, 524);
            this.lblNewEmployeeGender.Name = "lblNewEmployeeGender";
            this.lblNewEmployeeGender.Size = new System.Drawing.Size(195, 55);
            this.lblNewEmployeeGender.TabIndex = 11;
            this.lblNewEmployeeGender.Text = "Gender";
            this.lblNewEmployeeGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewEmployeePhoneNumber
            // 
            this.txtNewEmployeePhoneNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewEmployeePhoneNumber.Location = new System.Drawing.Point(396, 336);
            this.txtNewEmployeePhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewEmployeePhoneNumber.Name = "txtNewEmployeePhoneNumber";
            this.txtNewEmployeePhoneNumber.Size = new System.Drawing.Size(638, 39);
            this.txtNewEmployeePhoneNumber.TabIndex = 13;
            // 
            // txtNewEmployeeGender
            // 
            this.txtNewEmployeeGender.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewEmployeeGender.Location = new System.Drawing.Point(396, 532);
            this.txtNewEmployeeGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewEmployeeGender.Name = "txtNewEmployeeGender";
            this.txtNewEmployeeGender.Size = new System.Drawing.Size(638, 39);
            this.txtNewEmployeeGender.TabIndex = 16;
            // 
            // txtNewEmployeeDoB
            // 
            this.txtNewEmployeeDoB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewEmployeeDoB.Location = new System.Drawing.Point(396, 212);
            this.txtNewEmployeeDoB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewEmployeeDoB.Name = "txtNewEmployeeDoB";
            this.txtNewEmployeeDoB.Size = new System.Drawing.Size(638, 39);
            this.txtNewEmployeeDoB.TabIndex = 17;
            this.txtNewEmployeeDoB.TextChanged += new System.EventHandler(this.txtNewEmployeeAge_TextChanged);
            // 
            // btnAddEmployeeDetails
            // 
            this.btnAddEmployeeDetails.Location = new System.Drawing.Point(396, 625);
            this.btnAddEmployeeDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddEmployeeDetails.Name = "btnAddEmployeeDetails";
            this.btnAddEmployeeDetails.Size = new System.Drawing.Size(294, 42);
            this.btnAddEmployeeDetails.TabIndex = 18;
            this.btnAddEmployeeDetails.Text = "Add Employee Details";
            this.btnAddEmployeeDetails.UseVisualStyleBackColor = true;
            this.btnAddEmployeeDetails.Click += new System.EventHandler(this.btnAddEmployeeDetails_Click);
            // 
            // lblDateMessage
            // 
            this.lblDateMessage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateMessage.Location = new System.Drawing.Point(396, 269);
            this.lblDateMessage.Name = "lblDateMessage";
            this.lblDateMessage.Size = new System.Drawing.Size(244, 45);
            this.lblDateMessage.TabIndex = 19;
            this.lblDateMessage.Text = "Date format: YYYY-MM-DD";
            this.lblDateMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmailAddress.Location = new System.Drawing.Point(125, 427);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(195, 55);
            this.lblEmailAddress.TabIndex = 20;
            this.lblEmailAddress.Text = "Email Address";
            this.lblEmailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmailAddress.Location = new System.Drawing.Point(396, 435);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(638, 39);
            this.txtEmailAddress.TabIndex = 21;
            // 
            // btnCloseandOpenMainPage
            // 
            this.btnCloseandOpenMainPage.Location = new System.Drawing.Point(745, 625);
            this.btnCloseandOpenMainPage.Name = "btnCloseandOpenMainPage";
            this.btnCloseandOpenMainPage.Size = new System.Drawing.Size(289, 42);
            this.btnCloseandOpenMainPage.TabIndex = 22;
            this.btnCloseandOpenMainPage.Text = "Quit and move to Main Page";
            this.btnCloseandOpenMainPage.UseVisualStyleBackColor = true;
            this.btnCloseandOpenMainPage.Click += new System.EventHandler(this.btnCloseandOpenMainPage_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 753);
            this.Controls.Add(this.btnCloseandOpenMainPage);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblDateMessage);
            this.Controls.Add(this.btnAddEmployeeDetails);
            this.Controls.Add(this.txtNewEmployeeDoB);
            this.Controls.Add(this.txtNewEmployeeGender);
            this.Controls.Add(this.txtNewEmployeePhoneNumber);
            this.Controls.Add(this.lblNewEmployeeGender);
            this.Controls.Add(this.lblNewEmployeePhoneNumber);
            this.Controls.Add(this.lblNewEmployeeAge);
            this.Controls.Add(this.txtNewEmployeeName);
            this.Controls.Add(this.lblNewEmployeename);
            this.Controls.Add(this.lblNewEmployeeDetails);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNewEmployeeDetails;
        private Label lblNewEmployeename;
        private TextBox txtNewEmployeeName;
        private Label lblNewEmployeeAge;
        private Label lblNewEmployeePhoneNumber;
        private Label lblNewEmployeeGender;
        private TextBox txtNewEmployeePhoneNumber;
        private TextBox txtNewEmployeeGender;
        private TextBox txtNewEmployeeDoB;
        private Button btnAddEmployeeDetails;
        private Label lblDateMessage;
        private Label lblEmailAddress;
        private TextBox txtEmailAddress;
        private Button btnCloseandOpenMainPage;
    }
}