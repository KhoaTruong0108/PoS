//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : ImportMapper.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//
using System.Data.Entity.ModelConfiguration;
using lhk.POS.Core.Domain;

namespace lhk.POS.Data.DataMapping{
	public class ImportMapper : EntityTypeConfiguration<Import>
    {
        public ImportMapper()
        {
            this.ToTable("Import");
            this.HasKey(i => i.Id);
        }
	}
}
