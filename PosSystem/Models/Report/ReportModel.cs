//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : ReportModel.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//

using System.Collections.Generic;
using System.ComponentModel;
using lhk.POS.Core.Domain;
using lhk.POS.Core.Util;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace lhk.POS.Presentation.Models
{
    public class ReportModel : INotifyPropertyChanged
    {

        public ReportModel()
        {
            ReportDateFrom = DateTime.Now.AddDays(-1);
            ReportDateTo = DateTime.Now;
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
                InvokePropertyChanged(new PropertyChangedEventArgs("Revenue"));
                InvokePropertyChanged(new PropertyChangedEventArgs("Expense"));
            }
        }

        private List<OrderItemDisplay> _orderItems;

        public List<OrderItemDisplay> OrderItems
        {
            get { return _orderItems ?? new List<OrderItemDisplay>(); }
            set { _orderItems = value; InvokePropertyChanged(new PropertyChangedEventArgs("OrderItems")); }
        }

        public List<int> Quarters
        {
            get { return new List<int>() { 1, 2, 3, 4 }; }
        }

        private int _quarter;
        public int SelectedQuarter
        {
            get { return _quarter; }
            set { _quarter = value; InvokePropertyChanged(new PropertyChangedEventArgs("SelectedQuarter")); }
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

        private ReportType _reportType;
        public ReportType Type
        {
            get { return _reportType; }
            set
            {
                _reportType = value; InvokePropertyChanged(new PropertyChangedEventArgs("Type"));
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

        public enum ReportType
        {
            Date, Month, Quarter, Year
        }
    }

    public class OrderDisplay
    {
        [Browsable(false)]
        public Order Order { get; set; }
        [Browsable(false)]
        public Customer Customer { get; set; }
        [DisplayName("Ngày mua")]
        public DateTime OrderDate { get { return Order.ChangedDate; } }
        [DisplayName("Khách hàng")]
        public string CustomerName { get { return Order.Customer != null ? Order.Customer.Name : string.Empty; } }
        [DisplayName("Điện Thoại")]
        public string CustomerPhone { get { return Order.Customer != null ? Order.Customer.Phone : string.Empty; } }
        [DisplayName("Số lượng")]
        public int Quantity { get { return Order.TotalQuantity; } }
        [DisplayName("Thành tiền")]
        public decimal Payment { get { return Order.TotalPayment; } }

    }

    public class OrderItemDisplay
    {
        [Browsable(false)]
        public OrderItem OrderItem { get; set; }
        [DisplayName("Mặt hàng")]
        public string ProductName { get; set; }
        [Browsable(false)]
        [DisplayName("Số lượng")]
        public int Quantity { get { return OrderItem.Quantity; } }
        [DisplayName("Vốn")]
        public decimal Cost { get { return OrderItem.Product.Cost; } }
        [DisplayName("Giá")]
        public decimal Payment { get { return OrderItem.Payment; } }

    }
}
