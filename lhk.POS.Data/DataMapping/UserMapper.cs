//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : UserMapper.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//
using System.Data.Entity.ModelConfiguration;
using lhk.POS.Core.Domain;

namespace lhk.POS.Data.DataMapping{
	public class UserMapper : EntityTypeConfiguration<User>
    {
        public UserMapper()
        {
            this.ToTable("User");
            this.HasKey(u => u.Id);
            this.Property(u => u.Role).IsRequired().HasMaxLength(10);
            this.Property(r => r.UserName).IsRequired().HasMaxLength(20);
        }
	}
}
