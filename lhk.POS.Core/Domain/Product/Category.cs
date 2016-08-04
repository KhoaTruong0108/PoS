//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : CategoryEntity.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


namespace lhk.POS.Core.Domain{
	public class Category : BaseEntity{
        public Category()
        {
            ParentId = -1;
        }

        public string Name { get; set; }
        public int ParentId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
	}
}
