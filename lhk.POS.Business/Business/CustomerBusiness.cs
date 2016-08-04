//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : CustomerBusiness.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//

using lhk.POS.Core.Domain;
using lhk.POS.Data;

namespace lhk.POS.Common.Business{
    public class CustomerBusiness : GenericBuiness<Customer>
    {
        public CustomerBusiness(IRepository<Customer> repository)
        {
            _repository = repository;
        }

	}
}
