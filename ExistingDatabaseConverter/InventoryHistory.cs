namespace ExistingDatabaseConverter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryHistory")]
    public partial class InventoryHistory
    {
        [StringLength(20)]
        public string id { get; set; }

        [Required]
        [StringLength(20)]
        public string productId { get; set; }

        public int amountchange { get; set; }

        public DateTime date { get; set; }

        public int currentquantity { get; set; }

        [Required]
        [StringLength(500)]
        public string reasontochange { get; set; }

        [Required]
        [StringLength(20)]
        public string changebyuser { get; set; }

        public virtual Product Product { get; set; }
    }
}
