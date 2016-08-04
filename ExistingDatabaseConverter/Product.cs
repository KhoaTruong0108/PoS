namespace ExistingDatabaseConverter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ImportDetails = new HashSet<ImportDetail>();
            InventoryHistories = new HashSet<InventoryHistory>();
            ProductPrices = new HashSet<ProductPrice>();
            RefundDetails = new HashSet<RefundDetail>();
            TransactionDetails = new HashSet<TransactionDetail>();
        }

        [StringLength(20)]
        public string id { get; set; }

        [Required]
        [StringLength(30)]
        public string barcode { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(20)]
        public string unit { get; set; }

        [Required]
        [StringLength(20)]
        public string category { get; set; }

        [Required]
        [StringLength(20)]
        public string manufacturer { get; set; }

        [Required]
        [StringLength(255)]
        public string desciption { get; set; }

        [Required]
        [StringLength(20)]
        public string createby { get; set; }

        public DateTime createdate { get; set; }

        public virtual Category Category1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportDetail> ImportDetails { get; set; }

        public virtual Inventory Inventory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryHistory> InventoryHistories { get; set; }

        public virtual Manufacturer Manufacturer1 { get; set; }

        public virtual Unit Unit1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductPrice> ProductPrices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefundDetail> RefundDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }

        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }

        public lhk.POS.Core.Domain.Product ToDomainObject()
        {
            AutoMapper.Mapper.CreateMap<Product, lhk.POS.Core.Domain.Product>()
                .ForMember(i => i.Id, opt => opt.Ignore())
                .ForMember(i => i.ProductPrices, opt => opt.Ignore())
                .ForMember(i => i.Manufacturer, opt => opt.Ignore())
                .ForMember(i => i.Unit, opt => opt.Ignore())
                .ForMember(i => i.Category, opt => opt.Ignore())
                .ForMember(i => i.ChangedBy, opt => opt.Ignore())
                .ForMember(i => i.ChangedDate, opt => opt.MapFrom(x => x.createdate))
                .ForMember(i => i.StockQuantity, opt => opt.MapFrom(x => x.Inventory.Quantity));

            return AutoMapper.Mapper.Map<lhk.POS.Core.Domain.Product>(this);
        }
    }
}
