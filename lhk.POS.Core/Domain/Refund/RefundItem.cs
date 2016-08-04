//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : RefundItemEntity.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


namespace lhk.POS.Core.Domain
{
    public class RefundItem : BaseEntity
    {
        public int RefundId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
