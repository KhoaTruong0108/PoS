//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : ImportEntity.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace lhk.POS.Core.Domain
{
    public class Import : BaseEntity
    {
        public Import()
        {
            Date = DateTime.Now;
            ImportItems = new List<ImportItem>();
        }
        [DisplayName("Ngày nhập")]
        public DateTime Date { get; set; }

        [DisplayName("Tình trạng nhập")]

        public bool ImportStatus { get; set; }

        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [Browsable(false)]
        public int ImportBy { get; set; }

        public virtual List<ImportItem> ImportItems { get; set; }

    }
}
