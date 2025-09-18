namespace NeaApp
{
    partial class Form13
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
            this.lblAdminSignedInPage = new System.Windows.Forms.Label();
            this.cmbPaymentchoice = new System.Windows.Forms.ComboBox();
            this.lblOptionSelection = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseandOpenMainPage = new System.Windows.Forms.Button();
            this.btnExecuteTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdminSignedInPage
            // 
            this.lblAdminSignedInPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAdminSignedInPage.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdminSignedInPage.Location = new System.Drawing.Point(0, 0);
            this.lblAdminSignedInPage.Name = "lblAdminSignedInPage";
            this.lblAdminSignedInPage.Size = new System.Drawing.Size(1282, 80);
            this.lblAdminSignedInPage.TabIndex = 1;
            this.lblAdminSignedInPage.Text = "Payments";
            this.lblAdminSignedInPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdminSignedInPage.Click += new System.EventHandler(this.lblAdminSignedInPage_Click);
            // 
            // cmbPaymentchoice
            // 
            this.cmbPaymentchoice.AutoCompleteCustomSource.AddRange(new string[] {
            "Rent",
            "Electricity",
            "Goods transport"});
            this.cmbPaymentchoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPaymentchoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbPaymentchoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPaymentchoice.FormattingEnabled = true;
            this.cmbPaymentchoice.Items.AddRange(new object[] {
            "Rent",
            "Electricity",
            "Goods transport"});
            this.cmbPaymentchoice.Location = new System.Drawing.Point(305, 165);
            this.cmbPaymentchoice.Name = "cmbPaymentchoice";
            this.cmbPaymentchoice.Size = new System.Drawing.Size(906, 36);
            this.cmbPaymentchoice.TabIndex = 26;
            this.cmbPaymentchoice.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentchoice_SelectedIndexChanged);
            // 
            // lblOptionSelection
            // 
            this.lblOptionSelection.Location = new System.Drawing.Point(77, 164);
            this.lblOptionSelection.Name = "lblOptionSelection";
            this.lblOptionSelection.Size = new System.Drawing.Size(150, 42);
            this.lblOptionSelection.TabIndex = 27;
            this.lblOptionSelection.Text = "Select option:";
            this.lblOptionSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmount.Location = new System.Drawing.Point(305, 243);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(159, 38);
            this.txtAmount.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(104, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 42);
            this.label1.TabIndex = 29;
            this.label1.Text = "Amount:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseandOpenMainPage
            // 
            this.btnCloseandOpenMainPage.Location = new System.Drawing.Point(525, 336);
            this.btnCloseandOpenMainPage.Name = "btnCloseandOpenMainPage";
            this.btnCloseandOpenMainPage.Size = new System.Drawing.Size(256, 42);
            this.btnCloseandOpenMainPage.TabIndex = 35;
            this.btnCloseandOpenMainPage.Text = "Quit and move to Main Page";
            this.btnCloseandOpenMainPage.UseVisualStyleBackColor = true;
            this.btnCloseandOpenMainPage.Click += new System.EventHandler(this.btnCloseandOpenMainPage_Click);
            // 
            // btnExecuteTransaction
            // 
            this.btnExecuteTransaction.Location = new System.Drawing.Point(305, 329);
            this.btnExecuteTransaction.Name = "btnExecuteTransaction";
            this.btnExecuteTransaction.Size = new System.Drawing.Size(180, 49);
            this.btnExecuteTransaction.TabIndex = 34;
            this.btnExecuteTransaction.Text = "Finish transaction";
            this.btnExecuteTransaction.UseVisualStyleBackColor = true;
            this.btnExecuteTransaction.Click += new System.EventHandler(this.btnExecuteTransaction_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 553);
            this.Controls.Add(this.btnCloseandOpenMainPage);
            this.Controls.Add(this.btnExecuteTransaction);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOptionSelection);
            this.Controls.Add(this.cmbPaymentchoice);
            this.Controls.Add(this.lblAdminSignedInPage);
            this.Name = "Form13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cmbPaymentchoice_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lblAdminSignedInPage_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblAdminSignedInPage;
        private ComboBox cmbPaymentchoice;
        private Label lblOptionSelection;
        private TextBox txtAmount;
        private Label label1;
        private Button btnCloseandOpenMainPage;
        private Button btnExecuteTransaction;
    }
}