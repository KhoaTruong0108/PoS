namespace lhk.POS.Presentation.Views
{
    partial class ProductPriceView
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
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this._txtImportPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._txtSalePrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._txtCurrentSalePrice = new System.Windows.Forms.TextBox();
            this._txtReason = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._txtCurrentImportPrice = new System.Windows.Forms.TextBox();
            this._txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtBardCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(254, 337);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(105, 30);
            this._btnCancel.TabIndex = 2;
            this._btnCancel.Text = "Hủy";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _btnOk
            // 
            this._btnOk.Location = new System.Drawing.Point(125, 337);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(109, 30);
            this._btnOk.TabIndex = 1;
            this._btnOk.Text = "Đồng ý";
            this._btnOk.UseVisualStyleBackColor = true;
            this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this._txtImportPrice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this._txtSalePrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this._txtCurrentSalePrice);
            this.groupBox1.Controls.Add(this._txtReason);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this._txtCurrentImportPrice);
            this.groupBox1.Controls.Add(this._txtName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._txtBardCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(424, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "VNĐ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(422, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "VNĐ";
            // 
            // _txtImportPrice
            // 
            this._txtImportPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._txtImportPrice.Location = new System.Drawing.Point(155, 136);
            this._txtImportPrice.Name = "_txtImportPrice";
            this._txtImportPrice.Size = new System.Drawing.Size(262, 22);
            this._txtImportPrice.TabIndex = 4;
            this._txtImportPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._txtImportPrice.TextChanged += new System.EventHandler(this._txtImportPrice_TextChanged);
            this._txtImportPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtImportPrice_KeyPress);
            this._txtImportPrice.Leave += new System.EventHandler(this._txtImportPrice_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Giá nhập:";
            // 
            // _txtSalePrice
            // 
            this._txtSalePrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._txtSalePrice.ForeColor = System.Drawing.Color.DarkRed;
            this._txtSalePrice.Location = new System.Drawing.Point(156, 210);
            this._txtSalePrice.Name = "_txtSalePrice";
            this._txtSalePrice.Size = new System.Drawing.Size(262, 22);
            this._txtSalePrice.TabIndex = 6;
            this._txtSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._txtSalePrice.TextChanged += new System.EventHandler(this._txtImportPrice_TextChanged);
            this._txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtImportPrice_KeyPress);
            this._txtSalePrice.Leave += new System.EventHandler(this._txtSalePrice_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(20, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Giá bán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(422, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "VNĐ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(20, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Giá bán hiện tại:";
            // 
            // _txtCurrentSalePrice
            // 
            this._txtCurrentSalePrice.Enabled = false;
            this._txtCurrentSalePrice.ForeColor = System.Drawing.Color.Maroon;
            this._txtCurrentSalePrice.Location = new System.Drawing.Point(156, 173);
            this._txtCurrentSalePrice.Name = "_txtCurrentSalePrice";
            this._txtCurrentSalePrice.ReadOnly = true;
            this._txtCurrentSalePrice.Size = new System.Drawing.Size(262, 22);
            this._txtCurrentSalePrice.TabIndex = 5;
            this._txtCurrentSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _txtReason
            // 
            this._txtReason.Location = new System.Drawing.Point(155, 247);
            this._txtReason.Multiline = true;
            this._txtReason.Name = "_txtReason";
            this._txtReason.Size = new System.Drawing.Size(302, 66);
            this._txtReason.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Lý do thay đổi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(424, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "VNĐ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(20, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Giá nhập hiện tại:";
            // 
            // _txtCurrentImportPrice
            // 
            this._txtCurrentImportPrice.Enabled = false;
            this._txtCurrentImportPrice.Location = new System.Drawing.Point(156, 99);
            this._txtCurrentImportPrice.Name = "_txtCurrentImportPrice";
            this._txtCurrentImportPrice.ReadOnly = true;
            this._txtCurrentImportPrice.Size = new System.Drawing.Size(262, 22);
            this._txtCurrentImportPrice.TabIndex = 3;
            this._txtCurrentImportPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _txtName
            // 
            this._txtName.Enabled = false;
            this._txtName.Location = new System.Drawing.Point(156, 62);
            this._txtName.Name = "_txtName";
            this._txtName.ReadOnly = true;
            this._txtName.Size = new System.Drawing.Size(262, 22);
            this._txtName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tên:";
            // 
            // _txtBardCode
            // 
            this._txtBardCode.Enabled = false;
            this._txtBardCode.Location = new System.Drawing.Point(156, 25);
            this._txtBardCode.Name = "_txtBardCode";
            this._txtBardCode.ReadOnly = true;
            this._txtBardCode.Size = new System.Drawing.Size(262, 22);
            this._txtBardCode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mã vạch:";
            // 
            // ProductPriceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 387);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOk);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductPriceView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductPriceView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _txtSalePrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtCurrentSalePrice;
        private System.Windows.Forms.TextBox _txtReason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox _txtCurrentImportPrice;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtBardCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtImportPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}