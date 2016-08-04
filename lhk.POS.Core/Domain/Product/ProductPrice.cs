using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lhk.POS.Core.Domain
{
    public class ProductPrice : BaseEntity
    {
        public ProductPrice()
        {
            IsCurrentPrice = false;
            ChangedDate = DateTime.Now;
        }

        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public bool IsCurrentPrice { get; set; }
        public DateTime ChangedDate { get; set; }

        //public virtual Product Product { get; set; }

    }
}
