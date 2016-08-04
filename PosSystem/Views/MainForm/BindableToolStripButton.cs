using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lhk.POS.Presentation.Views
{
    public class BindableToolStripButton : ToolStripButton, IBindableComponent
    {
        private ControlBindingsCollection dataBindings;

        private BindingContext bindingContext;

        public ControlBindingsCollection DataBindings
        {
            get
            {
                if (dataBindings == null) dataBindings = new ControlBindingsCollection(this);
                return dataBindings;
            }
        }

        public BindingContext BindingContext
        {
            get
            {
                if (bindingContext == null) bindingContext = new BindingContext();
                return bindingContext;
            }
            set { bindingContext = value; }
        }
    }
}
