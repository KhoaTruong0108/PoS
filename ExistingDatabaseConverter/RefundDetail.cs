namespace ExistingDatabaseConverter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RefundDetail")]
    public partial class RefundDetail
    {
        [StringLength(20)]
        public string id { get; set; }

        [Required]
        [StringLength(20)]
        public string refundId { get; set; }

        [Required]
        [StringLength(20)]
        public string productId { get; set; }

        public double price { get; set; }

        public int quantity { get; set; }

        public virtual Product Product { get; set; }

        public virtual RefundHistory RefundHistory { get; set; }
    }
}
