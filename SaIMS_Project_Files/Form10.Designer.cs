namespace NeaApp
{
    partial class Form10
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
            this.lblCreateProductCatalog = new System.Windows.Forms.Label();
            this.lblSelectproduct = new System.Windows.Forms.Label();
            this.cmbProductlist = new System.Windows.Forms.ComboBox();
            this.lblSelectseller = new System.Windows.Forms.Label();
            this.cmbSeller_name = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnAddnewItems = new System.Windows.Forms.Button();
            this.btnCloseandOpenMainPage = new System.Windows.Forms.Button();
            this.lblSelectedProduct_id = new System.Windows.Forms.Label();
            this.lblSelectedSeller_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateProductCatalog
            // 
            this.lblCreateProductCatalog.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCreateProductCatalog.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreateProductCatalog.Location = new System.Drawing.Point(0, 0);
            this.lblCreateProductCatalog.Name = "lblCreateProductCatalog";
            this.lblCreateProductCatalog.Size = new System.Drawing.Size(1482, 83);
            this.lblCreateProductCatalog.TabIndex = 5;
            this.lblCreateProductCatalog.Text = "Create product catalog";
            this.lblCreateProductCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectproduct
            // 
            this.lblSelectproduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectproduct.Location = new System.Drawing.Point(12, 131);
            this.lblSelectproduct.Name = "lblSelectproduct";
            this.lblSelectproduct.Size = new System.Drawing.Size(236, 42);
            this.lblSelectproduct.TabIndex = 11;
            this.lblSelectproduct.Text = "Select product";
            this.lblSelectproduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbProductlist
            // 
            this.cmbProductlist.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbProductlist.FormattingEnabled = true;
            this.cmbProductlist.Location = new System.Drawing.Point(224, 131);
            this.cmbProductlist.Name = "cmbProductlist";
            this.cmbProductlist.Size = new System.Drawing.Size(1022, 39);
            this.cmbProductlist.TabIndex = 12;
            // 
            // lblSelectseller
            // 
            this.lblSelectseller.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectseller.Location = new System.Drawing.Point(12, 259);
            this.lblSelectseller.Name = "lblSelectseller";
            this.lblSelectseller.Size = new System.Drawing.Size(236, 42);
            this.lblSelectseller.TabIndex = 13;
            this.lblSelectseller.Text = "Select seller";
            this.lblSelectseller.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbSeller_name
            // 
            this.cmbSeller_name.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSeller_name.FormattingEnabled = true;
            this.cmbSeller_name.Location = new System.Drawing.Point(224, 259);
            this.cmbSeller_name.Name = "cmbSeller_name";
            this.cmbSeller_name.Size = new System.Drawing.Size(1022, 39);
            this.cmbSeller_name.TabIndex = 14;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(72, 340);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(1282, 583);
            this.dataGridView3.TabIndex = 15;
            // 
            // btnAddnewItems
            // 
            this.btnAddnewItems.Location = new System.Drawing.Point(72, 945);
            this.btnAddnewItems.Name = "btnAddnewItems";
            this.btnAddnewItems.Size = new System.Drawing.Size(256, 42);
            this.btnAddnewItems.TabIndex = 17;
            this.btnAddnewItems.Text = "Add new Items";
            this.btnAddnewItems.UseVisualStyleBackColor = true;
            this.btnAddnewItems.Click += new System.EventHandler(this.btnAddnewItems_Click);
            // 
            // btnCloseandOpenMainPage
            // 
            this.btnCloseandOpenMainPage.Location = new System.Drawing.Point(373, 945);
            this.btnCloseandOpenMainPage.Name = "btnCloseandOpenMainPage";
            this.btnCloseandOpenMainPage.Size = new System.Drawing.Size(256, 42);
            this.btnCloseandOpenMainPage.TabIndex = 18;
            this.btnCloseandOpenMainPage.Text = "Quit and move to Main Page";
            this.btnCloseandOpenMainPage.UseVisualStyleBackColor = true;
            this.btnCloseandOpenMainPage.Click += new System.EventHandler(this.btnCloseandOpenMainPage_Click);
            // 
            // lblSelectedProduct_id
            // 
            this.lblSelectedProduct_id.Location = new System.Drawing.Point(335, 188);
            this.lblSelectedProduct_id.Name = "lblSelectedProduct_id";
            this.lblSelectedProduct_id.Size = new System.Drawing.Size(231, 46);
            this.lblSelectedProduct_id.TabIndex = 19;
            this.lblSelectedProduct_id.Click += new System.EventHandler(this.lblSelectedProduct_id_Click);
            // 
            // lblSelectedSeller_id
            // 
            this.lblSelectedSeller_id.Location = new System.Drawing.Point(332, 301);
            this.lblSelectedSeller_id.Name = "lblSelectedSeller_id";
            this.lblSelectedSeller_id.Size = new System.Drawing.Size(231, 39);
            this.lblSelectedSeller_id.TabIndex = 20;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 1003);
            this.Controls.Add(this.lblSelectedSeller_id);
            this.Controls.Add(this.lblSelectedProduct_id);
            this.Controls.Add(this.btnCloseandOpenMainPage);
            this.Controls.Add(this.btnAddnewItems);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.cmbSeller_name);
            this.Controls.Add(this.lblSelectseller);
            this.Controls.Add(this.cmbProductlist);
            this.Controls.Add(this.lblSelectproduct);
            this.Controls.Add(this.lblCreateProductCatalog);
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form10_FormClosed);
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblCreateProductCatalog;
        private Label lblSelectproduct;
        private ComboBox cmbProductlist;
        private Label lblSelectseller;
        private ComboBox cmbSeller_name;
        private DataGridView dataGridView3;
        private Button btnAddnewItems;
        private Button btnCloseandOpenMainPage;
        private Label lblSelectedProduct_id;
        private Label lblSelectedSeller_id;
    }
}