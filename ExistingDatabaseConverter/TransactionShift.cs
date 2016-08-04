namespace ExistingDatabaseConverter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransactionShift")]
    public partial class TransactionShift
    {
        [StringLength(20)]
        public string id { get; set; }

        [Required]
        [StringLength(20)]
        public string userid { get; set; }

        public DateTime openTime { get; set; }

        public DateTime closeTime { get; set; }

        public double revenue { get; set; }

        public double discount { get; set; }

        public double capital { get; set; }

        public double profit { get; set; }

        public virtual User User { get; set; }
    }
}
