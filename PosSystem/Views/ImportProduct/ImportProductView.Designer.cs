namespace lhk.POS.Presentation.Views
{
    partial class ImportProductView
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._dgvImportList = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ucSaleProduct = new lhk.POS.Presentation.Views.SaleProductComponent();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcuteImport = new System.Windows.Forms.Button();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._dtpImportDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnSearch = new System.Windows.Forms.Button();
            this._dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this._dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvImportList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this._dgvImportList);
            this.groupBox4.Location = new System.Drawing.Point(3, 121);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(302, 396);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách nhập";
            // 
            // _dgvImportList
            // 
            this._dgvImportList.AllowUserToAddRows = false;
            this._dgvImportList.AllowUserToDeleteRows = false;
            this._dgvImportList.AllowUserToOrderColumns = true;
            this._dgvImportList.AllowUserToResizeRows = false;
            this._dgvImportList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgvImportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvImportList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgvImportList.Location = new System.Drawing.Point(3, 18);
            this._dgvImportList.MultiSelect = false;
            this._dgvImportList.Name = "_dgvImportList";
            this._dgvImportList.ReadOnly = true;
            this._dgvImportList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvImportList.Size = new System.Drawing.Size(296, 375);
            this._dgvImportList.TabIndex = 0;
            this._dgvImportList.SelectionChanged += new System.EventHandler(this._dgvImportList_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ucSaleProduct);
            this.groupBox3.Location = new System.Drawing.Point(311, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(878, 396);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản phẩm";
            // 
            // ucSaleProduct
            // 
            this.ucSaleProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSaleProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSaleProduct.Location = new System.Drawing.Point(3, 18);
            this.ucSaleProduct.Margin = new System.Windows.Forms.Padding(6);
            this.ucSaleProduct.MinimumSize = new System.Drawing.Size(843, 295);
            this.ucSaleProduct.Name = "ucSaleProduct";
            this.ucSaleProduct.Size = new System.Drawing.Size(872, 375);
            this.ucSaleProduct.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnExcuteImport);
            this.groupBox2.Controls.Add(this._txtDescription);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this._dtpImportDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(311, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(878, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết nhập";
            // 
            // btnExcuteImport
            // 
            this.btnExcuteImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcuteImport.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExcuteImport.Location = new System.Drawing.Point(16, 69);
            this.btnExcuteImport.Name = "btnExcuteImport";
            this.btnExcuteImport.Size = new System.Drawing.Size(127, 34);
            this.btnExcuteImport.TabIndex = 19;
            this.btnExcuteImport.Text = "Nhập hàng";
            this.btnExcuteImport.UseVisualStyleBackColor = true;
            this.btnExcuteImport.Click += new System.EventHandler(this.btnExcuteImport_Click);
            // 
            // _txtDescription
            // 
            this._txtDescription.Enabled = false;
            this._txtDescription.Location = new System.Drawing.Point(532, 21);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(319, 64);
            this._txtDescription.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ghi chú:";
            // 
            // _dtpImportDate
            // 
            this._dtpImportDate.Enabled = false;
            this._dtpImportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtpImportDate.Location = new System.Drawing.Point(127, 24);
            this._dtpImportDate.Name = "_dtpImportDate";
            this._dtpImportDate.Size = new System.Drawing.Size(229, 22);
            this._dtpImportDate.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày nhập:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._btnSearch);
            this.groupBox1.Controls.Add(this._dtpToDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this._dtpFromDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // _btnSearch
            // 
            this._btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSearch.Location = new System.Drawing.Point(201, 78);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(75, 23);
            this._btnSearch.TabIndex = 17;
            this._btnSearch.Text = "Tìm";
            this._btnSearch.UseVisualStyleBackColor = true;
            this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
            // 
            // _dtpToDate
            // 
            this._dtpToDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtpToDate.Location = new System.Drawing.Point(95, 50);
            this._dtpToDate.Name = "_dtpToDate";
            this._dtpToDate.Size = new System.Drawing.Size(181, 22);
            this._dtpToDate.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tới ngày:";
            // 
            // _dtpFromDate
            // 
            this._dtpFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtpFromDate.Location = new System.Drawing.Point(95, 22);
            this._dtpFromDate.Name = "_dtpFromDate";
            this._dtpFromDate.Size = new System.Drawing.Size(181, 22);
            this._dtpFromDate.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Từ ngày:";
            // 
            // ImportProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 529);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "ImportProductView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportProductView";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgvImportList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker _dtpImportDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker _dtpToDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker _dtpFromDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button _btnSearch;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.Label label8;
        private SaleProductComponent ucSaleProduct;
        private System.Windows.Forms.Button btnExcuteImport;
        private System.Windows.Forms.DataGridView _dgvImportList;
    }
}