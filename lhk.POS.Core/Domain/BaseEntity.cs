//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : BaseEntity.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System.ComponentModel;
namespace lhk.POS.Core.Domain
{
    public class BaseEntity
    {
        [Browsable(false)]
        public int Id { get; set; }
    }
}
