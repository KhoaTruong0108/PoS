//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : ManufacturerBusiness.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//

using System.Linq;
using lhk.POS.Core.Domain;
using lhk.POS.Data;
namespace lhk.POS.Common.Business
{
    public class ManufacturerBusiness : GenericBuiness<Manufacturer>
    {
        public ManufacturerBusiness(IRepository<Manufacturer> repository)
        {
            _repository = repository;
        }
	}
}
