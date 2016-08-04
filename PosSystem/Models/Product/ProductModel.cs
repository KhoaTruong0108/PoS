//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : ProductModel.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System.Collections.Generic;
using System.ComponentModel;
using lhk.POS.Core.Domain;
using lhk.POS.Core.Util;

namespace lhk.POS.Presentation.Models
{
    public class ProductModel : INotifyPropertyChanged
    {
        private Product _product;

        public ProductModel(Product product, List<Unit> units, List<Manufacturer> manufacturers)
        {
            _product = product;
            _uints = units;
            _manufacturers = manufacturers;
        }

        public Product Product
        {
            get { return _product; }
            set { _product = value; }
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

        public string Price
        {
            get { return CurrencyUtil.ToString(_product.Price); }
            set { _product.Price = CurrencyUtil.ToDecimal(value); InvokePropertyChanged(new PropertyChangedEventArgs("Price")); }
        }

        public string Cost
        {
            get { return CurrencyUtil.ToString(_product.Cost); }
            set { _product.Cost = CurrencyUtil.ToDecimal(value); InvokePropertyChanged(new PropertyChangedEventArgs("Cost")); }
        }


        public string StockQuantity
        {
            get { return _product.StockQuantity.ToString(); }
            set { _product.StockQuantity = StringUtil.ToInt(value); InvokePropertyChanged(new PropertyChangedEventArgs("StockQuantity")); }
        }


        public string Description
        {
            get { return _product.Description; }
            set { _product.Description = value; InvokePropertyChanged(new PropertyChangedEventArgs("Description")); }
        }
        private List<Product> _products;

        public List<Product> Products
        {
            get { return _products; }
            set { _products = value; InvokePropertyChanged(new PropertyChangedEventArgs("Products")); }
        }

        private List<Unit> _uints;
        public List<Unit> Uints
        {
            get { return _uints; }
            set { _uints = value; InvokePropertyChanged(new PropertyChangedEventArgs("Uints")); }
        }

        private List<Manufacturer> _manufacturers;

        public List<Manufacturer> Manufacturers
        {
            get { return _manufacturers; }
            set { _manufacturers = value; InvokePropertyChanged(new PropertyChangedEventArgs("Manufacturers")); }
        }

        private Category _selectedCategory;

        public Category SelectedCategory
        {
            get { return _selectedCategory; }
            set { _selectedCategory = value; }
        }
        private Manufacturer _selectedManufacturer;

        public Manufacturer SelectedManufacturer
        {
            get { return _selectedManufacturer; }
            set { _selectedManufacturer = value; }
        }

        private Unit _selectedUnit;

        public Unit SelectedUnit
        {
            get { return _selectedUnit; }
            set { _selectedUnit = value; InvokePropertyChanged(new PropertyChangedEventArgs("SelectedUnit")); }
        }


        public string ManufacturerName
        {
            get { return _selectedManufacturer != null ? _selectedManufacturer.Name : ""; }
            set { if (_selectedManufacturer != null) _selectedCategory.Name = value; InvokePropertyChanged(new PropertyChangedEventArgs("ManufacturerName")); }
        }

        public string UnitName
        {
            get { return _selectedUnit != null ? _selectedUnit.Name : ""; }
            set { if (_selectedUnit != null) _selectedUnit.Name = value; InvokePropertyChanged(new PropertyChangedEventArgs("UnitName")); }
        }

        public string CategoryName
        {
            get { return Product.Category != null ? Product.Category.Name : _selectedCategory!= null ? _selectedCategory.Name : ""; }
            set { if(_selectedCategory!= null) _selectedCategory.Name = value; InvokePropertyChanged(new PropertyChangedEventArgs("CategoryName")); }
        }

        #region Search Section
        private string _searchBarcode;

        public string SearchBarcode
        {
            get { return _searchBarcode; }
            set { _searchBarcode = value; InvokePropertyChanged(new PropertyChangedEventArgs("SearchBarcode")); }
        }
        private string _searchName;

        public string SearchName
        {
            get { return _searchName; }
            set { _searchName = value; InvokePropertyChanged(new PropertyChangedEventArgs("SearchName")); }
        }
        private string _searchPriceFrom;

        public string SearchPriceFrom
        {
            get { return _searchPriceFrom; }
            set { _searchPriceFrom = value; InvokePropertyChanged(new PropertyChangedEventArgs("SearchPriceFrom")); }
        }
        private string _searchPriceTo;

        public string SearchPriceTo
        {
            get { return _searchPriceTo; }
            set { _searchPriceTo = value; InvokePropertyChanged(new PropertyChangedEventArgs("SearchPriceTo")); }
        }

        private string _searchStockFrom;
        public string SearchStockFrom
        {
            get { return _searchStockFrom; }
            set { _searchStockFrom = value; InvokePropertyChanged(new PropertyChangedEventArgs("SearchStockFrom")); }
        }

        private string _searchStockTo;
        public string SearchStockTo
        {
            get { return _searchStockTo; }
            set { _searchStockTo = value; InvokePropertyChanged(new PropertyChangedEventArgs("SearchStockTo")); }
        }

        private bool _IsSearchBarcode;

        public bool IsSearchBarcode
        {
            get { return _IsSearchBarcode; }
            set { _IsSearchBarcode = value; InvokePropertyChanged(new PropertyChangedEventArgs("IsSearchBarcode")); }
        }
        private bool _IsSearchName;

        public bool IsSearchName
        {
            get { return _IsSearchName; }
            set { _IsSearchName = value; InvokePropertyChanged(new PropertyChangedEventArgs("IsSearchName")); }
        }
        private bool _IsSearchPriceFrom;

        public bool IsSearchPriceFrom
        {
            get { return _IsSearchPriceFrom; }
            set { _IsSearchPriceFrom = value; InvokePropertyChanged(new PropertyChangedEventArgs("IsSearchPriceFrom")); }
        }
        private bool _IsSearchPriceTo;

        public bool IsSearchPriceTo
        {
            get { return _IsSearchPriceTo; }
            set { _IsSearchPriceTo = value; InvokePropertyChanged(new PropertyChangedEventArgs("IsSearchPriceTo")); }
        }
        private bool _isSearchStockFrom;

        public bool IsSearchStockFrom
        {
            get { return _isSearchStockFrom; }
            set { _isSearchStockFrom = value; InvokePropertyChanged(new PropertyChangedEventArgs("IsSearchStockFrom")); }
        }

        private bool _isSearchStockTo;

        public bool IsSearchStockTo
        {
            get { return _isSearchStockTo; }
            set { _isSearchStockTo = value; InvokePropertyChanged(new PropertyChangedEventArgs("IsSearchStockTo")); }
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
