namespace lhk.POS.Presentation.Views
{
    partial class ProductFinderView
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
            this._btnChoose = new System.Windows.Forms.Button();
            this._btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this._pbImage = new System.Windows.Forms.PictureBox();
            this.tbBarcord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnChoose
            // 
            this._btnChoose.Location = new System.Drawing.Point(217, 416);
            this._btnChoose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._btnChoose.Name = "_btnChoose";
            this._btnChoose.Size = new System.Drawing.Size(108, 40);
            this._btnChoose.TabIndex = 2;
            this._btnChoose.Text = "Chọn";
            this._btnChoose.UseVisualStyleBackColor = true;
            this._btnChoose.Click += new System.EventHandler(this._btnChoose_Click);
            this._btnChoose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchProductView_KeyDown);
            // 
            // _btnClose
            // 
            this._btnClose.Location = new System.Drawing.Point(373, 416);
            this._btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(112, 40);
            this._btnClose.TabIndex = 3;
            this._btnClose.Text = "Đóng";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            this._btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchProductView_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProducts);
            this.groupBox2.Location = new System.Drawing.Point(3, 162);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(768, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(4, 22);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(760, 212);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.DoubleClick += new System.EventHandler(this._dgvListProduct_DoubleClick);
            this.dgvProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchProductView_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._pbImage);
            this.groupBox1.Controls.Add(this.tbBarcord);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(768, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã vạch:";
            // 
            // _pbImage
            // 
            this._pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._pbImage.Location = new System.Drawing.Point(602, 24);
            this._pbImage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._pbImage.Name = "_pbImage";
            this._pbImage.Size = new System.Drawing.Size(145, 112);
            this._pbImage.TabIndex = 6;
            this._pbImage.TabStop = false;
            // 
            // tbBarcord
            // 
            this.tbBarcord.Location = new System.Drawing.Point(153, 36);
            this.tbBarcord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbBarcord.Name = "tbBarcord";
            this.tbBarcord.Size = new System.Drawing.Size(404, 26);
            this.tbBarcord.TabIndex = 0;
            this.tbBarcord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchProductView_KeyDown);
            this.tbBarcord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtBarcord_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(153, 70);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(404, 26);
            this.tbName.TabIndex = 1;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchProductView_KeyDown);
            // 
            // ProductFinderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 468);
            this.Controls.Add(this._btnChoose);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductFinderView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm sản phẩm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductFinderView_FormClosed);
            this.Load += new System.EventHandler(this.SearchProductView_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchProductView_KeyDown);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBarcord;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox _pbImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Button _btnChoose;
    }
}