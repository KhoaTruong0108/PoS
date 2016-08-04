//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : ManufacturerMapper.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System.Data.Entity.ModelConfiguration;
using lhk.POS.Core.Domain;

namespace lhk.POS.Data.DataMapping{
    public class ManufacturerMapper : EntityTypeConfiguration<Manufacturer>
    {
        public ManufacturerMapper()
        {
            this.ToTable("Manufacturer");
            this.HasKey(c => c.Id);
            this.Property(c => c.Name).IsRequired().HasMaxLength(400);
            this.Property(c => c.Address).HasMaxLength(1000);
            this.Property(c => c.Phone).HasMaxLength(20);
        }
	}
}
