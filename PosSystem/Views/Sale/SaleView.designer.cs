namespace lhk.POS.Presentation.Views
{
    partial class SaleView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCusPurchase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCusAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCusPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucSaleProduct = new lhk.POS.Presentation.Views.SaleProductComponent();
            this.m_btnPromotion = new System.Windows.Forms.Button();
            this.btnPayout = new System.Windows.Forms.Button();
            this.m_btnFindProduct = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbCusPurchase);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbCusAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbCusPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCusName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1038, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            // 
            // tbCusPurchase
            // 
            this.tbCusPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCusPurchase.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbCusPurchase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbCusPurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbCusPurchase.Location = new System.Drawing.Point(634, 66);
            this.tbCusPurchase.Name = "tbCusPurchase";
            this.tbCusPurchase.ReadOnly = true;
            this.tbCusPurchase.Size = new System.Drawing.Size(157, 26);
            this.tbCusPurchase.TabIndex = 3;
            this.tbCusPurchase.Text = "0.0";
            this.tbCusPurchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Điểm tích lũy:";
            // 
            // tbCusAddress
            // 
            this.tbCusAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCusAddress.Enabled = false;
            this.tbCusAddress.Location = new System.Drawing.Point(634, 34);
            this.tbCusAddress.Name = "tbCusAddress";
            this.tbCusAddress.ReadOnly = true;
            this.tbCusAddress.Size = new System.Drawing.Size(383, 26);
            this.tbCusAddress.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ:";
            // 
            // tbCusPhone
            // 
            this.tbCusPhone.Location = new System.Drawing.Point(120, 34);
            this.tbCusPhone.Name = "tbCusPhone";
            this.tbCusPhone.Size = new System.Drawing.Size(326, 26);
            this.tbCusPhone.TabIndex = 0;
            this.tbCusPhone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCusNamePhone_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điện thoại:";
            // 
            // tbCusName
            // 
            this.tbCusName.Location = new System.Drawing.Point(120, 66);
            this.tbCusName.Name = "tbCusName";
            this.tbCusName.Size = new System.Drawing.Size(326, 26);
            this.tbCusName.TabIndex = 1;
            this.tbCusName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaleView_KeyDown);
            this.tbCusName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbCusNamePhone_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ucSaleProduct);
            this.groupBox2.Location = new System.Drawing.Point(3, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1038, 424);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // ucSaleProduct
            // 
            this.ucSaleProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSaleProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSaleProduct.Location = new System.Drawing.Point(3, 22);
            this.ucSaleProduct.Margin = new System.Windows.Forms.Padding(6);
            this.ucSaleProduct.MinimumSize = new System.Drawing.Size(843, 295);
            this.ucSaleProduct.Name = "ucSaleProduct";
            this.ucSaleProduct.Size = new System.Drawing.Size(1032, 399);
            this.ucSaleProduct.TabIndex = 0;
            // 
            // m_btnPromotion
            // 
            this.m_btnPromotion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnPromotion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_btnPromotion.Location = new System.Drawing.Point(876, 556);
            this.m_btnPromotion.Name = "m_btnPromotion";
            this.m_btnPromotion.Size = new System.Drawing.Size(144, 40);
            this.m_btnPromotion.TabIndex = 5;
            this.m_btnPromotion.Text = "F8 Khuyến mãi";
            this.m_btnPromotion.UseVisualStyleBackColor = true;
            this.m_btnPromotion.Visible = false;
            this.m_btnPromotion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaleView_KeyDown);
            // 
            // btnPayout
            // 
            this.btnPayout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPayout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPayout.Location = new System.Drawing.Point(575, 556);
            this.btnPayout.Name = "btnPayout";
            this.btnPayout.Size = new System.Drawing.Size(219, 40);
            this.btnPayout.TabIndex = 3;
            this.btnPayout.Text = "F5 Thanh toán";
            this.btnPayout.UseVisualStyleBackColor = true;
            this.btnPayout.Click += new System.EventHandler(this.m_btnPayout_Click);
            this.btnPayout.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaleView_KeyDown);
            // 
            // m_btnFindProduct
            // 
            this.m_btnFindProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnFindProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.m_btnFindProduct.Location = new System.Drawing.Point(67, 556);
            this.m_btnFindProduct.Name = "m_btnFindProduct";
            this.m_btnFindProduct.Size = new System.Drawing.Size(150, 40);
            this.m_btnFindProduct.TabIndex = 3;
            this.m_btnFindProduct.Text = "F4 Tìm sản phẩm";
            this.m_btnFindProduct.UseVisualStyleBackColor = true;
            this.m_btnFindProduct.Visible = false;
            this.m_btnFindProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaleView_KeyDown);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateNew.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreateNew.Location = new System.Drawing.Point(263, 556);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(198, 40);
            this.btnCreateNew.TabIndex = 2;
            this.btnCreateNew.Text = "F1 Tạo hóa đơn";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateBill_Click);
            this.btnCreateNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaleView_KeyDown);
            // 
            // SaleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 608);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.m_btnFindProduct);
            this.Controls.Add(this.btnPayout);
            this.Controls.Add(this.m_btnPromotion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SaleView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaleView_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCusPurchase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCusAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCusPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button m_btnPromotion;
        private System.Windows.Forms.Button btnPayout;
        private System.Windows.Forms.Button m_btnFindProduct;
        //private component.productgridview.ProductGridView m_pgvListProducts;
        private System.Windows.Forms.Button btnCreateNew;
        private SaleProductComponent ucSaleProduct;
        //private CachedcrCustomerBill cachedcrCustomerBill1;



    }
}

