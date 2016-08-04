//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : ProductMapper.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//
using System.Data.Entity.ModelConfiguration;
using lhk.POS.Core.Domain;


namespace lhk.POS.Data.DataMapping{
    public class ProductPriceMapper : EntityTypeConfiguration<ProductPrice>
    {
        public ProductPriceMapper()
        {
            this.ToTable("ProductPrice");
            this.HasKey(o => o.Id);
            this.Property(o => o.ProductId).IsRequired();
            this.Property(o => o.Price).HasPrecision(18, 2);
            this.Property(o => o.Cost).HasPrecision(18, 2);
        }
	}
}
