//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : ProductBusiness.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System.Linq;
using System.Collections.Generic;
using lhk.POS.Core.Domain;
using lhk.POS.Data;
namespace lhk.POS.Common.Business
{
    public class ProductPriceBusiness : GenericBuiness<ProductPrice>
    {
        public ProductPriceBusiness(IRepository<ProductPrice> repository)
        {
            _repository = repository;
        }

        public List<ProductPrice> GetAvailablePrice()
        {
            return this.GetAll().Where(p => p.IsCurrentPrice).ToList();
        }
        public ProductPrice GetProductAvailablePrice(int productId)
        {
            return this.GetAll().FirstOrDefault(p => p.IsCurrentPrice && p.ProductId.Equals(productId));
        }
	}
}
