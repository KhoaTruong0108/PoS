//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : OrderItemEntity.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


namespace lhk.POS.Core.Domain{
	public class OrderItem : BaseEntity{
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Payment { get; set; }

        public virtual Product Product { get; set; }
	}
}
