namespace lhk.POS.Presentation.Views
{
    partial class ProductGridView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_gridView = new System.Windows.Forms.DataGridView();
            this.m_colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colBarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.m_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // m_gridView
            // 
            this.m_gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.m_gridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.m_gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_colID,
            this.m_colBarCode,
            this.m_colName,
            this.m_colPrice,
            this.m_colQuantity,
            this.m_colDiscount,
            this.m_colTotal});
            this.m_gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_gridView.Location = new System.Drawing.Point(0, 0);
            this.m_gridView.MultiSelect = false;
            this.m_gridView.Name = "m_gridView";
            this.m_gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_gridView.Size = new System.Drawing.Size(781, 273);
            this.m_gridView.TabIndex = 0;
            this.m_gridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_gridView_CellEndEdit);
            this.m_gridView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_gridView_CellLeave);
            this.m_gridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_gridView_CellValueChanged);
            this.m_gridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.m_gridView_UserDeletingRow);
            this.m_gridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_gridView_KeyDown);
            this.m_gridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_gridView_KeyPress);
            // 
            // m_colID
            // 
            this.m_colID.DataPropertyName = "Id";
            this.m_colID.HeaderText = "Mã số";
            this.m_colID.Name = "m_colID";
            this.m_colID.ReadOnly = true;
            // 
            // m_colBarCode
            // 
            this.m_colBarCode.DataPropertyName = "Barcode";
            this.m_colBarCode.HeaderText = "Mã vạch";
            this.m_colBarCode.Name = "m_colBarCode";
            // 
            // m_colName
            // 
            this.m_colName.DataPropertyName = "Name";
            this.m_colName.HeaderText = "Tên";
            this.m_colName.Name = "m_colName";
            // 
            // m_colPrice
            // 
            this.m_colPrice.DataPropertyName = "Price";
            this.m_colPrice.HeaderText = "Giá";
            this.m_colPrice.Name = "m_colPrice";
            this.m_colPrice.ReadOnly = true;
            // 
            // m_colQuantity
            // 
            this.m_colQuantity.DataPropertyName = "Quantity";
            this.m_colQuantity.HeaderText = "Số lượng";
            this.m_colQuantity.Name = "m_colQuantity";
            // 
            // m_colDiscount
            // 
            this.m_colDiscount.DataPropertyName = "Discount";
            this.m_colDiscount.HeaderText = "Giảm giá";
            this.m_colDiscount.Name = "m_colDiscount";
            // 
            // m_colTotal
            // 
            this.m_colTotal.DataPropertyName = "Total";
            this.m_colTotal.HeaderText = "Tổng tiền";
            this.m_colTotal.Name = "m_colTotal";
            this.m_colTotal.ReadOnly = true;
            // 
            // ProductGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_gridView);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "ProductGridView";
            this.Size = new System.Drawing.Size(781, 273);
            ((System.ComponentModel.ISupportInitialize)(this.m_gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView m_gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_colTotal;
    }
}
