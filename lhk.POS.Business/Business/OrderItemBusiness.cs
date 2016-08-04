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
    public class OrderItemBusiness : GenericBuiness<OrderItem>
    {
        public OrderItemBusiness(IRepository<OrderItem> repository)
        {
            _repository = repository;
        }
    }
}
