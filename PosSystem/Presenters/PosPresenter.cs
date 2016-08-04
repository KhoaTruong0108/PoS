using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lhk.POS.Common;

namespace PosSystem.Presenters
{
    public class PosPresenter
    {
        IView _view;
        IModel _model;
        public PosPresenter(IView view)
        {
            _view = view;
        }
    }
}
