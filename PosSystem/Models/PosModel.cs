using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lhk.POS.Common;
using lhk.POS.Core.Domain;

namespace lhk.POS.Presentation
{
    public class PosModel<T> : IModel<T> where T : BaseEntity
    {
        protected T _entity;
        public PosModel(T entity)
        {
            _entity = entity;
        }
    }
}
