//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : OrderBusiness.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//

using lhk.POS.Core.Domain;
using lhk.POS.Data;
namespace lhk.POS.Common.Business
{
    public class OrderBusiness : GenericBuiness<Order>
    {
        public OrderBusiness(IRepository<Order> repository)
        {
            _repository = repository;
        }


    }
}
