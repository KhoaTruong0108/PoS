//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : ProductBusiness.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//

using System.Linq;
using lhk.POS.Core.Domain;
using lhk.POS.Data;
using System.Collections.Generic;
namespace lhk.POS.Common.Business
{
    public class ImportProductBusiness : GenericBuiness<Import>
    {

        public ImportProductBusiness(IRepository<Import> repository)
        {
            _repository = repository;
        }
        public void testInsert()
        {
            Import import = new Import()
            {

            };
            import.ImportItems.Add(new ImportItem()
            {
                ProductId = 1,
                Quantity = 3,
            });

            _repository.Insert(import, true);
        }
        //public IEnumerable<Import> GetImportProductByBarcode(string barcode)
        //{
        //    var product = _repositoryProduct.Table.FirstOrDefault(p => p.Barcode == barcode);

        //    return product == null ? new List<Import>() :
        //        (from i in _repository.Table
        //         where i.ImportItems.Any(ii => ii.Product != null && ii.Product.Id == product.Id)
        //         select i).ToList();

        //}

        //public IEnumerable<ImportItem> GetImportItems(string importId)
        //{
        //    var product = _repositoryProduct.Table.FirstOrDefault(p => p.Barcode == barcode);

        //    return product == null ? new List<Import>() :
        //        (from i in _repository.Table
        //         where i.ImportItems.Any(ii => ii.ProductId == product.Id)
        //         select i).ToList();

        //}
    }
    
}
