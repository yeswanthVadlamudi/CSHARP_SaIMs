namespace NeaApp
{
    partial class Form12
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
            this.lblDepositWithdrawalsandCheckBalance = new System.Windows.Forms.Label();
            this.cmbtransactionChoices = new System.Windows.Forms.ComboBox();
            this.lblOptionSelection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnExecuteTransaction = new System.Windows.Forms.Button();
            this.btnShowBalance = new System.Windows.Forms.Button();
            this.lblShowbalance = new System.Windows.Forms.Label();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.btnCloseandOpenMainPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDepositWithdrawalsandCheckBalance
            // 
            this.lblDepositWithdrawalsandCheckBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDepositWithdrawalsandCheckBalance.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepositWithdrawalsandCheckBalance.Location = new System.Drawing.Point(0, 0);
            this.lblDepositWithdrawalsandCheckBalance.Name = "lblDepositWithdrawalsandCheckBalance";
            this.lblDepositWithdrawalsandCheckBalance.Size = new System.Drawing.Size(1082, 83);
            this.lblDepositWithdrawalsandCheckBalance.TabIndex = 24;
            this.lblDepositWithdrawalsandCheckBalance.Text = "Deposits, withdrawals and check balance";
            this.lblDepositWithdrawalsandCheckBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbtransactionChoices
            // 
            this.cmbtransactionChoices.AutoCompleteCustomSource.AddRange(new string[] {
            "Deposit",
            "Withdrawals"});
            this.cmbtransactionChoices.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbtransactionChoices.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbtransactionChoices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbtransactionChoices.FormattingEnabled = true;
            this.cmbtransactionChoices.Location = new System.Drawing.Point(331, 162);
            this.cmbtransactionChoices.Name = "cmbtransactionChoices";
            this.cmbtransactionChoices.Size = new System.Drawing.Size(581, 36);
            this.cmbtransactionChoices.TabIndex = 25;
            // 
            // lblOptionSelection
            // 
            this.lblOptionSelection.Location = new System.Drawing.Point(130, 162);
            this.lblOptionSelection.Name = "lblOptionSelection";
            this.lblOptionSelection.Size = new System.Drawing.Size(150, 42);
            this.lblOptionSelection.TabIndex = 26;
            this.lblOptionSelection.Text = "Select option:";
            this.lblOptionSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(130, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = "Amount:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmount.Location = new System.Drawing.Point(331, 247);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(159, 38);
            this.txtAmount.TabIndex = 28;
            // 
            // btnExecuteTransaction
            // 
            this.btnExecuteTransaction.Location = new System.Drawing.Point(331, 336);
            this.btnExecuteTransaction.Name = "btnExecuteTransaction";
            this.btnExecuteTransaction.Size = new System.Drawing.Size(180, 49);
            this.btnExecuteTransaction.TabIndex = 29;
            this.btnExecuteTransaction.Text = "Finish transaction";
            this.btnExecuteTransaction.UseVisualStyleBackColor = true;
            this.btnExecuteTransaction.Click += new System.EventHandler(this.btnExecuteTransaction_Click);
            // 
            // btnShowBalance
            // 
            this.btnShowBalance.Location = new System.Drawing.Point(541, 336);
            this.btnShowBalance.Name = "btnShowBalance";
            this.btnShowBalance.Size = new System.Drawing.Size(180, 49);
            this.btnShowBalance.TabIndex = 30;
            this.btnShowBalance.Text = "Check balance";
            this.btnShowBalance.UseVisualStyleBackColor = true;
            this.btnShowBalance.Click += new System.EventHandler(this.btnShowBalance_Click);
            // 
            // lblShowbalance
            // 
            this.lblShowbalance.Location = new System.Drawing.Point(750, 339);
            this.lblShowbalance.Name = "lblShowbalance";
            this.lblShowbalance.Size = new System.Drawing.Size(150, 42);
            this.lblShowbalance.TabIndex = 31;
            this.lblShowbalance.Text = "Show balance:";
            this.lblShowbalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBalanceAmount.Location = new System.Drawing.Point(883, 338);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(150, 42);
            this.lblBalanceAmount.TabIndex = 32;
            this.lblBalanceAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseandOpenMainPage
            // 
            this.btnCloseandOpenMainPage.Location = new System.Drawing.Point(331, 409);
            this.btnCloseandOpenMainPage.Name = "btnCloseandOpenMainPage";
            this.btnCloseandOpenMainPage.Size = new System.Drawing.Size(256, 42);
            this.btnCloseandOpenMainPage.TabIndex = 33;
            this.btnCloseandOpenMainPage.Text = "Quit and move to Main Page";
            this.btnCloseandOpenMainPage.UseVisualStyleBackColor = true;
            this.btnCloseandOpenMainPage.Click += new System.EventHandler(this.btnCloseandOpenMainPage_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.btnCloseandOpenMainPage);
            this.Controls.Add(this.lblBalanceAmount);
            this.Controls.Add(this.lblShowbalance);
            this.Controls.Add(this.btnShowBalance);
            this.Controls.Add(this.btnExecuteTransaction);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOptionSelection);
            this.Controls.Add(this.cmbtransactionChoices);
            this.Controls.Add(this.lblDepositWithdrawalsandCheckBalance);
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form12_FormClosed);
            this.Load += new System.EventHandler(this.Form12_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDepositWithdrawalsandCheckBalance;
        private ComboBox cmbtransactionChoices;
        private Label lblOptionSelection;
        private Label label1;
        private TextBox txtAmount;
        private Button btnExecuteTransaction;
        private Button btnShowBalance;
        private Label lblShowbalance;
        private Label lblBalanceAmount;
        private Button btnCloseandOpenMainPage;
    }
}