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
    public class ProductBusiness : GenericBuiness<Product>
    {
        public ProductBusiness(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public Product GetProductByBarcode(string barcode)
        {
            return this.GetAll().FirstOrDefault(p => p.Barcode.Equals(barcode));
        }

        public bool UpdateInventory(IEnumerable<ImportItem> items)
        {
            foreach (var item in items)
            {
                var product = this.GetById(item.ProductId);

                if (product == null) return false;
                product.StockQuantity += item.Quantity;

                _repository.Update(product, false);
            }
            _repository.Submit();
            return true;
        }

    }
}
