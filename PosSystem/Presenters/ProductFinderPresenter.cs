//
//
//  Generated by StarUML(tm) C# Add-In
//
//  @ Project : Untitled Shopping Central
//  @ File Name : SearchProdcutController.cs
//  @ Date : 2/22/2013
//  @ Author :  khoatd
//
//

using System.Collections.Generic;
using System.Linq;
using System;
using System.Windows.Forms;
using lhk.POS.Common.Business;
using lhk.POS.Presentation.Models;
using lhk.POS.Presentation.Views;
using Nop.Core.Infrastructure;
using lhk.POS.Core.Domain;
using lhk.POS.Core.Util;
using PosSystem.Depency;
using lhk.POS.Data;

namespace lhk.POS.Presentation.Presenters
{
    public class ProductFinderPresenter
    {

        protected ProductFinderModel _model;
        protected ProductBusiness _business;
        protected ProductPriceBusiness _businessPrice;
        private IProductFinderView _view;

        public ProductFinderPresenter(IProductFinderView view)
        {
            _business = new ProductBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<Product>>());
            _businessPrice = new ProductPriceBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<ProductPrice>>());
            _view = view;

            _model = new ProductFinderModel(new Product());
            _model.Products = new List<Product>();
            _model.SearchProductFn = new ProductFinderModel.SearchProductDelegate(HandleSearchProduct);

            _view.InitView(_model);
        }

        public void HandleSearchProduct()
        {
            try
            {
                AppLogger.logInfo(this.GetType().Name, " ENTER HandleSearchProduct");

                string name = _model.Name ?? string.Empty;
                string barcode = _model.Barcode ?? string.Empty;
                var products = from p in _business.GetAll()
                               where p.Barcode.Contains(barcode) && p.Name.ToLower().Contains(name.ToLower())
                               select p;

                _model.Products = products.ToList();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppLogger.logError(this.GetType().Name, exc);

            }
        }

    }
}
