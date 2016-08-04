using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lhk.POS.Core.Domain;
using PosSystem.Models.Component.SaleProduct;

namespace lhk.POS.Presentation.Views
{
    public interface ISaleProductComponent
    {
        void InitComponent(SaleProductModel model);

        void ClearAll();

        Order GetOrder();

        void LoadOrder(Order order);
    }
}
