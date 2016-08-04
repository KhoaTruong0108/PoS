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
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace lhk.POS.Common.Business
{
    public class ReportBusiness : GenericBuiness<Order>
    {
        public ReportBusiness(IRepository<Order> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Order> GetOrderByDate(DateTime from, DateTime to)
        {
            return _repository.Table.Where(i => i.ChangedDate >= from && i.ChangedDate <= to);
        }
    }
}
