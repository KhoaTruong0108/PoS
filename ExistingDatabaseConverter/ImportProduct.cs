namespace ExistingDatabaseConverter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImportProduct")]
    public partial class ImportProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImportProduct()
        {
            ImportDetails = new HashSet<ImportDetail>();
        }

        [StringLength(20)]
        public string id { get; set; }

        [Required]
        [StringLength(20)]
        public string delivery { get; set; }

        public int totalquantity { get; set; }

        public double totalpayment { get; set; }

        public DateTime date { get; set; }

        [Required]
        [StringLength(10)]
        public string description { get; set; }

        [Required]
        [StringLength(20)]
        public string receiveby { get; set; }

        public virtual Delivery Delivery1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportDetail> ImportDetails { get; set; }
    }
}
