//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : OrderMapper.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//
using System.Data.Entity.ModelConfiguration;
using lhk.POS.Core.Domain;

namespace lhk.POS.Data.DataMapping{
	public class OrderMapper : EntityTypeConfiguration<Order>
    {
        public OrderMapper()
        {
            this.ToTable("Order");
            this.HasKey(o => o.Id);
            this.Property(o => o.TotalPayment).HasPrecision(18, 2);
        }
	}
}
