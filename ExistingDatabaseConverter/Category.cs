namespace ExistingDatabaseConverter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [StringLength(20)]
        public string id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(20)]
        public string fatherId { get; set; }

        [StringLength(255)]
        public string desciption { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }

        public lhk.POS.Core.Domain.Category ToDomainObject()
        {
            AutoMapper.Mapper.CreateMap<Category, lhk.POS.Core.Domain.Category>()
                .ForMember(i => i.Id, opt => opt.Ignore());
            return AutoMapper.Mapper.Map<lhk.POS.Core.Domain.Category>(this);
        }
    }
}
