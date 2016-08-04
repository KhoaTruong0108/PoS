//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : CustomerPresenter.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lhk.POS.Common.Business;
using lhk.POS.Core;
using lhk.POS.Core.Domain;
using lhk.POS.Core.Util;
using lhk.POS.Data;
using lhk.POS.Presentation.Models;
using lhk.POS.Presentation.Views;
using Nop.Core.Infrastructure;
using PosSystem.Depency;

namespace lhk.POS.Presentation.Presenters
{
    public class CustomerPresenter
    {
        private CustomerModel _model;
        private ICustomerView _view;

        private CustomerBusiness _business;
        private ReportBusiness _businessOrder;

        public CustomerPresenter(ICustomerView view)
        {
            _businessOrder = new ReportBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<Order>>());
            _business = new CustomerBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<Customer>>());
            _view = view;

            Customer Customer = new Customer();

            _model = new CustomerModel(new Customer());
            _view.InitView(_model);
        }

        public StringBuilder checkInputData()
        {
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_model.Name))
            {
                errorMessage.AppendLine(Constants.Messages.PRODUCT_NAME_NOT_EMPTY);
            }
            if (string.IsNullOrWhiteSpace(_model.Phone))
            {
                errorMessage.AppendLine(Constants.Messages.PRODUCT_BARCODE_NOT_EMPTY);
            }

            return errorMessage;
        }

       
        public StringBuilder InsertUpdateCustomer(bool isUpdating)
        {
            StringBuilder errorMessage = new StringBuilder();
            try
            {
                AppLogger.logInfo("InsertUpdateCustomer");

                errorMessage.Append(checkInputData());

                if (errorMessage.Length != 0)
                {
                    return errorMessage;
                }

                _model.Customer.ChangedBy = SystemParam.CurrentUser.Id;

                if (isUpdating)
                {
                    _business.Update(_model.Customer);
                }
                else
                {
                    _business.Insert(_model.Customer);
                }

            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
                errorMessage.AppendLine(exc.Message);
            }
            return errorMessage;
        }
        public void ExecuteReport()
        {
            try
            {

                var customer = _business.GetById(_model.Customer.Id);
                if (customer == null) return;

                var fromDate = _model.ReportDateFrom.AddHours(-_model.ReportDateFrom.Hour);

                var toDate = _model.ReportDateTo.AddDays(1).AddHours(-_model.ReportDateTo.Hour - 1);

                var orders = _businessOrder.GetOrderByDate(fromDate, toDate).ToList();
                _model.OrderDisplay = (from order in orders
                                       where order.CustomerId.HasValue && order.CustomerId.Equals(customer.Id)
                                       select new OrderDisplay
                                       {
                                           Order = order,
                                           Customer = order.Customer
                                       }).ToList();
            }
            catch (Exception e)
            {
                AppLogger.logError(e);
            }
        }

        internal void LoadOrderDetail(OrderDisplay order)
        {

            var items = new List<OrderItemDisplay>();
            foreach (var i in _model.SelectedOrder.Order.OrderItems)
            {
                items.Add(new OrderItemDisplay()
                {
                    OrderItem = i,
                    ProductName = i.Product.Name
                });
            }
            _model.OrderItems = items;
        }
        public void ClearAll()
        {

        }

    }
}
