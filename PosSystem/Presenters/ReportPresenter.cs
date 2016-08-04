//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : ProductPresenter.cs                  //
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
using Utility.Password;
using System.Data.Entity.Core.Objects;

namespace lhk.POS.Presentation.Presenters
{
    public class ReportPresenter
    {
        private ReportModel _model;
        private IReportView _view;

        private ReportBusiness _business;
        private ProductBusiness _businessProduct;
        private CustomerBusiness _businessCustomer;

        public ReportPresenter(IReportView view)
        {
            _business = new ReportBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<Order>>());
            _businessProduct = new ProductBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<Product>>());
            _businessCustomer = new CustomerBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<Customer>>());

            _view = view;

            _model = new ReportModel();
            _view.InitView(_model);
        }

        public void ExecuteReport()
        {
            try
            {
                var fromDate = _model.Type == ReportModel.ReportType.Date ? _model.ReportDateFrom.AddHours(-_model.ReportDateFrom.Hour) :
                    _model.Type == ReportModel.ReportType.Month ? _model.ReportDateFrom.AddDays(-_model.ReportDateFrom.Day).AddHours(-_model.ReportDateFrom.Hour) :
                    _model.Type == ReportModel.ReportType.Year ? new DateTime(DateTime.Now.Year, 1, 1) :
                    new DateTime(DateTime.Now.Year, (_model.SelectedQuarter - 1) * 3 + 1, 1);

                var toDate = _model.Type == ReportModel.ReportType.Date ? _model.ReportDateTo.AddDays(1).AddHours(-_model.ReportDateTo.Hour - 1) :
                   _model.Type == ReportModel.ReportType.Month ? _model.ReportDateTo.AddDays(1).AddMonths(1).AddDays(-_model.ReportDateTo.Day).AddHours(-_model.ReportDateTo.Hour - 1) :
                   _model.Type == ReportModel.ReportType.Year ? new DateTime(DateTime.Now.Year, 12, 31) :
                   new DateTime(DateTime.Now.Year, _model.SelectedQuarter * 3, 1);

                var orders = _business.GetOrderByDate(fromDate, toDate).ToList();
                _model.OrderDisplay = (from order in orders
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

        public void LoadOrderItem()
        {
            _model.OrderItems = _model.SelectedOrder == null ? new List<OrderItemDisplay>() :
                (from item in _model.SelectedOrder.Order.OrderItems
                 select new OrderItemDisplay
                 {
                     OrderItem = item,
                     ProductName = item.Product.Name
                 }).ToList();

        }

        public StringBuilder CheckData()
        {
            StringBuilder errorMessage = new StringBuilder();


            return errorMessage;
        }


        public void ClearAll()
        {

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
    }
}
