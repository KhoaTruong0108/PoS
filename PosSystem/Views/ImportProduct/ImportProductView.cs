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
    public partial class ImportProductView : GenericView, IImportProductView
    {
        //protected model.ImportProductModel _model = model.ImportProductModel.getInstance();
        //protected controller.ImportProductController _controller = new controller.ImportProductController();
        //protected ManagerDBController _db = ManagerDBController.getInstance();

        protected ImportProductPresenter _presenter;
        protected ImportProductModel _model;
        protected bool _isCreating = false;

        public ImportProductView()
        {
            InitializeComponent();

            _presenter = new ImportProductPresenter(this);
        }



        public void InitView(ImportProductModel model)
        {
            try
            {
                _model = model;
                _dtpToDate.DataBindings.Add("Value", _model, "SearchDateTo", true, DataSourceUpdateMode.OnPropertyChanged);
                _txtDescription.DataBindings.Add("Text", _model, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
                _dtpFromDate.DataBindings.Add("Value", _model, "SearchDateFrom", true, DataSourceUpdateMode.OnPropertyChanged);
                _dtpImportDate.DataBindings.Add("Value", _model, "Date", true, DataSourceUpdateMode.OnPropertyChanged);
                _dgvImportList.DataBindings.Add("DataSource", _model, "Imports", true, DataSourceUpdateMode.OnPropertyChanged);

                _txtDescription.DataBindings.Add("Enabled", _model, "IsEditingStatus");
                _dtpImportDate.DataBindings.Add("Enabled", _model, "IsEditingStatus");
                ucSaleProduct.DataBindings.Add("Enabled", _model, "IsEditingStatus");

                _dtpToDate.DataBindings.Add("Enabled", _model, "IsNotEditingStatus");
                _dgvImportList.DataBindings.Add("Enabled", _model, "IsNotEditingStatus");
                _dtpFromDate.DataBindings.Add("Enabled", _model, "IsNotEditingStatus");
                _btnSearch.DataBindings.Add("Enabled", _model, "IsNotEditingStatus");
                btnExcuteImport.DataBindings.Add("Enabled", _model, "IsNotEditingStatus");

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
                _isCreating = true;
                _model.IsEditingStatus = true;

                (ucSaleProduct as ISaleProductComponent).ClearAll();

                return true;
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
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa lần nhập hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    StringBuilder errMsg = _presenter.DeleteImportProduct();

                    if (errMsg.Length != 0) ShowErrorMessageBox(errMsg.ToString());
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.ToString(), exc);
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
                Order order = ucSaleProduct.GetOrder();

                foreach (var item in order.OrderItems)
                {
                    _model.Import.ImportItems.Add(new ImportItem()
                    {
                        ProductId = item.Product.Id,
                        Quantity = item.Quantity
                    });
                }

                StringBuilder errMsg = _presenter.InsertUpdateImport(!_isCreating);

                if (errMsg.Length != 0)
                {
                    ShowErrorMessageBox(errMsg.ToString());
                }

                _model.IsEditingStatus = errMsg.Length != 0;
                return errMsg.Length == 0;
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.ToString(), exc);
                return false;
            }
        }

        override public void HandleCancelTask()
        {
            try
            {
                _model.IsEditingStatus = false;
                (ucSaleProduct as ISaleProductComponent).ClearAll();
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.ToString(), exc);
            }
        }

        private void _dgvImportList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (_dgvImportList.SelectedRows.Count > 0)
                {
                    Import selectedItem = (Import)_dgvImportList.SelectedRows[0].DataBoundItem;
                    _model.Import = selectedItem;

                    Order order = new Order()
                    {
                        TotalPayment = _model.Import.ImportItems.Sum(i => i.Quantity * i.Product.Price),
                        TotalQuantity = _model.Import.ImportItems.Sum(i => i.Quantity)
                    };

                    foreach (var item in _model.Import.ImportItems)
                    {
                        order.OrderItems.Add(new OrderItem()
                        {
                            Payment = item.Product.Price,
                            Product = item.Product,
                            Quantity = item.Quantity,
                        });
                    }

                    (ucSaleProduct as ISaleProductComponent).LoadOrder(order);
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
                _presenter.HandleSearchImports();
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }

        private void btnExcuteImport_Click(object sender, EventArgs e)
        {
            try
            {
                var error = _presenter.CheckImportData();
                if (error.Length != 0)
                {
                    ShowErrorMessageBox(error.ToString());
                }
                else if (MessageBox.Show("Bạn có muốn nhập hàng không?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (_presenter.ExecuteImporting(_model.Import) == false)
                    {
                        ShowErrorMessageBox("Một hoặc nhiều mặt hàng không tồn tại trong hệ thống.");
                    }
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }


    }
}
