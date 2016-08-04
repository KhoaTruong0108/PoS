namespace lhk.POS.Presentation.Views
{
    partial class ReportView
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSubQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSubPayment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvOrderItem = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbProfit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRevenue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbExpense = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._cbQuarter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtYear = new System.Windows.Forms.RadioButton();
            this._btnSearch = new System.Windows.Forms.Button();
            this.rbtQuarter = new System.Windows.Forms.RadioButton();
            this.rbtMonth = new System.Windows.Forms.RadioButton();
            this.rbtDate = new System.Windows.Forms.RadioButton();
            this._dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this._dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tbSubQuantity);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbSubPayment);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dgvOrderItem);
            this.groupBox2.Location = new System.Drawing.Point(272, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 241);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mặt hàng";
            // 
            // tbSubQuantity
            // 
            this.tbSubQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSubQuantity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSubQuantity.Location = new System.Drawing.Point(154, 209);
            this.tbSubQuantity.Name = "tbSubQuantity";
            this.tbSubQuantity.ReadOnly = true;
            this.tbSubQuantity.Size = new System.Drawing.Size(165, 22);
            this.tbSubQuantity.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(77, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Số lượng:";
            // 
            // tbSubPayment
            // 
            this.tbSubPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSubPayment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSubPayment.Location = new System.Drawing.Point(398, 209);
            this.tbSubPayment.Name = "tbSubPayment";
            this.tbSubPayment.ReadOnly = true;
            this.tbSubPayment.Size = new System.Drawing.Size(165, 22);
            this.tbSubPayment.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(354, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tổng:";
            // 
            // dgvOrderItem
            // 
            this.dgvOrderItem.AllowUserToAddRows = false;
            this.dgvOrderItem.AllowUserToDeleteRows = false;
            this.dgvOrderItem.AllowUserToOrderColumns = true;
            this.dgvOrderItem.AllowUserToResizeRows = false;
            this.dgvOrderItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItem.Location = new System.Drawing.Point(3, 18);
            this.dgvOrderItem.MultiSelect = false;
            this.dgvOrderItem.Name = "dgvOrderItem";
            this.dgvOrderItem.ReadOnly = true;
            this.dgvOrderItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderItem.Size = new System.Drawing.Size(563, 185);
            this.dgvOrderItem.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgvOrders);
            this.groupBox4.Location = new System.Drawing.Point(3, 285);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 241);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hóa đơn";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToOrderColumns = true;
            this.dgvOrders.AllowUserToResizeRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(3, 18);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(260, 220);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this._dgvImportList_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbProfit);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbRevenue);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbExpense);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(3, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 113);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // tbProfit
            // 
            this.tbProfit.BackColor = System.Drawing.Color.Lime;
            this.tbProfit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbProfit.Location = new System.Drawing.Point(174, 58);
            this.tbProfit.Name = "tbProfit";
            this.tbProfit.ReadOnly = true;
            this.tbProfit.Size = new System.Drawing.Size(486, 32);
            this.tbProfit.TabIndex = 19;
            this.tbProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(31, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Lợi nhuận:";
            // 
            // tbRevenue
            // 
            this.tbRevenue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbRevenue.Location = new System.Drawing.Point(490, 21);
            this.tbRevenue.Name = "tbRevenue";
            this.tbRevenue.ReadOnly = true;
            this.tbRevenue.Size = new System.Drawing.Size(170, 26);
            this.tbRevenue.TabIndex = 17;
            this.tbRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(385, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Doanh số:";
            // 
            // tbExpense
            // 
            this.tbExpense.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbExpense.Location = new System.Drawing.Point(174, 21);
            this.tbExpense.Name = "tbExpense";
            this.tbExpense.ReadOnly = true;
            this.tbExpense.Size = new System.Drawing.Size(165, 26);
            this.tbExpense.TabIndex = 15;
            this.tbExpense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(101, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Vốn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._cbQuarter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbtYear);
            this.groupBox1.Controls.Add(this._btnSearch);
            this.groupBox1.Controls.Add(this.rbtQuarter);
            this.groupBox1.Controls.Add(this.rbtMonth);
            this.groupBox1.Controls.Add(this.rbtDate);
            this.groupBox1.Controls.Add(this._dtpToDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this._dtpFromDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // _cbQuarter
            // 
            this._cbQuarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbQuarter.FormattingEnabled = true;
            this._cbQuarter.Location = new System.Drawing.Point(536, 61);
            this._cbQuarter.Name = "_cbQuarter";
            this._cbQuarter.Size = new System.Drawing.Size(121, 24);
            this._cbQuarter.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Báo cáo theo:";
            // 
            // rbtYear
            // 
            this.rbtYear.AutoSize = true;
            this.rbtYear.Location = new System.Drawing.Point(402, 19);
            this.rbtYear.Name = "rbtYear";
            this.rbtYear.Size = new System.Drawing.Size(53, 20);
            this.rbtYear.TabIndex = 21;
            this.rbtYear.Text = "Năm";
            this.rbtYear.UseVisualStyleBackColor = true;
            this.rbtYear.CheckedChanged += new System.EventHandler(this.rbtDate_CheckedChanged);
            // 
            // _btnSearch
            // 
            this._btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._btnSearch.Location = new System.Drawing.Point(93, 105);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(121, 37);
            this._btnSearch.TabIndex = 17;
            this._btnSearch.Text = "Báo cáo";
            this._btnSearch.UseVisualStyleBackColor = true;
            this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
            // 
            // rbtQuarter
            // 
            this.rbtQuarter.AutoSize = true;
            this.rbtQuarter.Location = new System.Drawing.Point(536, 21);
            this.rbtQuarter.Name = "rbtQuarter";
            this.rbtQuarter.Size = new System.Drawing.Size(50, 20);
            this.rbtQuarter.TabIndex = 20;
            this.rbtQuarter.Text = "Quý";
            this.rbtQuarter.UseVisualStyleBackColor = true;
            this.rbtQuarter.CheckedChanged += new System.EventHandler(this.rbtDate_CheckedChanged);
            // 
            // rbtMonth
            // 
            this.rbtMonth.AutoSize = true;
            this.rbtMonth.Location = new System.Drawing.Point(260, 19);
            this.rbtMonth.Name = "rbtMonth";
            this.rbtMonth.Size = new System.Drawing.Size(61, 20);
            this.rbtMonth.TabIndex = 19;
            this.rbtMonth.Text = "Tháng";
            this.rbtMonth.UseVisualStyleBackColor = true;
            this.rbtMonth.CheckedChanged += new System.EventHandler(this.rbtDate_CheckedChanged);
            // 
            // rbtDate
            // 
            this.rbtDate.AutoSize = true;
            this.rbtDate.Checked = true;
            this.rbtDate.Location = new System.Drawing.Point(123, 19);
            this.rbtDate.Name = "rbtDate";
            this.rbtDate.Size = new System.Drawing.Size(56, 20);
            this.rbtDate.TabIndex = 18;
            this.rbtDate.TabStop = true;
            this.rbtDate.Text = "Ngày";
            this.rbtDate.UseVisualStyleBackColor = true;
            this.rbtDate.CheckedChanged += new System.EventHandler(this.rbtDate_CheckedChanged);
            // 
            // _dtpToDate
            // 
            this._dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtpToDate.Location = new System.Drawing.Point(342, 62);
            this._dtpToDate.Name = "_dtpToDate";
            this._dtpToDate.Size = new System.Drawing.Size(137, 22);
            this._dtpToDate.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tới ngày:";
            // 
            // _dtpFromDate
            // 
            this._dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dtpFromDate.Location = new System.Drawing.Point(102, 62);
            this._dtpFromDate.Name = "_dtpFromDate";
            this._dtpFromDate.Size = new System.Drawing.Size(134, 22);
            this._dtpFromDate.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Từ ngày:";
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 529);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "ReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker _dtpToDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker _dtpFromDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button _btnSearch;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtYear;
        private System.Windows.Forms.RadioButton rbtQuarter;
        private System.Windows.Forms.RadioButton rbtMonth;
        private System.Windows.Forms.RadioButton rbtDate;
        private System.Windows.Forms.TextBox tbProfit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRevenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbExpense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvOrderItem;
        private System.Windows.Forms.ComboBox _cbQuarter;
        private System.Windows.Forms.TextBox tbSubQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSubPayment;
        private System.Windows.Forms.Label label7;
    }
}