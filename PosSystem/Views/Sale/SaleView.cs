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
    public partial class SaleView : GenericView, ISaleView
    {
        public SaleModel _model;
        public SalePresenter _presenter;
        public SaleView()
        {
            InitializeComponent();

            _presenter = new SalePresenter(this);
        }

        public void InitView(SaleModel model)
        {
            _model = model;

            tbCusAddress.DataBindings.Add("Text", _model, "CusAddress", true, DataSourceUpdateMode.OnPropertyChanged);
            tbCusName.DataBindings.Add("Text", _model, "CusName", true, DataSourceUpdateMode.OnPropertyChanged);
            tbCusPhone.DataBindings.Add("Text", _model, "CusPhone", true, DataSourceUpdateMode.OnPropertyChanged);
            tbCusPurchase.DataBindings.Add("Text", _model, "TotalPurchase", true, DataSourceUpdateMode.OnPropertyChanged);
        }


        protected void HandleSearchProduct()
        {
            try
            {
                //AppLogger.logInfo(this.ToString(), "HandleSearchProduct");
                //ProductFinderView searchComp = new ProductFinderView();
                //searchComp.ShowDialog();
                //BindingProductEntity item = searchComp.SelectedProduct;

                //if (item != null)
                //{
                //    ProductGridEntity product = new ProductGridEntity();
                //    product.Id = item.Id;
                //    product.Barcode = item.Barcode;
                //    product.Name = item.Name;
                //    product.Price = item.Price;
                //    product.Quantity = 1;
                //    product.Total = product.Price * product.Quantity;
                //    product.Discount = 0;

                //    m_pgvListProducts.HandleAddProductItem(product);
                //}
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }

        //protected void HandlePayOut()
        //{
        //    try
        //    {
        //        //AppLogger.logInfo(this.ToString(), "HandlePayOut");
        //        //PaymentDetailView paymentDialog = new PaymentDetailView();
        //        //paymentDialog.setTransactionData(m_pgvListProducts.HandleGetListItem(), m_controller.Buyer.id, m_controller.Buyer.name, m_controller.Buyer.address, m_controller.Buyer.email, m_controller.Buyer.phone,
        //        //                        m_model.NonDiscountPayment, m_model.TotalItem, m_model.TotalDiscount, m_model.TotalPayment);
        //        //paymentDialog.ShowDialog();
        //        //bool isPaid = paymentDialog.IsPaid;

        //        //if (isPaid)
        //        //{
        //        //    m_controller.ClearAll();
        //        //    m_txtCusName.Focus();
        //        //    m_pgvListProducts.ClearAll();
        //        //}
        //    }
        //    catch (Exception exc)
        //    {
        //        AppLogger.logError(exc);
        //    }
        //}

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            try
            {
                AppLogger.logInfo(this.ToString(), "m_btnCreateBill_Click");

                (ucSaleProduct as ISaleProductComponent).ClearAll();
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }

        public void HandlePayout()
        {
            var order = ucSaleProduct.GetOrder();

            PaymentDetailView paymentDialog = new PaymentDetailView(order, _model.Customer);
            paymentDialog.ShowDialog();

            if (paymentDialog.Result == PaymentDetailView.PaymentResult.Payout)
            {
                _presenter.HandlePayOut(order);
            }
            else if (paymentDialog.Result == PaymentDetailView.PaymentResult.PayandPrint)
            {
                _presenter.HandlePayAndPrint(order);
            }

            if (paymentDialog.Result != PaymentDetailView.PaymentResult.Cancel)
            {
                (ucSaleProduct as ISaleProductComponent).ClearAll();
                _presenter.ClearAll();
            }
        }

        private void m_btnPayout_Click(object sender, EventArgs e)
        {
            try
            {
                AppLogger.logInfo(this.ToString(), "m_btnPayout_Click");

                HandlePayout();
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }

        private void SaleView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    (ucSaleProduct as ISaleProductComponent).ClearAll();
                }
                else if (e.KeyCode == Keys.F4)
                {
                    HandleSearchProduct();
                }
                else if (e.KeyCode == Keys.F5)
                {
                    HandlePayout();
                }
                else if (e.KeyCode == Keys.F8)
                {
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }

        private void tbCusNamePhone_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    bool isPhone = (sender as TextBox).Name == tbCusPhone.Name;

                    var searchComp = new CustomerFinderView(_model.CusPhone, _model.CusName, isPhone);

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
                }
                catch (Exception exc)
                {
                    AppLogger.logError(exc);
                }
            }
        }


    }
}
