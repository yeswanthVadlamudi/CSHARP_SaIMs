namespace NeaApp
{
    partial class Form8
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
            this.lblProduct_name = new System.Windows.Forms.Label();
            this.cmbOrderSelection = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnPlace_purchase_order = new System.Windows.Forms.Button();
            this.btnCloseandOpenMainPage = new System.Windows.Forms.Button();
            this.lblOrderSelection = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTotal_bill = new System.Windows.Forms.Label();
            this.lblPlacePurchaseOrder = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduct_name
            // 
            this.lblProduct_name.Location = new System.Drawing.Point(43, 200);
            this.lblProduct_name.Name = "lblProduct_name";
            this.lblProduct_name.Size = new System.Drawing.Size(122, 38);
            this.lblProduct_name.TabIndex = 0;
            this.lblProduct_name.Text = "Product name";
            this.lblProduct_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProduct_name.Click += new System.EventHandler(this.lblProduct_name_Click);
            // 
            // cmbOrderSelection
            // 
            this.cmbOrderSelection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbOrderSelection.FormattingEnabled = true;
            this.cmbOrderSelection.Location = new System.Drawing.Point(201, 199);
            this.cmbOrderSelection.Name = "cmbOrderSelection";
            this.cmbOrderSelection.Size = new System.Drawing.Size(1151, 36);
            this.cmbOrderSelection.TabIndex = 1;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Location = new System.Drawing.Point(43, 285);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(122, 38);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity.Location = new System.Drawing.Point(201, 285);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(125, 38);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // btnPlace_purchase_order
            // 
            this.btnPlace_purchase_order.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlace_purchase_order.Location = new System.Drawing.Point(486, 121);
            this.btnPlace_purchase_order.Name = "btnPlace_purchase_order";
            this.btnPlace_purchase_order.Size = new System.Drawing.Size(225, 40);
            this.btnPlace_purchase_order.TabIndex = 6;
            this.btnPlace_purchase_order.Text = "Place purchase order";
            this.btnPlace_purchase_order.UseVisualStyleBackColor = true;
            this.btnPlace_purchase_order.Click += new System.EventHandler(this.btnPlace_purchase_order_Click);
            // 
            // btnCloseandOpenMainPage
            // 
            this.btnCloseandOpenMainPage.Location = new System.Drawing.Point(747, 119);
            this.btnCloseandOpenMainPage.Name = "btnCloseandOpenMainPage";
            this.btnCloseandOpenMainPage.Size = new System.Drawing.Size(256, 42);
            this.btnCloseandOpenMainPage.TabIndex = 19;
            this.btnCloseandOpenMainPage.Text = "Quit and move to Main Page";
            this.btnCloseandOpenMainPage.UseVisualStyleBackColor = true;
            this.btnCloseandOpenMainPage.Click += new System.EventHandler(this.btnCloseandOpenMainPage_Click);
            // 
            // lblOrderSelection
            // 
            this.lblOrderSelection.Location = new System.Drawing.Point(201, 244);
            this.lblOrderSelection.Name = "lblOrderSelection";
            this.lblOrderSelection.Size = new System.Drawing.Size(122, 38);
            this.lblOrderSelection.TabIndex = 20;
            this.lblOrderSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOrderSelection.Click += new System.EventHandler(this.lblOrderSelection_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(143, 101);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(328, 79);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // lblTotal_bill
            // 
            this.lblTotal_bill.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal_bill.Location = new System.Drawing.Point(3, 101);
            this.lblTotal_bill.Name = "lblTotal_bill";
            this.lblTotal_bill.Size = new System.Drawing.Size(134, 79);
            this.lblTotal_bill.TabIndex = 22;
            this.lblTotal_bill.Text = "Total:";
            this.lblTotal_bill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlacePurchaseOrder
            // 
            this.lblPlacePurchaseOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPlacePurchaseOrder.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlacePurchaseOrder.Location = new System.Drawing.Point(0, 0);
            this.lblPlacePurchaseOrder.Name = "lblPlacePurchaseOrder";
            this.lblPlacePurchaseOrder.Size = new System.Drawing.Size(1482, 83);
            this.lblPlacePurchaseOrder.TabIndex = 23;
            this.lblPlacePurchaseOrder.Text = " Place purchase order";
            this.lblPlacePurchaseOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.Location = new System.Drawing.Point(43, 344);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(170, 37);
            this.btnAddProduct.TabIndex = 24;
            this.btnAddProduct.Text = "Add product to cart";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(43, 387);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 29;
            this.dataGridView5.Size = new System.Drawing.Size(1394, 571);
            this.dataGridView5.TabIndex = 25;
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveItem.Location = new System.Drawing.Point(236, 344);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(170, 37);
            this.btnRemoveItem.TabIndex = 26;
            this.btnRemoveItem.Text = "Remove product";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 1003);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lblPlacePurchaseOrder);
            this.Controls.Add(this.lblTotal_bill);
            this.Controls.Add(this.lblOrderSelection);
            this.Controls.Add(this.btnCloseandOpenMainPage);
            this.Controls.Add(this.btnPlace_purchase_order);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cmbOrderSelection);
            this.Controls.Add(this.lblProduct_name);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form8_FormClosed);
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProduct_name;
        private ComboBox cmbOrderSelection;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Button btnPlace_purchase_order;
        private Button btnCloseandOpenMainPage;
        private Label lblOrderSelection;
        private Label lblAmount;
        private Label lblTotal_bill;
        private Label lblPlacePurchaseOrder;
        private Button btnAddProduct;
        private DataGridView dataGridView5;
        private Button btnRemoveItem;
    }
}