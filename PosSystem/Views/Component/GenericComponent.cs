using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lhk.POS.Core.Util;

namespace lhk.POS.Presentation.Views
{
    public partial class GenericComponent : UserControl
    {
        public GenericComponent()
        {
            InitializeComponent();
        }

        protected virtual void NumberOnlyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        protected virtual void FloatNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar.Equals('.'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        protected virtual void CurrencyTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox currencyTextBox = (TextBox)sender;
            decimal value = 0;
            int pos = 0;

            if (string.IsNullOrWhiteSpace(currencyTextBox.Text))
            {
                currencyTextBox.Text = "0";
            }
            else if (decimal.TryParse(currencyTextBox.Text, out value))
            {
                pos = currencyTextBox.SelectionStart;
                currencyTextBox.Text = CurrencyUtil.ToString(value);
                currencyTextBox.SelectionStart = pos;
            }
        }
    }
}
