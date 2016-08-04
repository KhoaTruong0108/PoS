namespace ExistingDatabaseConverter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImportDetail")]
    public partial class ImportDetail
    {
        [StringLength(30)]
        public string id { get; set; }

        [Required]
        [StringLength(20)]
        public string importId { get; set; }

        [Required]
        [StringLength(20)]
        public string productId { get; set; }

        public double importprice { get; set; }

        public int quantity { get; set; }

        public virtual ImportProduct ImportProduct { get; set; }

        public virtual Product Product { get; set; }
    }
}
