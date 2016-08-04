//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : CategoryMapper.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//

using System;
using System.Data.Entity.ModelConfiguration;
using lhk.POS.Core.Domain;

namespace lhk.POS.Data.DataMapping
{
    public class CategoryMapper : EntityTypeConfiguration<Category>
    {
        public CategoryMapper()
        {
            this.ToTable("Category");
            this.HasKey(p => p.Id);
            this.Property(p => p.ParentId).IsRequired();
            this.Property(p => p.Name).IsRequired().HasMaxLength(200);
            this.Property(p => p.Description).HasMaxLength(1000);
        }
    }
}
