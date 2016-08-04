using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lhk.POS.Common.Business;
using lhk.POS.Core.Domain;
using lhk.POS.Data;
using lhk.POS.Presentation.Views;
using Nop.Core.Infrastructure;
using PosSystem.Depency;
using PosSystem.Models.Component.SaleProduct;

namespace lhk.POS.Presentation.Presenters
{
    public class SaleProductPresenter
    {
        protected SaleProductModel _model;
        protected ProductBusiness _business;
        private ISaleProductComponent _view;

        public SaleProductPresenter(ISaleProductComponent view)
        {
            _business = new ProductBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<Product>>());
            _view = view;

            _model = new SaleProductModel(new List<ProductSale>());

            _view.InitComponent(_model);

            _model.IsEditing = true;
        }

        public void UpdateQuantity()
        {
            if (CheckInputData())
            {
                CaculatePayment();
            }
        }

        public void AddItem(Product product)
        {
            if (product == null) return;

            var existedItem = _model.ProductSales.FirstOrDefault(i => i.ProductId == product.Id);

            if (existedItem == null)
            {
                ProductSale productSale = new ProductSale();

                productSale.Quantity = 1;
                productSale.Product = product;

                _model.ProductSales.Add(productSale);
                _model.ProductSales = _model.ProductSales.ToList();

                _model.Product = productSale;
            }
            else
            {
                existedItem.Quantity++;
            }

            CaculatePayment();
        }

        public void CaculatePayment()
        {
            _model.TotalPayment = _model.ProductSales.Sum(i => i.Quantity * i.Price).ToString();
            _model.TotalQuantity = _model.ProductSales.Sum(i => i.Quantity).ToString();
        }

        public void ClearAll()
        {
            _model.Product = new ProductSale();
            _model.ProductSales = new List<ProductSale>();
            _model.TotalQuantity = string.Empty;
            _model.TotalPayment = string.Empty;
        }

        public void AddNew()
        { 
            _model.Product = new ProductSale();
            _model.IsEditing = true;
        }

        public void DeleteItem()
        {
            var temp = _model.ProductSales.FirstOrDefault(i => i.ProductId == _model.Product.ProductId);
            _model.ProductSales.Remove(temp);

            _model.ProductSales = _model.ProductSales.ToList();

            CaculatePayment();
        }

        protected bool CheckInputData()
        {
            return (!string.IsNullOrEmpty(_model.Barcode) || !string.IsNullOrEmpty(_model.Barcode))
                && _model.Product.Quantity > 0;
        }

    }
}
