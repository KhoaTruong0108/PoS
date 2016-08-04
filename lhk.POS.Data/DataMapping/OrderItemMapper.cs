//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : OrderItemMapper.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//

using System.Data.Entity.ModelConfiguration;
using lhk.POS.Core.Domain;


namespace lhk.POS.Data.DataMapping{
	public class OrderItemMapper: EntityTypeConfiguration<OrderItem>
    {
        public OrderItemMapper()
        {
            this.ToTable("OrderItem");
            this.HasKey(oi => oi.Id);
            this.Property(oi => oi.OrderId).IsRequired();
            this.Property(oi => oi.Payment).HasPrecision(18, 2);
        }
	}
}
