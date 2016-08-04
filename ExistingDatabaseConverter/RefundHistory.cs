namespace ExistingDatabaseConverter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RefundHistory")]
    public partial class RefundHistory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RefundHistory()
        {
            RefundDetails = new HashSet<RefundDetail>();
        }

        [StringLength(20)]
        public string id { get; set; }

        [Required]
        [StringLength(20)]
        public string CusId { get; set; }

        public DateTime date { get; set; }

        [Required]
        [StringLength(255)]
        public string reason { get; set; }

        public int totalquantity { get; set; }

        public double totalrefund { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefundDetail> RefundDetails { get; set; }
    }
}
