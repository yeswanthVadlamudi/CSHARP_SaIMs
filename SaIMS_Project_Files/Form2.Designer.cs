namespace NeaApp
{
    partial class Form2
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
            this.btnEmployeeDetails = new System.Windows.Forms.Button();
            this.btnAddStockItems = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTakeInStockOrder = new System.Windows.Forms.Button();
            this.btnComparePrices = new System.Windows.Forms.Button();
            this.btnDepositWithdrawalbalance = new System.Windows.Forms.Button();
            this.btnSeller_info = new System.Windows.Forms.Button();
            this.btnCreateProductcatalog = new System.Windows.Forms.Button();
            this.btnSetNewLoginDetails = new System.Windows.Forms.Button();
            this.btnAdminCredentials = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnEmployeeSalary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminSignedInPage
            // 
            this.lblAdminSignedInPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAdminSignedInPage.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdminSignedInPage.Location = new System.Drawing.Point(0, 0);
            this.lblAdminSignedInPage.Name = "lblAdminSignedInPage";
            this.lblAdminSignedInPage.Size = new System.Drawing.Size(1890, 80);
            this.lblAdminSignedInPage.TabIndex = 0;
            this.lblAdminSignedInPage.Text = "Welcome, Administrator";
            this.lblAdminSignedInPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdminSignedInPage.Click += new System.EventHandler(this.lblAdminSignedInPage_Click);
            // 
            // btnEmployeeDetails
            // 
            this.btnEmployeeDetails.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmployeeDetails.Location = new System.Drawing.Point(12, 84);
            this.btnEmployeeDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployeeDetails.Name = "btnEmployeeDetails";
            this.btnEmployeeDetails.Size = new System.Drawing.Size(369, 44);
            this.btnEmployeeDetails.TabIndex = 2;
            this.btnEmployeeDetails.Text = "Take details of new employees\r\n";
            this.btnEmployeeDetails.UseVisualStyleBackColor = true;
            this.btnEmployeeDetails.Click += new System.EventHandler(this.btnEmployeeDetails_Click);
            // 
            // btnAddStockItems
            // 
            this.btnAddStockItems.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddStockItems.Location = new System.Drawing.Point(12, 241);
            this.btnAddStockItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddStockItems.Name = "btnAddStockItems";
            this.btnAddStockItems.Size = new System.Drawing.Size(369, 44);
            this.btnAddStockItems.TabIndex = 3;
            this.btnAddStockItems.Text = "Add new products";
            this.btnAddStockItems.UseVisualStyleBackColor = true;
            this.btnAddStockItems.Click += new System.EventHandler(this.btnAddStockItems_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1491, 924);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnTakeInStockOrder
            // 
            this.btnTakeInStockOrder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTakeInStockOrder.Location = new System.Drawing.Point(12, 477);
            this.btnTakeInStockOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTakeInStockOrder.Name = "btnTakeInStockOrder";
            this.btnTakeInStockOrder.Size = new System.Drawing.Size(369, 44);
            this.btnTakeInStockOrder.TabIndex = 5;
            this.btnTakeInStockOrder.Text = "Order stock";
            this.btnTakeInStockOrder.UseVisualStyleBackColor = true;
            this.btnTakeInStockOrder.Click += new System.EventHandler(this.btnTakeInStockOrder_Click);
            // 
            // btnComparePrices
            // 
            this.btnComparePrices.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComparePrices.Location = new System.Drawing.Point(12, 397);
            this.btnComparePrices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnComparePrices.Name = "btnComparePrices";
            this.btnComparePrices.Size = new System.Drawing.Size(369, 44);
            this.btnComparePrices.TabIndex = 6;
            this.btnComparePrices.Text = "Compare item prices";
            this.btnComparePrices.UseVisualStyleBackColor = true;
            this.btnComparePrices.Click += new System.EventHandler(this.btnComparePrices_Click);
            // 
            // btnDepositWithdrawalbalance
            // 
            this.btnDepositWithdrawalbalance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDepositWithdrawalbalance.Location = new System.Drawing.Point(12, 558);
            this.btnDepositWithdrawalbalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDepositWithdrawalbalance.Name = "btnDepositWithdrawalbalance";
            this.btnDepositWithdrawalbalance.Size = new System.Drawing.Size(369, 68);
            this.btnDepositWithdrawalbalance.TabIndex = 7;
            this.btnDepositWithdrawalbalance.Text = "Check balance, deposit funds and withdraw funds";
            this.btnDepositWithdrawalbalance.UseVisualStyleBackColor = true;
            this.btnDepositWithdrawalbalance.Click += new System.EventHandler(this.btnDepositWithdrawalbalance_Click);
            // 
            // btnSeller_info
            // 
            this.btnSeller_info.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSeller_info.Location = new System.Drawing.Point(12, 318);
            this.btnSeller_info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSeller_info.Name = "btnSeller_info";
            this.btnSeller_info.Size = new System.Drawing.Size(369, 44);
            this.btnSeller_info.TabIndex = 8;
            this.btnSeller_info.Text = "Add new seller information";
            this.btnSeller_info.UseVisualStyleBackColor = true;
            this.btnSeller_info.Click += new System.EventHandler(this.btnSeller_info_Click);
            // 
            // btnCreateProductcatalog
            // 
            this.btnCreateProductcatalog.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateProductcatalog.Location = new System.Drawing.Point(12, 665);
            this.btnCreateProductcatalog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateProductcatalog.Name = "btnCreateProductcatalog";
            this.btnCreateProductcatalog.Size = new System.Drawing.Size(369, 44);
            this.btnCreateProductcatalog.TabIndex = 9;
            this.btnCreateProductcatalog.Text = "Create product catalog";
            this.btnCreateProductcatalog.UseVisualStyleBackColor = true;
            this.btnCreateProductcatalog.Click += new System.EventHandler(this.btnCreateProductcatalog_Click);
            // 
            // btnSetNewLoginDetails
            // 
            this.btnSetNewLoginDetails.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSetNewLoginDetails.Location = new System.Drawing.Point(12, 162);
            this.btnSetNewLoginDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetNewLoginDetails.Name = "btnSetNewLoginDetails";
            this.btnSetNewLoginDetails.Size = new System.Drawing.Size(369, 44);
            this.btnSetNewLoginDetails.TabIndex = 10;
            this.btnSetNewLoginDetails.Text = "Set new logins for new employees";
            this.btnSetNewLoginDetails.UseVisualStyleBackColor = true;
            this.btnSetNewLoginDetails.Click += new System.EventHandler(this.btnSetNewLoginDetails_Click);
            // 
            // btnAdminCredentials
            // 
            this.btnAdminCredentials.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminCredentials.Location = new System.Drawing.Point(12, 746);
            this.btnAdminCredentials.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdminCredentials.Name = "btnAdminCredentials";
            this.btnAdminCredentials.Size = new System.Drawing.Size(369, 44);
            this.btnAdminCredentials.TabIndex = 11;
            this.btnAdminCredentials.Text = "Set admin credentials";
            this.btnAdminCredentials.UseVisualStyleBackColor = true;
            this.btnAdminCredentials.Click += new System.EventHandler(this.btnAdminCredentials_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPayments.Location = new System.Drawing.Point(12, 823);
            this.btnPayments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(369, 44);
            this.btnPayments.TabIndex = 12;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnEmployeeSalary
            // 
            this.btnEmployeeSalary.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmployeeSalary.Location = new System.Drawing.Point(12, 901);
            this.btnEmployeeSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployeeSalary.Name = "btnEmployeeSalary";
            this.btnEmployeeSalary.Size = new System.Drawing.Size(369, 44);
            this.btnEmployeeSalary.TabIndex = 13;
            this.btnEmployeeSalary.Text = "Pay employee salary";
            this.btnEmployeeSalary.UseVisualStyleBackColor = true;
            this.btnEmployeeSalary.Click += new System.EventHandler(this.btnEmployeeSalary_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1890, 1017);
            this.Controls.Add(this.btnEmployeeSalary);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnAdminCredentials);
            this.Controls.Add(this.btnSetNewLoginDetails);
            this.Controls.Add(this.btnCreateProductcatalog);
            this.Controls.Add(this.btnSeller_info);
            this.Controls.Add(this.btnDepositWithdrawalbalance);
            this.Controls.Add(this.btnComparePrices);
            this.Controls.Add(this.btnTakeInStockOrder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddStockItems);
            this.Controls.Add(this.btnEmployeeDetails);
            this.Controls.Add(this.lblAdminSignedInPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblAdminSignedInPage;
        private Button btnEmployeeDetails;
        private Button btnAddStockItems;
        private DataGridView dataGridView1;
        private Button btnTakeInStockOrder;
        private Button btnComparePrices;
        private Button btnDepositWithdrawalbalance;
        private Button btnSeller_info;
        private Button btnCreateProductcatalog;
        private Button btnSetNewLoginDetails;
        private Button btnAdminCredentials;
        private Button btnPayments;
        private Button btnEmployeeSalary;
    }
}