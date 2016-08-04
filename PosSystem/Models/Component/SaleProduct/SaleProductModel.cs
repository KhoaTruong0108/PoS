using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lhk.POS.Core.Domain;
using lhk.POS.Core.Util;

namespace PosSystem.Models.Component.SaleProduct
{
    public class SaleProductModel : INotifyPropertyChanged
    {
        public SaleProductModel(List<ProductSale> productSales)
        {
            _productSales = productSales;

            _product = new ProductSale();
        }

        private bool _isEditing;

        public bool IsEditing
        {
            get { return _isEditing; }
            set { _isEditing = value; InvokePropertyChanged(new PropertyChangedEventArgs("IsEditing")); }
        }

        public bool IsNotEditing
        {
            get { return !_isEditing; }
            set { _isEditing = !value; InvokePropertyChanged(new PropertyChangedEventArgs("IsNotEditing")); }
        }

        private ProductSale _product;

        public ProductSale Product
        {
            get { return _product; }
            set { _product = value; InvokePropertyChanged(new PropertyChangedEventArgs("Product")); }
        }

        public string Barcode
        {
            get { return _product.Barcode; }
            set { _product.Product.Barcode = value; InvokePropertyChanged(new PropertyChangedEventArgs("Barcode")); }
        }

        public string Name
        {
            get { return _product.Name; }
            set { _product.Product.Name = value; InvokePropertyChanged(new PropertyChangedEventArgs("Name")); }
        }

        public string Quantity
        {
            get { return StringUtil.ToEmpty(_product.Quantity); }
            set { _product.Quantity = StringUtil.ToInt(value); InvokePropertyChanged(new PropertyChangedEventArgs("Quantity")); }
        }

        public int _totalQuantity;
        public string TotalQuantity
        {
            get { return StringUtil.ToEmpty(_totalQuantity); }
            set { _totalQuantity = StringUtil.ToInt(value); InvokePropertyChanged(new PropertyChangedEventArgs("TotalQuantity")); }
        }

        public decimal _totalPayment;
        public string TotalPayment
        {
            get { return CurrencyUtil.ToString(_totalPayment); }
            set { _totalPayment = CurrencyUtil.ToDecimal(value); InvokePropertyChanged(new PropertyChangedEventArgs("TotalPayment")); }
        }

        private List<ProductSale> _productSales;
        public List<ProductSale> ProductSales
        {
            get { return _productSales; }
            set { _productSales = value; InvokePropertyChanged(new PropertyChangedEventArgs("ProductSales")); }
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
    public class ProductSale
    {
        public ProductSale()
        {
            Product = new Product();
        }
        [Browsable(false)]
        [DisplayName("Mã mặt hàng")]
        public int ProductId
        {
            get
            {
                return Product.Id;
            }
        }
        [DisplayName("Tên mặt hàng")]
        public string Name
        {
            get
            {
                return Product.Name;
            }
        }

        [DisplayName("Mã vạch")]
        public string Barcode
        {
            get
            {
                return Product.Barcode;
            }
        }

        [DisplayName("Giá bán")]
        public decimal Price
        {
            get
            {
                return Product.Price;
            }
        }

        [DisplayName("Số lượng")]
        public int Quantity { get; set; }

        [Browsable(false)]
        public Product Product { get; set; }

    }
}
