//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : CustomerMapper.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System.Data.Entity.ModelConfiguration;
using lhk.POS.Core.Domain;

namespace lhk.POS.Data.DataMapping{
    public class CustomerMapper : EntityTypeConfiguration<Customer>
    {
        public CustomerMapper()
        {
            this.ToTable("Customer");
            this.HasKey(c => c.Id);
            this.Property(c => c.Name).IsRequired().HasMaxLength(400);
            this.Property(c => c.Address).HasMaxLength(2000);
            this.Property(c => c.Phone).HasMaxLength(20);
            this.Property(c => c.Purchase).HasPrecision(18, 2);
            this.Property(c => c.TotalPurchase).HasPrecision(18, 2);
        }
	}
}
