namespace ExistingDatabaseConverter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inventory")]
    public partial class Inventory
    {
        [Key]
        [StringLength(20)]
        public string productId { get; set; }

        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
    }
}
