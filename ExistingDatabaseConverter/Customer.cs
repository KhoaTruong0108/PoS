namespace ExistingDatabaseConverter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            RefundHistories = new HashSet<RefundHistory>();
            TransactionHistories = new HashSet<TransactionHistory>();
        }

        [StringLength(20)]
        public string id { get; set; }

        [Required]
        [StringLength(20)]
        public string name { get; set; }

        [Required]
        [StringLength(255)]
        public string address { get; set; }

        [Required]
        [StringLength(20)]
        public string mobile { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Required]
        [StringLength(20)]
        public string phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefundHistory> RefundHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }

        public lhk.POS.Core.Domain.Customer ToDomainObject()
        {
            AutoMapper.Mapper.CreateMap<Customer, lhk.POS.Core.Domain.Customer>()
                .ForMember(i => i.Id, opt => opt.Ignore());
            return AutoMapper.Mapper.Map<lhk.POS.Core.Domain.Customer>(this);
        }    
    }
}
