//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : OrderEntity.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System;
using System.Collections.Generic;
namespace lhk.POS.Core.Domain{
	public class Order : BaseEntity{
        public Order()
        {
            ChangedDate = DateTime.Now;
            OrderItems = new List<OrderItem>();
        }
        public int? CustomerId { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPayment { get; set; }
        public int ChangedBy { get; set; }
        public DateTime ChangedDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }
	}
}
