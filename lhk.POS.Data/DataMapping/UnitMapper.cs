//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : UnitMapper.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System.Data.Entity.ModelConfiguration;
using lhk.POS.Core.Domain;

namespace lhk.POS.Data.DataMapping{
    public class UnitMapper : EntityTypeConfiguration<Unit>
    {
        public UnitMapper()
        {
            this.ToTable("Unit");
            this.HasKey(c => c.Id);
            this.Property(c => c.Name).IsRequired().HasMaxLength(400);
            this.Property(c => c.Description).HasMaxLength(2000);
        }
	}
}
