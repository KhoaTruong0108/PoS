//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : ImportItemEntity.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


namespace lhk.POS.Core.Domain{
	public class ImportItem : BaseEntity{
        public int ImportId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
	}
}
