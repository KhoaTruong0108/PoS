using lhk.POS.Core.Domain;
using lhk.POS.Core.Util;
using lhk.POS.Presentation.Models;
using lhk.POS.Presentation.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace lhk.POS.Presentation.Views
{
    public partial class CustomerView : GenericView, ICustomerView
    {
        protected CustomerPresenter _presenter;
        protected CustomerModel _model;
        protected bool _isCreating = false;

        public CustomerView()
        {
            InitializeComponent();

            _presenter = new CustomerPresenter(this);
        }

        public void InitView(CustomerModel model)
        {
            try
            {
                _model = model;

                tbSearchName.DataBindings.Add("Text", _model, "SearchName", true, DataSourceUpdateMode.OnPropertyChanged);
                tbSearchPhone.DataBindings.Add("Text", _model, "SearchPhone", true, DataSourceUpdateMode.OnPropertyChanged);
                tbName.DataBindings.Add("Text", _model, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
                tbEmail.DataBindings.Add("Text", _model, "Email", true, DataSourceUpdateMode.OnPropertyChanged);
                tbAddress.DataBindings.Add("Text", _model, "Address", true, DataSourceUpdateMode.OnPropertyChanged);
                tbPhone.DataBindings.Add("Text", _model, "Phone", true, DataSourceUpdateMode.OnPropertyChanged);
                tbRevenue.DataBindings.Add("Text", _model, "Revenue", true, DataSourceUpdateMode.OnPropertyChanged);
                tbProfit.DataBindings.Add("Text", _model, "Profit", true, DataSourceUpdateMode.OnPropertyChanged);
                tbSubPayment.DataBindings.Add("Text", _model, "SubPayment", true, DataSourceUpdateMode.OnPropertyChanged);
                tbSubQuantity.DataBindings.Add("Text", _model, "SubCost", true, DataSourceUpdateMode.OnPropertyChanged);

                //tbPhone.DataBindings.Add("Enabled", _model, "IsEditingStatus");

                dtpFromDate.DataBindings.Add("Value", _model, "ReportDateFrom", true, DataSourceUpdateMode.OnPropertyChanged);
                dtpToDate.DataBindings.Add("Value", _model, "ReportDateTo", true, DataSourceUpdateMode.OnPropertyChanged);
                dgvOrders.DataBindings.Add("DataSource", _model, "OrderDisplay", true, DataSourceUpdateMode.OnPropertyChanged);
                dgvOrderItem.DataBindings.Add("DataSource", _model, "OrderItems", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.ToString(), exc);
            }
        }


        #region IView Members

        override public bool HandleCreateNew()
        {
            try
            {
                _presenter.ClearAll();
                (new CustomerQuickAddView()).ShowDialog();
                return false;
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.ToString(), exc);
                return false;
            }
        }

        override public void HandleDelete()
        {
            try
            {
                //TODO: this block will be activate after make sure there's no errors in relationship with Order,Product

                //DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //if (result == System.Windows.Forms.DialogResult.Yes)
                //{
                //    StringBuilder errMsg = _presenter.DeleteCustomer();

                //    if (errMsg.Length != 0)
                //    {
                //        ShowErrorMessageBox(errMsg.ToString());
                //    }
                //    else
                //    {
                //        _presenter.ClearAll();
                //    }
                //}
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }
        private void _dgvImportList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrders.SelectedRows.Count > 0)
                {
                    _model.SelectedOrder = (OrderDisplay)dgvOrders.SelectedRows[0].DataBoundItem;

                    _presenter.LoadOrderDetail(_model.SelectedOrder);
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }
        #endregion

        private void _btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var searchComp = new CustomerFinderView(_model.SearchPhone,_model.SearchName);

                Customer searchResult = null;
                if (searchComp.IsNoResult())
                {
                    if (MessageBox.Show("Khách hàng không tồn tại. Bạn có muốn thêm mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        == DialogResult.Yes)
                    {
                        CustomerQuickAddView quickAdd = new CustomerQuickAddView();
                        quickAdd.ShowDialog();

                        searchResult = quickAdd.AddedCustomer;
                    }
                }
                else if (searchComp.getUniqueItem() != null)
                {
                    searchResult = searchComp.getUniqueItem();
                }
                else
                {
                    searchComp.ShowDialog();
                    searchResult = searchComp.SelectedCustomer;
                }

                _model.Customer = searchResult != null ? searchResult : new Customer();
                _presenter.ExecuteReport();
                _model.SearchName = string.Empty;
                _model.SearchPhone = string.Empty;


            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
