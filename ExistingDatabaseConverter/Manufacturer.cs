namespace ExistingDatabaseConverter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Manufacturer")]
    public partial class Manufacturer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Manufacturer()
        {
            Products = new HashSet<Product>();
        }

        [StringLength(20)]
        public string id { get; set; }

        [Required]
        [StringLength(100)]
        public string address { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(20)]
        public string phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }

        public lhk.POS.Core.Domain.Manufacturer ToDomainObject()
        {
            AutoMapper.Mapper.CreateMap<Manufacturer, lhk.POS.Core.Domain.Manufacturer>()
                .ForMember(i => i.Id, opt => opt.Ignore());
            return AutoMapper.Mapper.Map<lhk.POS.Core.Domain.Manufacturer>(this);
        }
    }
}
