//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : CustomerEntity.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System;
using System.ComponentModel;
namespace lhk.POS.Core.Domain
{
    public class Customer : BaseEntity
    {
        public Customer()
        {
            IsDeleted = false;
            ChangedDate = DateTime.Now;
        }


        [DisplayName("Tên")]
        public string Name { get; set; }
      
        [DisplayName("Điện thoại")]
        public string Phone { get; set; }
       
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }
        
        [DisplayName("Tổng điểm")]
        public decimal TotalPurchase { get; set; }
      
        [DisplayName("Điểm tích lũy")]
        public decimal Purchase { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }
      
        [DisplayName("Đã xóa")]
        [Browsable(false)]
        public bool IsDeleted { get; set; }
        
        [DisplayName("Thay đổi bởi")]
        public int ChangedBy { get; set; }

        [DisplayName("Ngày thay đổi")]
        public DateTime ChangedDate { get; set; }
    }
}
