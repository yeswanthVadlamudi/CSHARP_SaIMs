namespace NeaApp
{
    partial class Form15
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
            this.lblComparePrices = new System.Windows.Forms.Label();
            this.cmbProductSelection = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnCompareprices = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComparePrices
            // 
            this.lblComparePrices.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblComparePrices.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComparePrices.Location = new System.Drawing.Point(0, 0);
            this.lblComparePrices.Name = "lblComparePrices";
            this.lblComparePrices.Size = new System.Drawing.Size(1182, 91);
            this.lblComparePrices.TabIndex = 0;
            this.lblComparePrices.Text = "Compare prices";
            this.lblComparePrices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbProductSelection
            // 
            this.cmbProductSelection.AutoCompleteCustomSource.AddRange(new string[] {
            "Salt and pepper dispsenser"});
            this.cmbProductSelection.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbProductSelection.FormattingEnabled = true;
            this.cmbProductSelection.Location = new System.Drawing.Point(298, 164);
            this.cmbProductSelection.Name = "cmbProductSelection";
            this.cmbProductSelection.Size = new System.Drawing.Size(792, 39);
            this.cmbProductSelection.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(61, 163);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(170, 40);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Select product";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCompareprices
            // 
            this.btnCompareprices.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompareprices.Location = new System.Drawing.Point(298, 221);
            this.btnCompareprices.Name = "btnCompareprices";
            this.btnCompareprices.Size = new System.Drawing.Size(177, 44);
            this.btnCompareprices.TabIndex = 3;
            this.btnCompareprices.Text = "Compare prices";
            this.btnCompareprices.UseVisualStyleBackColor = true;
            this.btnCompareprices.Click += new System.EventHandler(this.btnCompareprices_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(298, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(792, 362);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCompareprices);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.cmbProductSelection);
            this.Controls.Add(this.lblComparePrices);
            this.Name = "Form15";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblComparePrices;
        private ComboBox cmbProductSelection;
        private Label lblProductName;
        private Button btnCompareprices;
        private DataGridView dataGridView1;
    }
}