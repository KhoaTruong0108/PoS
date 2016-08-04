namespace lhk.POS.Presentation.Views
{
    partial class CustomerFinderView
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this._pbImage = new System.Windows.Forms.PictureBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
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
            this._btnChoose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchCustomerView_KeyDown);
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
            this._btnClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchCustomerView_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCustomers);
            this.groupBox2.Location = new System.Drawing.Point(3, 162);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(768, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(4, 22);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(760, 212);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.DoubleClick += new System.EventHandler(this._dgvListCustomer_DoubleClick);
            this.dgvCustomers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchCustomerView_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._pbImage);
            this.groupBox1.Controls.Add(this.tbPhone);
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
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điện thoại:";
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
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(153, 36);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(404, 26);
            this.tbPhone.TabIndex = 0;
            this.tbPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchCustomerView_KeyDown);
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtBarcord_KeyPress);
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
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchCustomerView_KeyDown);
            // 
            // CustomerFinderView
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
            this.Name = "CustomerFinderView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm khách hàng";
            this.Load += new System.EventHandler(this.SearchCustomerView_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchCustomerView_KeyDown);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox _pbImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Button _btnChoose;
    }
}