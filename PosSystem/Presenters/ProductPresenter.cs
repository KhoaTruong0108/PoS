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
    public class ProductPresenter
    {
        private ProductModel _model;
        private IProductView _view;

        private ProductBusiness _business;
        private ProductPriceBusiness _businessPrice;
        private CategoryBusiness _businessCategory;

        public ProductPresenter(IProductView view)
        {
            if (Singleton<ProductBusiness>.Instance == null)
                Singleton<ProductBusiness>.Instance = new ProductBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<Product>>());
            _business = Singleton<ProductBusiness>.Instance;

            _businessPrice = new ProductPriceBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<ProductPrice>>());
            _businessCategory = new CategoryBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<Category>>());
            _view = view;

            Product product = new Product();
            var units = new UnitBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<Unit>>()).GetAll().ToList();
            var manufacturers = new ManufacturerBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<Manufacturer>>()).GetAll().ToList();

            _model = new ProductModel(product, units, manufacturers);
            _view.InitView(_model);
        }

        public StringBuilder checkInputData(bool isUpdating)
        {
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_model.Name))
            {
                errorMessage.AppendLine(Constants.Messages.PRODUCT_NAME_NOT_EMPTY);
            }
            //if (string.IsNullOrWhiteSpace(_model.Barcode))
            //{
            //    errorMessage.AppendLine(Constants.Messages.PRODUCT_BARCODE_NOT_EMPTY);
            //}

            if (string.IsNullOrWhiteSpace(_model.CategoryName))
            {
                errorMessage.AppendLine(Constants.Messages.PRODUCT_CATEGORY_NOT_EMPTY);
            }

            if (_model.Product.Price < 0)
            {
                errorMessage.AppendLine(Constants.Messages.PRODUCT_PRICE_GREATER_THAN_ZERO);
            }

            if (_model.Product.Cost < 0)
            {
                errorMessage.AppendLine(Constants.Messages.PRODUCT_COST_GREATER_THAN_ZERO);
            }

            if (isUpdating == false && string.IsNullOrEmpty(_model.Barcode) == false)
            {
                var existedProduct = _business.GetProductByBarcode(_model.Barcode);
                if (existedProduct != null)
                {
                    errorMessage.AppendLine(Constants.Messages.PRODUCT_DULICATE_BARCODE);
                }
            }

            return errorMessage;
        }

        public StringBuilder InsertUpdateProduct(bool isUpdating)
        {
            StringBuilder errorMessage = new StringBuilder();
            try
            {
                AppLogger.logInfo("InsertUpdateProduct");

                errorMessage.Append(checkInputData(isUpdating));

                if (errorMessage.Length != 0)
                {
                    return errorMessage;
                }

                if(_model.SelectedManufacturer != null) _model.Product.ManufacturerId = _model.SelectedManufacturer.Id;
                if (_model.SelectedUnit != null) _model.Product.UnitId =  _model.SelectedUnit.Id;
                if (_model.SelectedCategory != null) _model.Product.CategoryId = _model.SelectedCategory.Id;
                else _model.Product.CategoryId = 1;

                _model.Product.ChangedBy = SystemParam.CurrentUser.Id;

                if (isUpdating)
                {
                    _business.Update(_model.Product);
                }
                else
                {
                    ProductPrice price = new ProductPrice();
                    price.ProductId = _model.Product.Id;
                    price.Cost = CurrencyUtil.ToDecimal(_model.Cost);
                    price.Price = CurrencyUtil.ToDecimal(_model.Price);
                    price.IsCurrentPrice = true;

                    _model.Product.Price = price.Price;
                    _model.Product.ProductPrices = new List<ProductPrice>() { price };

                    _business.Insert(_model.Product);
                }

            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
                errorMessage.AppendLine(exc.Message);
            }
            return errorMessage;
        }

        public StringBuilder DeleteProduct()
        {
            StringBuilder errorMessage = new StringBuilder();
            try
            {
                AppLogger.logInfo("DeleteProduct");

                Product product = _business.GetById(_model.Product.Id);
                if (product == null)
                {
                    errorMessage.AppendLine(Constants.Messages.PRODUCT_SELECT_PRODUCT);
                    return errorMessage;
                }
                _business.Delete(_model.Product.Id);

                return errorMessage;
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
                errorMessage.AppendLine(exc.Message);
                return errorMessage;
            }
        }

        public void LoadProductsByCategory()
        {
            try
            {
                AppLogger.logInfo("LoadProductList");

                var cats = getProductByCategory(_model.SelectedCategory.Id);
                
                //_model.Products = _business.GetAll().Where(p => cats.Any(i=>i.Id == p.CategoryId)).ToList();
                _model.Products = _business.GetAll().ToList();
                _model.Products = _model.Products.Where(p => cats.Any(i => i.Id == p.CategoryId)).ToList();
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
                throw exc;
            }
        }

        public IEnumerable<Category> getProductByCategory(int parentId)
        {
            List<Category> result = new List<Category>();
            result.Add(_businessCategory.GetById(parentId));
            var children = _businessCategory.GetAll().Where(i => i.ParentId == parentId).ToList();
            foreach (var item in children)
            {
                result.AddRange(getProductByCategory(item.Id));
            }

            return result;
        }

        public void ClearAll()
        {
            _model.Product = new Product();
            _model.Products = new List<Product>();
            _model.SelectedManufacturer = _model.Manufacturers.FirstOrDefault();
            _model.SelectedUnit = _model.Uints.FirstOrDefault();

        }

        public IEnumerable<Category> GetCategory()
        {
            return _businessCategory.GetAll();
        }

        public StringBuilder QuickAddCheckData()
        {
            StringBuilder errMessage = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_model.Price))
            {
                errMessage.AppendLine("Giá bán không được để trống!");
            }

            decimal newPrice = 0;
            if (decimal.TryParse(_model.Price.Replace(",", ""), out newPrice) == false)
            {
                errMessage.AppendLine("Giá bán không hợp lệ (chỉ nhập số lớn hơn 0, không nhập chữ)!");
            }

            var existedProduct = _business.GetProductByBarcode(_model.Barcode);
            if (existedProduct != null)
            {
                errMessage.AppendLine(Constants.Messages.PRODUCT_DULICATE_BARCODE);
            }

            return errMessage;
        }
        public StringBuilder HandleQuickAddProduct()
        {
            StringBuilder errorMessage = new StringBuilder();
            try
            {
                AppLogger.logInfo(" AddNewProduct ");

                errorMessage = QuickAddCheckData();
                if (errorMessage.Length != 0)
                {
                    return errorMessage;
                }

                _model.Product.ManufacturerId = _model.SelectedManufacturer != null ? (int?)_model.SelectedManufacturer.Id : null;
                _model.Product.UnitId = _model.SelectedUnit != null ? (int?)_model.SelectedUnit.Id : null;
                _model.Product.CategoryId = 1;
                _model.Product.ChangedBy = SystemParam.CurrentUser.Id;


                //ProductPrice price = new ProductPrice();
                //price.ProductId = _model.Product.Id;
                //price.Cost = CurrencyUtil.ToDecimal(_model.Cost);
                //price.Price = CurrencyUtil.ToDecimal(_model.Price);
                //price.IsCurrentPrice = true;

                ProductPrice price = new ProductPrice();
                price.ProductId = _model.Product.Id;
                price.Cost = CurrencyUtil.ToDecimal(_model.Cost);
                price.Price = CurrencyUtil.ToDecimal(_model.Price);
                price.IsCurrentPrice = true;

                _model.Product.Price = price.Price;
                _model.Product.ProductPrices = new List<ProductPrice>() { price };

                _business.Insert(_model.Product);

                //_model.Product.ProductPrices.Add(price);
                //_business.Insert(_model.Product);

                return errorMessage;
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc.Message);
                return errorMessage.AppendLine(exc.Message);
            }
        }

        public void HandleSearchProduct()
        {
            AppLogger.logInfo(this.GetType().Name, " ENTER HandleSearchProduct");

            string barcode = _model.SearchBarcode ?? string.Empty;
            string name = _model.SearchName ?? string.Empty;

            var products = from p in _business.GetAll()
                           where (
                                    (string.IsNullOrEmpty(barcode) == false && p.Barcode.Contains(barcode))
                                    ||
                                    (string.IsNullOrEmpty(barcode) && p.Barcode.Equals(barcode))
                                    ||
                                    _model.IsSearchBarcode == false
                                 )
                                &&
                                (
                                    (string.IsNullOrEmpty(name) == false && p.Name.ToLower().Contains(name.ToLower()))
                                    ||
                                    (string.IsNullOrEmpty(name) && p.Name.ToLower().Equals(EntityFunctions.AsNonUnicode(name.ToLower())))
                                    ||
                                    _model.IsSearchName == false
                                 )
                                &&
                                (
                                    string.IsNullOrEmpty(_model.SearchPriceFrom)
                                    ||
                                    int.Parse(_model.SearchPriceFrom) <= p.Price
                                    ||
                                    _model.IsSearchPriceFrom == false
                                )
                                &&
                                (
                                    string.IsNullOrEmpty(_model.SearchPriceTo)
                                    ||
                                    int.Parse(_model.SearchPriceTo) >= p.Price
                                    ||
                                    _model.IsSearchPriceTo == false
                                )
                                &&
                                (
                                    string.IsNullOrEmpty(_model.SearchStockFrom)
                                    ||
                                    int.Parse(_model.SearchStockFrom) <= p.StockQuantity
                                    ||
                                    _model.IsSearchStockFrom == false
                                )
                                &&
                                (
                                    string.IsNullOrEmpty(_model.SearchStockTo)
                                    ||
                                    int.Parse(_model.SearchStockTo) >= p.StockQuantity
                                    ||
                                    _model.IsSearchStockTo == false
                                )
                           select p;

            _model.Products = products.ToList();
        }
    }
}
