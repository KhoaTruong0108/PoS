namespace ExistingDatabaseConverter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductPrice")]
    public partial class ProductPrice
    {
        [StringLength(20)]
        public string id { get; set; }

        public DateTime date { get; set; }

        public double importprice { get; set; }

        public bool iscurrentprice { get; set; }

        public double price { get; set; }

        [Required]
        [StringLength(20)]
        public string productid { get; set; }

        public virtual Product Product { get; set; }

        public lhk.POS.Core.Domain.ProductPrice ToDomainObject()
        {
            AutoMapper.Mapper.CreateMap<ProductPrice, lhk.POS.Core.Domain.ProductPrice>()
                .ForMember(i => i.Id, opt => opt.Ignore())
                .ForMember(i => i.ProductId, opt => opt.Ignore())
                .ForMember(i => i.Cost, opt => opt.MapFrom(x => x.importprice))
                .ForMember(i => i.ChangedDate, opt => opt.MapFrom(x => x.date));
            return AutoMapper.Mapper.Map<lhk.POS.Core.Domain.ProductPrice>(this);
        }
    }
}
