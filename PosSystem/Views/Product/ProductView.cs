using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lhk.POS.Core.Domain;
using lhk.POS.Core.Util;
using lhk.POS.Presentation.Models;
using lhk.POS.Presentation.Presenters;

namespace lhk.POS.Presentation.Views
{
    public partial class ProductView : GenericView, IProductView
    {
        public int QUANTITY_WARNING_COLOR = 5;
        public int QUANTITY_ALAR_COLOR = 0;
        public Color COLOR_WARNING = Color.Orange;
        public Color COLOR_ALARM = Color.Red;
        public Color COLOR_DEFAULT = Color.Black;

        protected ProductPresenter _presenter;
        protected ProductModel _model;
        protected bool _isCreating = false;

        public ProductView()
        {
            InitializeComponent();

            _presenter = new ProductPresenter(this);
        }

        public void InitView(ProductModel model)
        {
            _model = model;

            tbBardCode.DataBindings.Add("Text", _model, "Barcode", true, DataSourceUpdateMode.OnPropertyChanged);
            tbDescription.DataBindings.Add("Text", _model, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            tbID.DataBindings.Add("Text", _model, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            tbName.DataBindings.Add("Text", _model, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            tbPrice.DataBindings.Add("Text", _model, "Price", true, DataSourceUpdateMode.OnPropertyChanged);
            tbCost.DataBindings.Add("Text", _model, "Cost", true, DataSourceUpdateMode.OnPropertyChanged);
            tbCategoryName.DataBindings.Add("Text", _model, "CategoryName", true, DataSourceUpdateMode.OnPropertyChanged);
            tbInventory.DataBindings.Add("Text", _model, "StockQuantity", true, DataSourceUpdateMode.OnPropertyChanged);

            tbSearchBarcode.DataBindings.Add("Text", _model, "SearchBarcode", true, DataSourceUpdateMode.OnPropertyChanged);
            tbSearchName.DataBindings.Add("Text", _model, "SearchName", true, DataSourceUpdateMode.OnPropertyChanged);
            tbSearchPriceFrom.DataBindings.Add("Text", _model, "SearchPriceFrom", true, DataSourceUpdateMode.OnPropertyChanged);
            tbSearchPriceTo.DataBindings.Add("Text", _model, "SearchPriceTo", true, DataSourceUpdateMode.OnPropertyChanged);
            tbSearchStockFrom.DataBindings.Add("Text", _model, "SearchStockFrom", true, DataSourceUpdateMode.OnPropertyChanged);
            tbSearchStockTo.DataBindings.Add("Text", _model, "SearchStockTo", true, DataSourceUpdateMode.OnPropertyChanged);
            ckbIsSearchBarcode.DataBindings.Add("Checked", _model, "IsSearchBarcode", true, DataSourceUpdateMode.OnPropertyChanged);
            ckbIsSearchName.DataBindings.Add("Checked", _model, "IsSearchName", true, DataSourceUpdateMode.OnPropertyChanged);
            ckbIsSearchPriceFrom.DataBindings.Add("Checked", _model, "IsSearchPriceFrom", true, DataSourceUpdateMode.OnPropertyChanged);
            ckbIsSearchPriceTo.DataBindings.Add("Checked", _model, "IsSearchPriceTo", true, DataSourceUpdateMode.OnPropertyChanged);
            ckbIsSearchStockFrom.DataBindings.Add("Checked", _model, "IsSearchStockFrom", true, DataSourceUpdateMode.OnPropertyChanged);
            ckbIsSearchStockTo.DataBindings.Add("Checked", _model, "IsSearchStockTo", true, DataSourceUpdateMode.OnPropertyChanged);


            _cboUnit.DataBindings.Add("DataSource", _model, "Uints", true, DataSourceUpdateMode.OnPropertyChanged);
            _cboUnit.DataBindings.Add("SelectedItem", _model, "SelectedUnit", true, DataSourceUpdateMode.OnPropertyChanged);
            _cboManufacturer.DataBindings.Add("DataSource", _model, "Manufacturers", true, DataSourceUpdateMode.OnPropertyChanged);
            _cboManufacturer.DataBindings.Add("SelectedItem", _model, "SelectedManufacturer", true, DataSourceUpdateMode.OnPropertyChanged);

            _dgvListProducts.DataBindings.Add("DataSource", _model, "Products", true, DataSourceUpdateMode.OnPropertyChanged);

            tbBardCode.DataBindings.Add("ReadOnly", _model, "IsNotEditingStatus");
            tbDescription.DataBindings.Add("ReadOnly", _model, "IsNotEditingStatus");
            tbName.DataBindings.Add("ReadOnly", _model, "IsNotEditingStatus");
            tbCost.DataBindings.Add("ReadOnly", _model, "IsNotEditingStatus");
            tbPrice.DataBindings.Add("ReadOnly", _model, "IsNotEditingStatus");
            tbInventory.DataBindings.Add("Enabled", _model, "IsEditingStatus");
            _cboManufacturer.DataBindings.Add("Enabled", _model, "IsEditingStatus");
            _cboUnit.DataBindings.Add("Enabled", _model, "IsEditingStatus");
            _dgvListProducts.DataBindings.Add("Enabled", _model, "IsNotEditingStatus");
            _btnUpdateInventory.DataBindings.Add("Enabled", _model, "IsNotEditingStatus");
            _btnUpdatePrice.DataBindings.Add("Enabled", _model, "IsNotEditingStatus");
            gbSearchBox.DataBindings.Add("Enabled", _model, "IsNotEditingStatus");

            _cboUnit.DisplayMember = "Name";
            _cboUnit.ValueMember = "Id";
            _cboManufacturer.DisplayMember = "name";
            _cboManufacturer.ValueMember = "id";

        }

        private void _dgvListProducts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (_dgvListProducts.SelectedRows.Count > 0)
                {
                    Product selectedItem = (Product)_dgvListProducts.SelectedRows[0].DataBoundItem;
                    _model.Product = selectedItem;

                    var unit = _model.Uints.FirstOrDefault(u => u.Id == selectedItem.UnitId);
                    _model.SelectedUnit = unit != null ? unit : new Unit();

                    var manufacturer = _model.Manufacturers.FirstOrDefault(m => m.Id == selectedItem.ManufacturerId);
                    _model.SelectedManufacturer = manufacturer != null ? manufacturer : new Manufacturer();
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }
        private void _ctvCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                Category cat = (Category)_ctvCategory.SelectedNode.Tag;
                _model.SelectedCategory = cat;

                if (_model.IsNotEditingStatus)
                {
                    //HandleLoadListProduct();
                    _presenter.LoadProductsByCategory();
                }
                else
                {
                    _model.CategoryName = cat.Name;
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }

        private void _cboManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            _model.SelectedManufacturer = (Manufacturer)_cboManufacturer.SelectedItem;
        }

        private void _cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            _model.SelectedUnit = (Unit)_cboUnit.SelectedItem;
        }

        protected Color decideColor(int input)
        {
            if (input <= QUANTITY_ALAR_COLOR)
            {
                return COLOR_ALARM;
            }
            else if (input <= QUANTITY_WARNING_COLOR)
            {
                return COLOR_WARNING;
            }

            return COLOR_DEFAULT;
        }

        #region IView Members


        override public bool HandleCreateNew()
        {
            try
            {
                _presenter.ClearAll();
                _model.IsEditingStatus = true;
                tbBardCode.Focus();
                tbID.Text = "Mã tự động";
                _isCreating = true;

                return true;
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
                return false;
            }
        }

        override public void HandleDelete()
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa mặt hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    StringBuilder errMsg = _presenter.DeleteProduct();

                    if (errMsg.Length != 0)
                    {
                        ShowErrorMessageBox(errMsg.ToString());
                    }
                    else
                    {
                        _presenter.ClearAll();
                    }
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }

        override public bool HandleEdit()
        {
            try
            {
                _model.IsEditingStatus = true;
                _isCreating = false;
                return true;
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
                return false;
            }
        }

        override public void HandlePrint()
        {

        }

        override public bool HandleSaveTask()
        {
            try
            {
                StringBuilder errMsg = _presenter.InsertUpdateProduct(!_isCreating);

                if (errMsg.Length != 0)
                {
                    ShowErrorMessageBox(errMsg.ToString());
                }
                else
                {
                    //_presenter.LoadProductsByCategory();
                    _model.Products = new List<Product>() { _model.Product };
                }

                _model.IsEditingStatus = errMsg.Length != 0;
                return errMsg.Length == 0;
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
                return false;
            }
        }

        override public void HandleCancelTask()
        {
            try
            {
                _model.IsEditingStatus = false;
                _presenter.LoadProductsByCategory();
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }

        override public void HandleSearch()
        {
            try
            {
                ProductFinderView searchForm = new ProductFinderView();
                Product searchResult = null;
                if (searchForm.IsNoResult())
                {
                    if (MessageBox.Show("Sản phẩm không tồn tại. Bạn có muốn thêm mới sản phẩm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        == DialogResult.Yes)
                    {
                        ProductQuickAddView quickAdd = new ProductQuickAddView();
                        quickAdd.ShowDialog();

                        searchResult = quickAdd.AddedProduct;
                    }
                }
                else if (searchForm.GetUniqueItem() != null)
                {
                    searchResult = searchForm.GetUniqueItem();
                }
                else
                {
                    searchForm.ShowDialog();
                    searchResult = searchForm.SelectedProduct;
                }

                if (searchResult != null)
                {
                    _model.Product = searchResult;
                    _model.Products = new List<Product>() { searchResult };
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }

        override public void HandleExport()
        {

        }

        override public void HandleHelp()
        {

        }

        #endregion

        private void _btnUpdatePrice_Click(object sender, EventArgs e)
        {
            try
            {
                using (ProductPriceView priceForm = new ProductPriceView(_model.Product))
                {
                    priceForm.ShowDialog();
                    if (priceForm.ErrorMessage.Length == 0)
                    {
                        _presenter.LoadProductsByCategory();
                    }
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            _ctvCategory.showTree(_presenter.GetCategory());
            _ctvCategory.ExpandAll();
        }

        private void CurrencyText_TextChanged(object sender, EventArgs e)
        {
            base.CurrencyTextBox_TextChanged(sender, e);
        }

        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.NumberOnlyTextBox_KeyPress(sender, e);
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                _presenter.HandleSearchProduct();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppLogger.logError(exc);
            }
        }

        private void tbCost_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCost.Text) && CurrencyUtil.ToDecimal(_model.Cost) != 0 && (string.IsNullOrEmpty(tbPrice.Text) || CurrencyUtil.ToDecimal(_model.Price) == 0))
            {
                _model.Price = CurrencyUtil.ToString(CurrencyUtil.ToDecimal(_model.Cost) * (decimal)1.3);
            }
        }

        private void tbPrice_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPrice.Text) && CurrencyUtil.ToDecimal(_model.Price) != 0 && (string.IsNullOrEmpty(tbCost.Text) || CurrencyUtil.ToDecimal(_model.Cost) == 0))
            {
                _model.Cost = CurrencyUtil.ToString(CurrencyUtil.ToDecimal(_model.Price) / (decimal)1.3);
            }
        }

        private void _btnUpdateInventory_Click(object sender, EventArgs e)
        {

        }
    }
}
