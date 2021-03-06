//
//
//  Generated by StarUML(tm) C# Add-In
//
//  @ Project : @ ShoppingCentral
//  @ File Name : PriceModel.cs
//  @ Date : 2/21/2013
//  @ Author :  kenjuzi
//
//
using System.Collections.Generic;
using System.ComponentModel;
using lhk.POS.Core.Domain;
using lhk.POS.Core.Util;

namespace lhk.POS.Presentation.Models
{
    public class ProductPriceModel : INotifyPropertyChanged
    {
        public ProductPriceModel(Product product)
        {
            _product = product;
        }

        private Product _product;

        public Product Product
        {
            get { return _product; }
            set { _product = value; }
        }

        public string Id
        {
            get { return _product.Id.ToString(); }
            set
            {
                _product.Id = StringUtil.ToInt(value); InvokePropertyChanged(new PropertyChangedEventArgs("Id"));
            }
        }

        public string Barcode
        {
            get { return _product.Barcode; }
            set { _product.Barcode = value; InvokePropertyChanged(new PropertyChangedEventArgs("Barcode")); }
        }

        public string Name
        {
            get { return _product.Name; }
            set { _product.Name = value; InvokePropertyChanged(new PropertyChangedEventArgs("Name")); }
        }

        public decimal _newCost;
        public string NewCost
        {
            get { return CurrencyUtil.ToString(_newCost); }
            set { _newCost = CurrencyUtil.ToDecimal(value); InvokePropertyChanged(new PropertyChangedEventArgs("NewCost")); }
        }

        public string Cost
        {
            get { return CurrencyUtil.ToString(_product.Cost); }
            set { _product.Cost = CurrencyUtil.ToDecimal(value); InvokePropertyChanged(new PropertyChangedEventArgs("Cost")); }
        }

        public decimal _newPrice;
        public string NewPrice
        {
            get { return CurrencyUtil.ToString(_newPrice); }
            set { _newPrice = CurrencyUtil.ToDecimal(value); InvokePropertyChanged(new PropertyChangedEventArgs("NewPrice")); }
        }

        public string Price
        {
            get { return CurrencyUtil.ToString(_product.Price); }
            set { _product.Price = CurrencyUtil.ToDecimal(value); InvokePropertyChanged(new PropertyChangedEventArgs("Price")); }
        }

        private string _reason;

        public string Reason
        {
            get { return _reason; }
            set { _reason = value; InvokePropertyChanged(new PropertyChangedEventArgs("Reason")); }
        }
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
