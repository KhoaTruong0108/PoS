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
    public partial class ProductQuickAddView : GenericView, IProductView
    {

        protected ProductModel _model;
        protected ProductPresenter _presenter;

        public ProductQuickAddView(string rawBarcode = "", string rawName = "")
        {
            InitializeComponent();

            _presenter = new ProductPresenter(this);

            _model.Barcode = rawBarcode;
            _model.Name = rawName;
        }

        public Product AddedProduct
        {
            get { return _model.Product; }
        }
        public void InitView(ProductModel model)
        {
            _model = model;

            tbBarcode.DataBindings.Add("Text", _model, "Barcode", true, DataSourceUpdateMode.OnPropertyChanged);
            tbName.DataBindings.Add("Text", _model, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            tbPrice.DataBindings.Add("Text", _model, "Price", true, DataSourceUpdateMode.OnPropertyChanged);
            tbCost.DataBindings.Add("Text", _model, "Cost", true, DataSourceUpdateMode.OnPropertyChanged);

            cboUnit.DataBindings.Add("DataSource", _model, "Uints", true, DataSourceUpdateMode.OnPropertyChanged);
            cboUnit.DataBindings.Add("SelectedItem", _model, "SelectedUnit", true, DataSourceUpdateMode.OnPropertyChanged);
            cboManufacturer.DataBindings.Add("DataSource", _model, "Manufacturers", true, DataSourceUpdateMode.OnPropertyChanged);
            cboManufacturer.DataBindings.Add("SelectedItem", _model, "SelectedManufacturer", true, DataSourceUpdateMode.OnPropertyChanged);

            cboUnit.DisplayMember = "Name";
            cboUnit.ValueMember = "Id";
            cboManufacturer.DisplayMember = "name";
            cboManufacturer.ValueMember = "id";
        }

        private void _btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                AppLogger.logInfo(" _btnOk_Click");

                var errorMessage = _presenter.HandleQuickAddProduct().ToString();

                if (errorMessage.Length != 0)
                {
                    ShowErrorMessageBox(errorMessage);
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc.Message);
            }
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            _model.Product = null;
            this.Close();
        }

        private void _txtImportPrice_TextChanged(object sender, EventArgs e)
        {
            base.CurrencyTextBox_TextChanged(sender, e);
        }

        private void _txtImportPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.NumberOnlyTextBox_KeyPress(sender, e);
        }

        private void tbCost_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCost.Text) && CurrencyUtil.ToDecimal(_model.Price) == 0 && (string.IsNullOrEmpty(tbPrice.Text) || CurrencyUtil.ToDecimal(_model.Price) == 0))
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

        
    }
}
