namespace lhk.POS.Presentation.Views
{
    partial class ProductView
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
            this._ctvCategory = new lhk.POS.Presentation.Components.CategoryTreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._btnUpdateInventory = new System.Windows.Forms.Button();
            this._btnUpdatePrice = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.tbInventory = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._cboManufacturer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this._cboUnit = new System.Windows.Forms.ComboBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBardCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._dgvListProducts = new System.Windows.Forms.DataGridView();
            this.gbSearchBox = new System.Windows.Forms.GroupBox();
            this.ckbIsSearchStockTo = new System.Windows.Forms.CheckBox();
            this.tbSearchStockTo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ckbIsSearchStockFrom = new System.Windows.Forms.CheckBox();
            this.ckbIsSearchPriceTo = new System.Windows.Forms.CheckBox();
            this.ckbIsSearchPriceFrom = new System.Windows.Forms.CheckBox();
            this.ckbIsSearchName = new System.Windows.Forms.CheckBox();
            this.ckbIsSearchBarcode = new System.Windows.Forms.CheckBox();
            this.tbSearchStockFrom = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbSearchPriceTo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchPriceFrom = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSearchBarcode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvListProducts)).BeginInit();
            this.gbSearchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this._ctvCategory);
            this.groupBox1.Location = new System.Drawing.Point(9, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 327);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân loại";
            // 
            // _ctvCategory
            // 
            this._ctvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ctvCategory.Location = new System.Drawing.Point(3, 18);
            this._ctvCategory.Name = "_ctvCategory";
            this._ctvCategory.Size = new System.Drawing.Size(267, 306);
            this._ctvCategory.TabIndex = 0;
            this._ctvCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this._ctvCategory_AfterSelect);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._btnUpdateInventory);
            this.groupBox2.Controls.Add(this._btnUpdatePrice);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbCategoryName);
            this.groupBox2.Controls.Add(this.tbInventory);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbCost);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbPrice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this._cboManufacturer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this._cboUnit);
            this.groupBox2.Controls.Add(this.tbDescription);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbBardCode);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(285, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(826, 251);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // _btnUpdateInventory
            // 
            this._btnUpdateInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnUpdateInventory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this._btnUpdateInventory.Location = new System.Drawing.Point(370, 213);
            this._btnUpdateInventory.Name = "_btnUpdateInventory";
            this._btnUpdateInventory.Size = new System.Drawing.Size(145, 23);
            this._btnUpdateInventory.TabIndex = 22;
            this._btnUpdateInventory.Text = "Cập nhật Tồn kho";
            this._btnUpdateInventory.UseVisualStyleBackColor = true;
            this._btnUpdateInventory.Visible = false;
            this._btnUpdateInventory.Click += new System.EventHandler(this._btnUpdateInventory_Click);
            // 
            // _btnUpdatePrice
            // 
            this._btnUpdatePrice.Location = new System.Drawing.Point(407, 179);
            this._btnUpdatePrice.Name = "_btnUpdatePrice";
            this._btnUpdatePrice.Size = new System.Drawing.Size(31, 22);
            this._btnUpdatePrice.TabIndex = 20;
            this._btnUpdatePrice.Text = "...";
            this._btnUpdatePrice.UseVisualStyleBackColor = true;
            this._btnUpdatePrice.Click += new System.EventHandler(this._btnUpdatePrice_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(14, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 19);
            this.label12.TabIndex = 21;
            this.label12.Text = "Tồn kho:";
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCategoryName.Location = new System.Drawing.Point(549, 106);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.ReadOnly = true;
            this.tbCategoryName.Size = new System.Drawing.Size(271, 22);
            this.tbCategoryName.TabIndex = 8;
            // 
            // tbInventory
            // 
            this.tbInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInventory.Enabled = false;
            this.tbInventory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbInventory.Location = new System.Drawing.Point(101, 214);
            this.tbInventory.Name = "tbInventory";
            this.tbInventory.Size = new System.Drawing.Size(259, 26);
            this.tbInventory.TabIndex = 5;
            this.tbInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextBox_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(453, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Phân loại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(366, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "VNĐ";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(101, 141);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(259, 22);
            this.tbCost.TabIndex = 3;
            this.tbCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCost.TextChanged += new System.EventHandler(this.CurrencyText_TextChanged);
            this.tbCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextBox_KeyPress);
            this.tbCost.Leave += new System.EventHandler(this.tbCost_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(14, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Giá bán:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "VNĐ";
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbPrice.Location = new System.Drawing.Point(101, 179);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(259, 22);
            this.tbPrice.TabIndex = 4;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPrice.TextChanged += new System.EventHandler(this.CurrencyText_TextChanged);
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextBox_KeyPress);
            this.tbPrice.Leave += new System.EventHandler(this.tbPrice_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Giá nhập:";
            // 
            // _cboManufacturer
            // 
            this._cboManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cboManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cboManufacturer.FormattingEnabled = true;
            this._cboManufacturer.Location = new System.Drawing.Point(548, 31);
            this._cboManufacturer.Name = "_cboManufacturer";
            this._cboManufacturer.Size = new System.Drawing.Size(272, 24);
            this._cboManufacturer.TabIndex = 6;
            this._cboManufacturer.SelectedIndexChanged += new System.EventHandler(this._cboManufacturer_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nhà sản xuất:";
            // 
            // _cboUnit
            // 
            this._cboUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cboUnit.FormattingEnabled = true;
            this._cboUnit.Location = new System.Drawing.Point(548, 67);
            this._cboUnit.Name = "_cboUnit";
            this._cboUnit.Size = new System.Drawing.Size(272, 24);
            this._cboUnit.TabIndex = 7;
            this._cboUnit.SelectedIndexChanged += new System.EventHandler(this._cboUnit_SelectedIndexChanged);
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(548, 141);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(272, 95);
            this.tbDescription.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ghi chú:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(101, 105);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(300, 22);
            this.tbName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên:";
            // 
            // tbBardCode
            // 
            this.tbBardCode.Location = new System.Drawing.Point(101, 68);
            this.tbBardCode.Name = "tbBardCode";
            this.tbBardCode.Size = new System.Drawing.Size(300, 22);
            this.tbBardCode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã vạch:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn vị:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(101, 31);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(300, 22);
            this.tbID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this._dgvListProducts);
            this.groupBox4.Location = new System.Drawing.Point(285, 258);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(826, 301);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách sản phẩm";
            // 
            // _dgvListProducts
            // 
            this._dgvListProducts.AllowUserToAddRows = false;
            this._dgvListProducts.AllowUserToDeleteRows = false;
            this._dgvListProducts.AllowUserToOrderColumns = true;
            this._dgvListProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvListProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgvListProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvListProducts.Location = new System.Drawing.Point(3, 18);
            this._dgvListProducts.MultiSelect = false;
            this._dgvListProducts.Name = "_dgvListProducts";
            this._dgvListProducts.ReadOnly = true;
            this._dgvListProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvListProducts.Size = new System.Drawing.Size(825, 285);
            this._dgvListProducts.TabIndex = 0;
            this._dgvListProducts.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.Gridview_ColumnAdded);
            this._dgvListProducts.SelectionChanged += new System.EventHandler(this._dgvListProducts_SelectionChanged);
            // 
            // gbSearchBox
            // 
            this.gbSearchBox.Controls.Add(this.ckbIsSearchStockTo);
            this.gbSearchBox.Controls.Add(this.tbSearchStockTo);
            this.gbSearchBox.Controls.Add(this.label18);
            this.gbSearchBox.Controls.Add(this.ckbIsSearchStockFrom);
            this.gbSearchBox.Controls.Add(this.ckbIsSearchPriceTo);
            this.gbSearchBox.Controls.Add(this.ckbIsSearchPriceFrom);
            this.gbSearchBox.Controls.Add(this.ckbIsSearchName);
            this.gbSearchBox.Controls.Add(this.ckbIsSearchBarcode);
            this.gbSearchBox.Controls.Add(this.tbSearchStockFrom);
            this.gbSearchBox.Controls.Add(this.label17);
            this.gbSearchBox.Controls.Add(this.tbSearchPriceTo);
            this.gbSearchBox.Controls.Add(this.label15);
            this.gbSearchBox.Controls.Add(this.btnSearch);
            this.gbSearchBox.Controls.Add(this.tbSearchPriceFrom);
            this.gbSearchBox.Controls.Add(this.label16);
            this.gbSearchBox.Controls.Add(this.tbSearchName);
            this.gbSearchBox.Controls.Add(this.label13);
            this.gbSearchBox.Controls.Add(this.tbSearchBarcode);
            this.gbSearchBox.Controls.Add(this.label14);
            this.gbSearchBox.Location = new System.Drawing.Point(9, 1);
            this.gbSearchBox.Name = "gbSearchBox";
            this.gbSearchBox.Size = new System.Drawing.Size(270, 225);
            this.gbSearchBox.TabIndex = 0;
            this.gbSearchBox.TabStop = false;
            this.gbSearchBox.Text = "Tìm kiếm";
            // 
            // ckbIsSearchStockTo
            // 
            this.ckbIsSearchStockTo.AutoSize = true;
            this.ckbIsSearchStockTo.Location = new System.Drawing.Point(249, 166);
            this.ckbIsSearchStockTo.Name = "ckbIsSearchStockTo";
            this.ckbIsSearchStockTo.Size = new System.Drawing.Size(15, 14);
            this.ckbIsSearchStockTo.TabIndex = 33;
            this.ckbIsSearchStockTo.UseVisualStyleBackColor = true;
            // 
            // tbSearchStockTo
            // 
            this.tbSearchStockTo.Location = new System.Drawing.Point(90, 160);
            this.tbSearchStockTo.Name = "tbSearchStockTo";
            this.tbSearchStockTo.Size = new System.Drawing.Size(153, 22);
            this.tbSearchStockTo.TabIndex = 5;
            this.tbSearchStockTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 164);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 16);
            this.label18.TabIndex = 32;
            this.label18.Text = "Tồn kho đến:";
            // 
            // ckbIsSearchStockFrom
            // 
            this.ckbIsSearchStockFrom.AutoSize = true;
            this.ckbIsSearchStockFrom.Location = new System.Drawing.Point(249, 138);
            this.ckbIsSearchStockFrom.Name = "ckbIsSearchStockFrom";
            this.ckbIsSearchStockFrom.Size = new System.Drawing.Size(15, 14);
            this.ckbIsSearchStockFrom.TabIndex = 30;
            this.ckbIsSearchStockFrom.UseVisualStyleBackColor = true;
            // 
            // ckbIsSearchPriceTo
            // 
            this.ckbIsSearchPriceTo.AutoSize = true;
            this.ckbIsSearchPriceTo.Location = new System.Drawing.Point(249, 110);
            this.ckbIsSearchPriceTo.Name = "ckbIsSearchPriceTo";
            this.ckbIsSearchPriceTo.Size = new System.Drawing.Size(15, 14);
            this.ckbIsSearchPriceTo.TabIndex = 29;
            this.ckbIsSearchPriceTo.UseVisualStyleBackColor = true;
            // 
            // ckbIsSearchPriceFrom
            // 
            this.ckbIsSearchPriceFrom.AutoSize = true;
            this.ckbIsSearchPriceFrom.Location = new System.Drawing.Point(249, 82);
            this.ckbIsSearchPriceFrom.Name = "ckbIsSearchPriceFrom";
            this.ckbIsSearchPriceFrom.Size = new System.Drawing.Size(15, 14);
            this.ckbIsSearchPriceFrom.TabIndex = 28;
            this.ckbIsSearchPriceFrom.UseVisualStyleBackColor = true;
            // 
            // ckbIsSearchName
            // 
            this.ckbIsSearchName.AutoSize = true;
            this.ckbIsSearchName.Location = new System.Drawing.Point(249, 52);
            this.ckbIsSearchName.Name = "ckbIsSearchName";
            this.ckbIsSearchName.Size = new System.Drawing.Size(15, 14);
            this.ckbIsSearchName.TabIndex = 27;
            this.ckbIsSearchName.UseVisualStyleBackColor = true;
            // 
            // ckbIsSearchBarcode
            // 
            this.ckbIsSearchBarcode.AutoSize = true;
            this.ckbIsSearchBarcode.Location = new System.Drawing.Point(249, 25);
            this.ckbIsSearchBarcode.Name = "ckbIsSearchBarcode";
            this.ckbIsSearchBarcode.Size = new System.Drawing.Size(15, 14);
            this.ckbIsSearchBarcode.TabIndex = 26;
            this.ckbIsSearchBarcode.UseVisualStyleBackColor = true;
            // 
            // tbSearchStockFrom
            // 
            this.tbSearchStockFrom.Location = new System.Drawing.Point(90, 132);
            this.tbSearchStockFrom.Name = "tbSearchStockFrom";
            this.tbSearchStockFrom.Size = new System.Drawing.Size(153, 22);
            this.tbSearchStockFrom.TabIndex = 4;
            this.tbSearchStockFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 16);
            this.label17.TabIndex = 25;
            this.label17.Text = "Tồn kho từ:";
            // 
            // tbSearchPriceTo
            // 
            this.tbSearchPriceTo.Location = new System.Drawing.Point(69, 104);
            this.tbSearchPriceTo.Name = "tbSearchPriceTo";
            this.tbSearchPriceTo.Size = new System.Drawing.Size(174, 22);
            this.tbSearchPriceTo.TabIndex = 3;
            this.tbSearchPriceTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSearchPriceTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            this.tbSearchPriceTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextBox_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 16);
            this.label15.TabIndex = 23;
            this.label15.Text = "Đến:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(191, 188);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 29);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearchPriceFrom
            // 
            this.tbSearchPriceFrom.Location = new System.Drawing.Point(69, 76);
            this.tbSearchPriceFrom.Name = "tbSearchPriceFrom";
            this.tbSearchPriceFrom.Size = new System.Drawing.Size(174, 22);
            this.tbSearchPriceFrom.TabIndex = 2;
            this.tbSearchPriceFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSearchPriceFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            this.tbSearchPriceFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextBox_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 16);
            this.label16.TabIndex = 19;
            this.label16.Text = "Giá từ:";
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(69, 48);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(174, 22);
            this.tbSearchName.TabIndex = 1;
            this.tbSearchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Tên:";
            // 
            // tbSearchBarcode
            // 
            this.tbSearchBarcode.Location = new System.Drawing.Point(69, 20);
            this.tbSearchBarcode.Name = "tbSearchBarcode";
            this.tbSearchBarcode.Size = new System.Drawing.Size(174, 22);
            this.tbSearchBarcode.TabIndex = 0;
            this.tbSearchBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 16);
            this.label14.TabIndex = 9;
            this.label14.Text = "Mã vạch:";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 571);
            this.Controls.Add(this.gbSearchBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "ProductView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgvListProducts)).EndInit();
            this.gbSearchBox.ResumeLayout(false);
            this.gbSearchBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBardCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox _cboManufacturer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox _cboUnit;
        private lhk.POS.Presentation.Components.CategoryTreeView _ctvCategory;
        private System.Windows.Forms.DataGridView _dgvListProducts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button _btnUpdateInventory;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbInventory;
        private System.Windows.Forms.Button _btnUpdatePrice;
        private System.Windows.Forms.GroupBox gbSearchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchPriceFrom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSearchBarcode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbSearchPriceTo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbSearchStockFrom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox ckbIsSearchStockFrom;
        private System.Windows.Forms.CheckBox ckbIsSearchPriceTo;
        private System.Windows.Forms.CheckBox ckbIsSearchPriceFrom;
        private System.Windows.Forms.CheckBox ckbIsSearchName;
        private System.Windows.Forms.CheckBox ckbIsSearchBarcode;
        private System.Windows.Forms.CheckBox ckbIsSearchStockTo;
        private System.Windows.Forms.TextBox tbSearchStockTo;
        private System.Windows.Forms.Label label18;
        //private staff.sale.CachedcrCustomerBill cachedcrCustomerBill1;
    }
}

