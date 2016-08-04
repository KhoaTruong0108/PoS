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
    public class ImportProductPresenter
    {
        private ImportProductModel _model;
        private IImportProductView _view;

        private ImportProductBusiness _business;
        private ProductBusiness _businessProduct;

        public ImportProductPresenter(IImportProductView view)
        {
            _business = new ImportProductBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<Import>>());
            _businessProduct = new ProductBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<Product>>());

            _view = view;

            Import import = new Import();
            var units = new UnitBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<Unit>>()).GetAll().ToList();
            var manufacturers = new ManufacturerBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<Manufacturer>>()).GetAll().ToList();

            _model = new ImportProductModel(import);
            _view.InitView(_model);
        }

        public void HandleSearchImports()
        {
            _model.Imports = _business.GetAll().Where(i => i.Date >= _model.SearchDateFrom.AddHours(1 - _model.SearchDateFrom.Hour)
                && i.Date <= _model.SearchDateTo.AddHours(-_model.SearchDateTo.Hour - 1).AddDays(1)).ToList();
        }

        public StringBuilder CheckImportData()
        {
            StringBuilder errorMessage = new StringBuilder();
            if (_model.Import == null || (_model.Import != null && _model.Import.Id == 0))
            {
                errorMessage.Append("Chọn hóa đơn nhập hàng");
            }
            else if (_model.Import.ImportStatus)
            {
                errorMessage.Append("Hóa đơn này đã nhập");
            }

            return errorMessage;
        }

        public StringBuilder InsertUpdateImport(bool isUpdating)
        {
            StringBuilder errorMessage = new StringBuilder();
            try
            {
                AppLogger.logInfo("InsertUpdateProduct");

                if (isUpdating)
                {
                    _business.Update(_model.Import);
                }
                else
                {
                    _business.Insert(_model.Import);

                }

            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
                errorMessage.AppendLine(exc.Message);
            }
            return errorMessage;
        }

        public StringBuilder DeleteImportProduct()
        {
            StringBuilder errorMessage = new StringBuilder();
            try
            {
                AppLogger.logInfo("DeleteImportProduct");

                Import import = _business.GetById(_model.Import.Id);
                if (import == null)
                {
                    errorMessage.AppendLine(Constants.Messages.PRODUCT_SELECT_IMPORT);
                    return errorMessage;
                }
                _business.Delete(_model.Import.Id);

                return errorMessage;
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
                errorMessage.AppendLine(exc.Message);
                return errorMessage;
            }
        }

        public bool ExecuteImporting(Import import)
        {
            try
            {
                if (_businessProduct.UpdateInventory(import.ImportItems) == false)
                    return false;
                import.ImportStatus = true;
                _business.Update(import);
                return true;
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
                throw exc;
            }
        }

        public void ClearAll()
        {
            _model.Import = new Import();
            _model.Import.Date = DateTime.Now;
            _model.Import.ImportItems = new List<ImportItem>();
        }

    }
}
