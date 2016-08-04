using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lhk.POS.Common.Business;
using Nop.Core.Infrastructure;
using PosSystem.Depency;
using lhk.POS.Data;
using lhk.POS.Core.Domain;
using lhk.POS.Presentation;
using lhk.POS.Core.Util;

namespace PosSystem.Views.Component.InputProduct
{
    public partial class FastInputProducts : UserControl
    {
        protected ProductBusiness _productBusiness;
        protected ManufacturerBusiness _manufacturerBusiness;
        protected UnitBusiness _unitBusiness;

        protected IEnumerable<Unit> _units;
        protected IEnumerable<Manufacturer> _manufacturers;

        public FastInputProducts()
        {
            _productBusiness = new ProductBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<Product>>());
            _unitBusiness = new UnitBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<Unit>>());
            _manufacturerBusiness = new ManufacturerBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<Manufacturer>>());

            InitializeComponent();

            _units = _unitBusiness.GetAll();
            _manufacturers = _manufacturerBusiness.GetAll();

            _units.ToList().ForEach(u => (dgvProducts.Columns["colUnit"] as DataGridViewComboBoxColumn).Items.Add(u));
            (dgvProducts.Columns["colUnit"] as DataGridViewComboBoxColumn).DisplayMember = "Name";

            _manufacturers.ToList().ForEach(u => (dgvProducts.Columns["colManufacturer"] as DataGridViewComboBoxColumn).Items.Add(u));
            (dgvProducts.Columns["colManufacturer"] as DataGridViewComboBoxColumn).DisplayMember = "Name";
        }

        private void dgvProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.Columns[e.ColumnIndex].Name == "colBarcode")
            {
                var barcode = dgvProducts.CurrentCell.Value.ToString().Trim();

                if (string.IsNullOrWhiteSpace(barcode)) return;

                if (_productBusiness.GetAll().Any(i => i.Barcode == barcode))
                {
                    MessageBox.Show("Mã vạch này đã được sử dụng");
                    dgvProducts.CurrentCell.Value = string.Empty;
                    dgvProducts.BeginEdit(true);
                }
            }
            else if (dgvProducts.Columns[e.ColumnIndex].Name == "colBarcode")
            {

            }
        }

        private void dgvProducts_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var lastRow = dgvProducts.Rows[e.RowIndex];

            lastRow.Cells["colStock"].Value = 10;
        }

        private void dgvProducts_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvProducts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvProducts.CurrentCell.ColumnIndex == 2
                || dgvProducts.CurrentCell.ColumnIndex == 3
                || dgvProducts.CurrentCell.ColumnIndex == 4)
            {
                e.Control.KeyPress += new KeyPressEventHandler(dgvProducts_KeyPress);
                e.Control.TextChanged += new System.EventHandler(CurrencyTextBox_TextChanged);
            }
        }

        private void dgvProducts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        protected virtual void CurrencyTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox currencyTextBox = (TextBox)sender;
            decimal value = 0;
            int pos = 0;

            if (string.IsNullOrWhiteSpace(currencyTextBox.Text))
            {
                currencyTextBox.Text = "0";
            }
            else if (decimal.TryParse(currencyTextBox.Text, out value))
            {
                pos = CurrencyUtil.ToString(value).Length;
                currencyTextBox.Text = CurrencyUtil.ToString(value);
                currencyTextBox.SelectionStart = pos;
            }
        }


        public IEnumerable<Product> GetInputingProduct()
        {
            List<Product> products = new List<Product>();

            foreach(DataGridViewRow row in dgvProducts.Rows)
            {
                Product product = new Product()
                {
                    
                };
            }

            return products;
        }
    }
}
