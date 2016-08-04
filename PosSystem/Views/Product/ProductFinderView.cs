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
    public partial class ProductFinderView : GenericView, IProductFinderView
    {
        protected ProductFinderModel _model;
        protected ProductFinderPresenter _presenter;

        public Product SelectedProduct
        {
            get { return _model.Product; }
        }

        public ProductFinderView(string barcode = "", string name = "", bool isSearchBarcode = true)
        {
            InitializeComponent();

            _presenter = new ProductFinderPresenter(this);

            _model.Barcode = barcode;
            _model.Name = name;

            if (isSearchBarcode) tbBarcord.Select();
            else tbName.Select();

            if (string.IsNullOrEmpty(barcode) && string.IsNullOrEmpty(name)) _presenter.HandleSearchProduct();
        }

        public Product GetUniqueItem()
        {
            if (_model.Products.Count == 1)
            {
                return _model.Products.FirstOrDefault();
            }
            return null;
        }

        public bool IsNoResult()
        {
            return _model.Products.Count <= 0;
        }

        public void InitView(ProductFinderModel model)
        {
            _model = model;

            tbBarcord.DataBindings.Add("Text", _model, "Barcode", true, DataSourceUpdateMode.OnPropertyChanged);
            tbName.DataBindings.Add("Text", _model, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            dgvProducts.DataBindings.Add("DataSource", _model, "Products", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SearchProductView_Load(object sender, EventArgs e)
        {
            tbName.Focus();
        }

        private void _btnChoose_Click(object sender, EventArgs e)
        {
            ChooseProduct();
        }

        private void _btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchProductView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    ChooseProduct();
                    break;
                case Keys.Back:
                    tbBarcord.Text = "";
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Up:
                case Keys.Down:
                    this.dgvProducts.Focus();
                    break;
            }
        }

        public void ChooseProduct()
        {
            try
            {
                if (dgvProducts.SelectedRows != null && dgvProducts.SelectedRows.Count > 0)
                {
                    AppLogger.logDebug( "HandleChooseProduct");
                    _model.Product = (Product)dgvProducts.SelectedRows[0].DataBoundItem;
                }
                this.Close();
            }
            catch (Exception exc)
            {
                AppLogger.logError( exc);
            }
        }

        private void _txtBarcord_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.NumberOnlyTextBox_KeyPress(sender, e);
        }

        private void _dgvListProduct_DoubleClick(object sender, EventArgs e)
        {
            ChooseProduct();
        }

        private void ProductFinderView_FormClosed(object sender, FormClosedEventArgs e)
        {
        }


    }
}
