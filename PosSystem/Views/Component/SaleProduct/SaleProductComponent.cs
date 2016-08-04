using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lhk.POS.Presentation.Presenters;
using PosSystem.Models.Component.SaleProduct;
using lhk.POS.Core.Util;
using lhk.POS.Core.Domain;

namespace lhk.POS.Presentation.Views
{
    public partial class SaleProductComponent : GenericComponent, ISaleProductComponent
    {
        public SaleProductModel _model;
        public SaleProductPresenter _presenter;

        public SaleProductComponent()
        {
            InitializeComponent();

            _presenter = new SaleProductPresenter(this);
        }

        public void InitComponent(SaleProductModel model)
        {
            _model = model;

            tbBarcode.DataBindings.Add("Text", _model, "Barcode", true, DataSourceUpdateMode.OnPropertyChanged);
            tbName.DataBindings.Add("Text", _model, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            tbQuantity.DataBindings.Add("Text", _model, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged);
            tbTotalQuantity.DataBindings.Add("Text", _model, "TotalQuantity", true, DataSourceUpdateMode.OnPropertyChanged);
            tbTotalPayment.DataBindings.Add("Text", _model, "TotalPayment", true, DataSourceUpdateMode.OnPropertyChanged);

            dgvProducts.DataBindings.Add("DataSource", _model, "ProductSales", true, DataSourceUpdateMode.OnPropertyChanged);

            tbBarcode.DataBindings.Add("Enabled", _model, "IsEditing", true, DataSourceUpdateMode.OnPropertyChanged);
            tbName.DataBindings.Add("Enabled", _model, "IsEditing", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public void ClearAll()
        {
            _presenter.ClearAll();
            _presenter.AddNew();
            tbBarcode.Focus();
        }

        public Order GetOrder()
        {
            var order = new Order();
            var orderItems = new List<OrderItem>();

            order.TotalPayment = _model._totalPayment;
            order.TotalQuantity = _model._totalQuantity;
            //order.CustomerId = -1;
            order.ChangedBy = SystemParam.CurrentUser.Id;

            foreach (var item in _model.ProductSales)
            {
                OrderItem orderItem = new OrderItem();

                orderItem.Payment = item.Price;
                orderItem.ProductId = item.ProductId;
                orderItem.Quantity = item.Quantity;

                orderItems.Add(orderItem);
            }
            order.OrderItems = orderItems;

            return order;
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.NumberOnlyTextBox_KeyPress(sender, e);
        }

        private void tbBarcodeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                try
                {
                    bool isBarcode = (sender as TextBox).Name == tbBarcode.Name;

                    ProductFinderView searchComp = isBarcode ? new ProductFinderView(barcode: _model.Barcode, isSearchBarcode: true) : new ProductFinderView(name: _model.Name, isSearchBarcode: false);

                    Product searchResult = null;

                    if (searchComp.IsNoResult())
                    {
                        if (MessageBox.Show("Sản phẩm không tồn tại. Bạn có muốn thêm mới sản phẩm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                            == DialogResult.Yes)
                        {
                            ProductQuickAddView quickAdd = new ProductQuickAddView(_model.Barcode ?? "", _model.Name ?? "");
                            quickAdd.ShowDialog();

                            searchResult = quickAdd.AddedProduct;
                        }
                    }
                    else if (searchComp.GetUniqueItem() != null)
                    {
                        searchResult = searchComp.GetUniqueItem();
                    }
                    else
                    {
                        searchComp.ShowDialog();
                        searchResult = searchComp.SelectedProduct;
                    }

                    if (new Product().Id.Equals(searchResult.Id) == false)
                    {
                        _presenter.AddItem(searchResult);

                        _presenter.AddNew();

                        dgvProducts.Refresh();

                        tbBarcode.Focus();
                    }
                }
                catch (Exception exc)
                {
                    AppLogger.logError(exc);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _presenter.DeleteItem();

            btnAdd_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _presenter.AddNew();
            tbBarcode.Focus();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0 && dgvProducts.SelectedRows[0].Index > 0)
            {
                int index = dgvProducts.SelectedRows[0].Index - 1;
                dgvProducts.Rows[index + 1].Selected = false;
                dgvProducts.Rows[index].Selected = true;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0 && dgvProducts.SelectedRows[0].Index < dgvProducts.Rows.Count - 1)
            {
                int index = dgvProducts.SelectedRows[0].Index + 1;
                dgvProducts.Rows[index - 1].Selected = false;
                dgvProducts.Rows[index].Selected = true;
            }
        }

        private void tbQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnAdd_Click(sender, e);
                }
                else
                {
                    _presenter.UpdateQuantity();

                    dgvProducts.Refresh();
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }

        private void dgvProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvProducts.SelectedRows.Count > 0)
                {
                    ProductSale selectedItem = (ProductSale)dgvProducts.SelectedRows[0].DataBoundItem;
                    _model.Product = selectedItem;

                    _model.IsEditing = false;
                    tbQuantity.Select();
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }

        private void dgvProducts_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.ValueType == typeof(decimal))
                e.Column.DefaultCellStyle.Format = "N3";
        }

        public void LoadOrder(Order order)
        {
            _model.TotalPayment = order.TotalPayment.ToString();
            _model.TotalQuantity = order.TotalQuantity.ToString();
            //order.CustomerId = -1;
            order.ChangedBy = SystemParam.CurrentUser.Id;

            var temp = new List<ProductSale>();
            foreach (var item in order.OrderItems)
            {
                temp.Add(new ProductSale()
                {
                    Product = item.Product,
                    Quantity = item.Quantity
                });
            }

            _model.ProductSales = temp;
        }
    }
}
