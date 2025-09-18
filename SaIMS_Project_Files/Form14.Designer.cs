namespace NeaApp
{
    partial class Form14
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
            this.btnCloseandOpenMainPage = new System.Windows.Forms.Button();
            this.btnExecuteTransaction = new System.Windows.Forms.Button();
            this.txtSalaryamount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOptionSelection = new System.Windows.Forms.Label();
            this.cmbEmployeename = new System.Windows.Forms.ComboBox();
            this.lblPayEmployeeSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCloseandOpenMainPage
            // 
            this.btnCloseandOpenMainPage.Location = new System.Drawing.Point(533, 340);
            this.btnCloseandOpenMainPage.Name = "btnCloseandOpenMainPage";
            this.btnCloseandOpenMainPage.Size = new System.Drawing.Size(256, 42);
            this.btnCloseandOpenMainPage.TabIndex = 42;
            this.btnCloseandOpenMainPage.Text = "Quit and move to Main Page";
            this.btnCloseandOpenMainPage.UseVisualStyleBackColor = true;
            this.btnCloseandOpenMainPage.Click += new System.EventHandler(this.btnCloseandOpenMainPage_Click);
            // 
            // btnExecuteTransaction
            // 
            this.btnExecuteTransaction.Location = new System.Drawing.Point(313, 333);
            this.btnExecuteTransaction.Name = "btnExecuteTransaction";
            this.btnExecuteTransaction.Size = new System.Drawing.Size(180, 49);
            this.btnExecuteTransaction.TabIndex = 41;
            this.btnExecuteTransaction.Text = "Pay salary";
            this.btnExecuteTransaction.UseVisualStyleBackColor = true;
            this.btnExecuteTransaction.Click += new System.EventHandler(this.btnExecuteTransaction_Click);
            // 
            // txtSalaryamount
            // 
            this.txtSalaryamount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalaryamount.Location = new System.Drawing.Point(313, 247);
            this.txtSalaryamount.Name = "txtSalaryamount";
            this.txtSalaryamount.Size = new System.Drawing.Size(159, 38);
            this.txtSalaryamount.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(112, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 42);
            this.label1.TabIndex = 39;
            this.label1.Text = "Amount:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOptionSelection
            // 
            this.lblOptionSelection.Location = new System.Drawing.Point(112, 179);
            this.lblOptionSelection.Name = "lblOptionSelection";
            this.lblOptionSelection.Size = new System.Drawing.Size(150, 42);
            this.lblOptionSelection.TabIndex = 38;
            this.lblOptionSelection.Text = "Select option:";
            this.lblOptionSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbEmployeename
            // 
            this.cmbEmployeename.AutoCompleteCustomSource.AddRange(new string[] {
            "Rent",
            "Electricity",
            "Goods transport"});
            this.cmbEmployeename.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmployeename.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbEmployeename.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbEmployeename.FormattingEnabled = true;
            this.cmbEmployeename.Items.AddRange(new object[] {
            "Rent",
            "Electricity",
            "Goods transport"});
            this.cmbEmployeename.Location = new System.Drawing.Point(313, 169);
            this.cmbEmployeename.Name = "cmbEmployeename";
            this.cmbEmployeename.Size = new System.Drawing.Size(906, 36);
            this.cmbEmployeename.TabIndex = 37;
            // 
            // lblPayEmployeeSalary
            // 
            this.lblPayEmployeeSalary.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPayEmployeeSalary.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPayEmployeeSalary.Location = new System.Drawing.Point(0, 0);
            this.lblPayEmployeeSalary.Name = "lblPayEmployeeSalary";
            this.lblPayEmployeeSalary.Size = new System.Drawing.Size(1282, 80);
            this.lblPayEmployeeSalary.TabIndex = 36;
            this.lblPayEmployeeSalary.Text = "Pay salary";
            this.lblPayEmployeeSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 453);
            this.Controls.Add(this.btnCloseandOpenMainPage);
            this.Controls.Add(this.btnExecuteTransaction);
            this.Controls.Add(this.txtSalaryamount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOptionSelection);
            this.Controls.Add(this.cmbEmployeename);
            this.Controls.Add(this.lblPayEmployeeSalary);
            this.Name = "Form14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form14";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form14_FormClosed);
            this.Load += new System.EventHandler(this.Form14_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCloseandOpenMainPage;
        private Button btnExecuteTransaction;
        private TextBox txtSalaryamount;
        private Label label1;
        private Label lblOptionSelection;
        private ComboBox cmbEmployeename;
        private Label lblPayEmployeeSalary;
    }
}