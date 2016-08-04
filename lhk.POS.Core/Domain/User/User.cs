//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : UserEntity.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System;


namespace lhk.POS.Core.Domain{
	public class User : BaseEntity{
        public User()
        {
            ChangedDate = DateTime.Now;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool IsDeleted { get; set; }
        public int ChangedBy { get; set; }
        public DateTime ChangedDate { get; set; }
	}
}
