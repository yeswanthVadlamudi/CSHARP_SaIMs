namespace NeaApp
{
    partial class Form5
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
            this.lblAddNewItems = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemprice = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddnewItems = new System.Windows.Forms.Button();
            this.btnCloseandOpenMainPage = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemPriceperPiece = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddNewItems
            // 
            this.lblAddNewItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAddNewItems.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddNewItems.Location = new System.Drawing.Point(0, 0);
            this.lblAddNewItems.Name = "lblAddNewItems";
            this.lblAddNewItems.Size = new System.Drawing.Size(1482, 83);
            this.lblAddNewItems.TabIndex = 2;
            this.lblAddNewItems.Text = "Add new items";
            this.lblAddNewItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddNewItems.Click += new System.EventHandler(this.lblAddNewItems_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.Location = new System.Drawing.Point(12, 86);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(91, 37);
            this.lblItemName.TabIndex = 6;
            this.lblItemName.Text = "Item Name";
            // 
            // lblItemprice
            // 
            this.lblItemprice.Location = new System.Drawing.Point(12, 143);
            this.lblItemprice.Name = "lblItemprice";
            this.lblItemprice.Size = new System.Drawing.Size(125, 37);
            this.lblItemprice.TabIndex = 9;
            this.lblItemprice.Text = "Item price/ piece";
            this.lblItemprice.Click += new System.EventHandler(this.lblItemSeller_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1441, 703);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btnAddnewItems
            // 
            this.btnAddnewItems.Location = new System.Drawing.Point(12, 949);
            this.btnAddnewItems.Name = "btnAddnewItems";
            this.btnAddnewItems.Size = new System.Drawing.Size(256, 42);
            this.btnAddnewItems.TabIndex = 16;
            this.btnAddnewItems.Text = "Add new Items";
            this.btnAddnewItems.UseVisualStyleBackColor = true;
            this.btnAddnewItems.Click += new System.EventHandler(this.btnAddnewItems_Click);
            // 
            // btnCloseandOpenMainPage
            // 
            this.btnCloseandOpenMainPage.Location = new System.Drawing.Point(292, 949);
            this.btnCloseandOpenMainPage.Name = "btnCloseandOpenMainPage";
            this.btnCloseandOpenMainPage.Size = new System.Drawing.Size(256, 42);
            this.btnCloseandOpenMainPage.TabIndex = 17;
            this.btnCloseandOpenMainPage.Text = "Quit and move to Main Page";
            this.btnCloseandOpenMainPage.UseVisualStyleBackColor = true;
            this.btnCloseandOpenMainPage.Click += new System.EventHandler(this.btnCloseandOpenMainPage_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtItemName.Location = new System.Drawing.Point(141, 85);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(1312, 38);
            this.txtItemName.TabIndex = 18;
            // 
            // txtItemPriceperPiece
            // 
            this.txtItemPriceperPiece.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtItemPriceperPiece.Location = new System.Drawing.Point(141, 143);
            this.txtItemPriceperPiece.Name = "txtItemPriceperPiece";
            this.txtItemPriceperPiece.Size = new System.Drawing.Size(1312, 38);
            this.txtItemPriceperPiece.TabIndex = 19;
            // 
            // Form5
            // 
            this.AcceptButton = this.btnAddnewItems;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 1003);
            this.Controls.Add(this.txtItemPriceperPiece);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.btnCloseandOpenMainPage);
            this.Controls.Add(this.btnAddnewItems);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblItemprice);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblAddNewItems);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private Label lblAddNewItems;
        private Label lblItemName;
        private Label lblItemprice;
        private DataGridView dataGridView1;
        private Button btnAddnewItems;
        private Button btnCloseandOpenMainPage;
        private TextBox txtItemName;
        private TextBox txtItemPriceperPiece;
    }
}