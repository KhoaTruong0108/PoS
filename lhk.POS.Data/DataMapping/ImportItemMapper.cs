//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : ImportItemMapper.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//

using System.Data.Entity.ModelConfiguration;
using lhk.POS.Core.Domain;

namespace lhk.POS.Data.DataMapping{
    public class ImportItemMapper : EntityTypeConfiguration<ImportItem>
    {
        public ImportItemMapper()
        {
            this.ToTable("ImportItem");
            this.HasKey(ii => ii.Id);
            this.Property(o => o.ImportId).IsRequired();
            this.Property(o => o.ProductId).IsRequired();

        }
	}
}
