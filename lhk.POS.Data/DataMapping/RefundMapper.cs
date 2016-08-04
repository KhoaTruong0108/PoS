//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : RefundMapper.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//
using System.Data.Entity.ModelConfiguration;
using lhk.POS.Core.Domain;

namespace lhk.POS.Data.DataMapping{
	public class RefundMapper : EntityTypeConfiguration<Refund>
    {
        public RefundMapper()
        {
            this.ToTable("Refund");
            this.HasKey(r => r.Id);
            this.Property(r => r.Reason).IsRequired().HasMaxLength(1000);
            this.Property(r => r.TotalPayment).HasPrecision(18,2);
        }
	}
}
