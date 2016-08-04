//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : CustomerModel.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System.ComponentModel;
using lhk.POS.Core.Domain;
using lhk.POS.Core.Util;
using System.Collections.Generic;
using System.Linq;
using System;

namespace lhk.POS.Presentation.Models{
	public class CustomerModel : INotifyPropertyChanged
    {
        private Customer _customer;

        public CustomerModel(Customer customer)
        {
            _customer = customer;
            ReportDateFrom = DateTime.Now.AddDays(-1);
            ReportDateTo = DateTime.Now;
        }

        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        public string Email
        {
            get { return _customer.Email; }
            set { _customer.Email = value; InvokePropertyChanged(new PropertyChangedEventArgs("Email")); }
        }

        public string Phone
        {
            get { return _customer.Phone; }
            set { _customer.Phone = value; InvokePropertyChanged(new PropertyChangedEventArgs("Phone")); }
        }

        public string Name
        {
            get { return _customer.Name; }
            set { _customer.Name = value; InvokePropertyChanged(new PropertyChangedEventArgs("Name")); }
        }

        public string Address
        {
            get { return _customer.Address; }
            set { _customer.Address = value; InvokePropertyChanged(new PropertyChangedEventArgs("Address")); }
        }

        public string Purchase
        {
            get { return CurrencyUtil.ToString(_customer.Purchase); }
            set { _customer.Purchase = CurrencyUtil.ToDecimal(value); InvokePropertyChanged(new PropertyChangedEventArgs("Purchase")); }
        }

        public string TotalPurchase
        {
            get { return CurrencyUtil.ToString(_customer.TotalPurchase); }
            set { _customer.TotalPurchase = CurrencyUtil.ToDecimal(value); InvokePropertyChanged(new PropertyChangedEventArgs("TotalPurchase")); }
        }


        public OrderDisplay SelectedOrder { get; set; }
        public List<Order> Orders { get; set; }

        private List<OrderDisplay> _orderDisplay;
        public List<OrderDisplay> OrderDisplay
        {
            get { return _orderDisplay ?? new List<OrderDisplay>(); }
            set
            {
                _orderDisplay = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("OrderDisplay"));
            }
        }

        private List<OrderItemDisplay> _orderItems;

        public List<OrderItemDisplay> OrderItems
        {
            get { return _orderItems ?? new List<OrderItemDisplay>(); }
            set { _orderItems = value; InvokePropertyChanged(new PropertyChangedEventArgs("OrderItems")); }
        }

        public string Revenue
        {
            get { return CurrencyUtil.ToString(OrderDisplay.Sum(i => i.Order.OrderItems.Sum(oi => oi.Payment * oi.Quantity))); }
        }

        public string Expense
        {
            get { return CurrencyUtil.ToString(OrderDisplay.Sum(i => i.Order.OrderItems.Sum(oi => oi.Product.Cost * oi.Quantity))); }
        }

        public string Profit
        {
            get
            {
                return CurrencyUtil.ToString(OrderDisplay.Sum(i => i.Order.OrderItems.Sum(oi => oi.Payment * oi.Quantity))
                    - OrderDisplay.Sum(i => i.Order.OrderItems.Sum(oi => oi.Product.Cost * oi.Quantity)));
            }
        }

        public string SubPayment
        {
            get { return CurrencyUtil.ToString(_orderItems == null ? 0 : _orderItems.Sum(i => i.Payment * i.Quantity)); }
        }

        public string SubCost
        {
            get { return CurrencyUtil.ToString(_orderItems == null ? 0 : _orderItems.Sum(i => i.Cost)); }
        }

        private bool _isEditingStatus = false;

        public bool IsEditingStatus
        {
            get { return _isEditingStatus; }
            set { _isEditingStatus = value; InvokePropertyChanged(new PropertyChangedEventArgs("IsEditingStatus")); }
        }
        public bool IsNotEditingStatus
        {
            get { return !_isEditingStatus; }
            set { InvokePropertyChanged(new PropertyChangedEventArgs("IsNotEditingStatus")); }
        }
        #region Search Section
        string _searchName;
        public string SearchName
        {
            get { return _searchName; }
            set
            {
                _searchName = value; InvokePropertyChanged(new PropertyChangedEventArgs("SearchName"));
            }
        }
        string _searchPhone;
        public string SearchPhone
        {
            get { return _searchPhone; }
            set
            {
                _searchPhone = value; InvokePropertyChanged(new PropertyChangedEventArgs("SearchPhone"));
            }
        }
        DateTime _reportDateFrom;
        public DateTime ReportDateFrom
        {
            get { return _reportDateFrom; }
            set
            {
                _reportDateFrom = value; InvokePropertyChanged(new PropertyChangedEventArgs("ReportDateFrom"));
            }
        }

        private DateTime _reportDateTo;
        public DateTime ReportDateTo
        {
            get { return _reportDateTo; }
            set
            {
                _reportDateTo = value; InvokePropertyChanged(new PropertyChangedEventArgs("ReportDateTo"));
            }
        }


        #endregion
        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }

        #endregion
	}
}
