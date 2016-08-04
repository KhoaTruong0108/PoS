namespace ExistingDatabaseConverter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransactionHistory")]
    public partial class TransactionHistory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransactionHistory()
        {
            TransactionDetails = new HashSet<TransactionDetail>();
        }

        [StringLength(20)]
        public string id { get; set; }

        [Required]
        [StringLength(20)]
        public string cusId { get; set; }

        public DateTime date { get; set; }

        public double discount { get; set; }

        public double totalpayment { get; set; }

        public int totalquantity { get; set; }

        [Required]
        [StringLength(20)]
        public string userid { get; set; }

        public double? cuscash { get; set; }

        public double? cuschange { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }

        public virtual User User { get; set; }
    }
}
