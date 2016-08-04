//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : RefundEntity.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System;
namespace lhk.POS.Core.Domain{
	public class Refund : BaseEntity{
        public Refund()
        {
            ChangedDate = DateTime.Now;
        }
        public int CustomerId { get; set; }
        public string Reason { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPayment { get; set; }
        public DateTime ChangedDate { get; set; }
        public string ChangedBy { get; set; }
	}
}
