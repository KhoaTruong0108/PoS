//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : CategoryBusiness.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//

using System.Linq;
using lhk.POS.Core.Domain;
using lhk.POS.Data;
namespace lhk.POS.Common.Business
{
    public class UnitBusiness : GenericBuiness<Unit>
    {
        public UnitBusiness(IRepository<Unit> repository)
        {
            _repository = repository;
        }
	}
}
