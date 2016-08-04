namespace ExistingDatabaseConverter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransactionDetail")]
    public partial class TransactionDetail
    {
        [StringLength(30)]
        public string id { get; set; }

        [Required]
        [StringLength(20)]
        public string transactionId { get; set; }

        [Required]
        [StringLength(20)]
        public string productId { get; set; }

        public double discountamount { get; set; }

        public double totalcapital { get; set; }

        public double payment { get; set; }

        public int quantity { get; set; }

        public virtual Product Product { get; set; }

        public virtual TransactionHistory TransactionHistory { get; set; }
    }
}
