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
	public class ProductMapper  : EntityTypeConfiguration<Product>
    {
        public ProductMapper()
        {
            this.ToTable("Product");
            this.HasKey(o => o.Id);
            this.Property(o => o.Name).HasMaxLength(200);
            this.Property(o => o.CategoryId).IsRequired();
            this.Property(o => o.Barcode).HasMaxLength(20);
            this.Property(o => o.Description).HasMaxLength(4000);
            this.Property(o => o.Price).HasPrecision(18, 2);
            this.Property(o => o.Cost).HasPrecision(18, 2);
        }
	}
}
