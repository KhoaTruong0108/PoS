//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : RefundItemMapper.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//
using System.Data.Entity.ModelConfiguration;
using lhk.POS.Core.Domain;


namespace lhk.POS.Data.DataMapping{
	public class RefundItemMapper : EntityTypeConfiguration<RefundItem>
    {
        public RefundItemMapper()
        {
            this.ToTable("RefundItem");
            this.HasKey(ri => ri.Id);
            this.Property(ri => ri.RefundId).IsRequired();
            this.Property(ri => ri.ProductId).IsRequired();
        }
	}
}
