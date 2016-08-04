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
    public partial class ProductPriceView : GenericView, IProductPriceView
    {
        private string _errorMessage = string.Empty;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }

        protected ProductPriceModel _model;
        protected ProductPricePresenter _presenter;

        public ProductPriceView(Product product)
        {
            InitializeComponent();

            _presenter = new ProductPricePresenter(this, product);
        }


        public void InitView(ProductPriceModel model)
        {
            _model = model;

            _txtBardCode.DataBindings.Add("Text", _model, "Barcode", true, DataSourceUpdateMode.OnPropertyChanged);
            _txtCurrentImportPrice.DataBindings.Add("Text", _model, "Cost", true, DataSourceUpdateMode.OnPropertyChanged);
            _txtCurrentSalePrice.DataBindings.Add("Text", _model, "Price", true, DataSourceUpdateMode.OnPropertyChanged);
            _txtName.DataBindings.Add("Text", _model, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            _txtSalePrice.DataBindings.Add("Text", _model, "NewPrice", true, DataSourceUpdateMode.OnPropertyChanged);
            _txtImportPrice.DataBindings.Add("Text", _model, "NewCost", true, DataSourceUpdateMode.OnPropertyChanged);
            _txtReason.DataBindings.Add("Text", _model, "Reason", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void _btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                AppLogger.logInfo(" _btnOk_Click");

                _errorMessage = _presenter.UpdatePrice().ToString();

                if (_errorMessage.Length != 0)
                {
                    ShowErrorMessageBox(_errorMessage);
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

        private void _txtImportPrice_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_txtImportPrice.Text) && CurrencyUtil.ToDecimal(_model.NewCost) != 0
                && (string.IsNullOrEmpty(_txtSalePrice.Text) || CurrencyUtil.ToDecimal(_model.NewPrice) == 0))
            {
                _model.NewPrice = CurrencyUtil.ToString(CurrencyUtil.ToDecimal(_model.NewCost) * (decimal)1.3);
            }
        }

        private void _txtSalePrice_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_txtSalePrice.Text) && CurrencyUtil.ToDecimal(_model.NewPrice) != 0 && (string.IsNullOrEmpty(_txtImportPrice.Text) || CurrencyUtil.ToDecimal(_model.NewCost) == 0))
            {
                _model.NewCost = CurrencyUtil.ToString(CurrencyUtil.ToDecimal(_model.NewPrice) / (decimal)1.3);
            }
        }

        
    }
}
