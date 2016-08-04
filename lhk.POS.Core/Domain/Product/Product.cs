//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : ProductEntity.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace lhk.POS.Core.Domain
{
    public class Product : BaseEntity
    {

        public Product()
        {
            UnitId = -1;
            ManufacturerId = -1;
            IsDeleted = false;
            StockQuantity = 0;
            ChangedDate = DateTime.Now;

            ProductPrices = new List<ProductPrice>();
        }

        [DisplayName("Tên mặt hàng")]
        public string Name { get; set; }

        [DisplayName("Mã vạch")]
        public string Barcode { get; set; }

        [DisplayName("Giá bán")]
        public decimal Price { get; set; }

        [DisplayName("Giá nhập")]
        public decimal Cost { get; set; }

        [DisplayName("Tồn kho")]
        public int StockQuantity { get; set; }

        [DisplayName("Mã phân loại")]
        public int? CategoryId { get; set; }

        [DisplayName("Mã đơn vị")]
        [Browsable(false)]
        public int? UnitId { get; set; }

        [DisplayName("Mã nhà sản xuất")]
        [Browsable(false)]
        public int? ManufacturerId { get; set; }

        [DisplayName("IsDeleted")]
        [Browsable(false)]
        public bool IsDeleted { get; set; }

        [DisplayName("Thay đổi bởi")]
        public int ChangedBy { get; set; }

        [DisplayName("Ngày thay đổi")]
        public DateTime ChangedDate { get; set; }

        [DisplayName("Mô tả")]
        [Browsable(false)]
        public string Description { get; set; }

        [Browsable(false)]
        public virtual ICollection<ProductPrice> ProductPrices { get; set; }

        [Browsable(false)]
        public virtual Unit Unit { get; set; }
        [Browsable(false)]
        public virtual Manufacturer Manufacturer { get; set; }
        [Browsable(false)]
        public virtual Category Category { get; set; }
    }
}
