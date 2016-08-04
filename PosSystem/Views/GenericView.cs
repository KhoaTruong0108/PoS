using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lhk.POS.Common;
using lhk.POS.Core.Util;

namespace lhk.POS.Presentation
{
    public partial class GenericView : Form, IView
    {
        public GenericView()
        {
            
        }

        #region
        public delegate void CloseViewCallBack(GenericView view);
        public CloseViewCallBack _closeViewCallBack;

        public virtual bool isFocus()
        {
            return this.isFocus();
        }

        public virtual void HandleBarcodeHit(string barcode)
        {

        }

        public virtual bool HandleCreateNew()
        {
            return false;
        }

        public virtual void HandleDelete()
        {

        }

        public virtual bool HandleEdit()
        {
            return false;
        }

        public virtual void HandlePrint()
        {

        }

        public virtual bool HandleSaveTask()
        {
            return false;
        }

        public virtual void HandleCancelTask()
        {

        }

        public virtual void HandleSearch()
        {

        }

        public virtual void HandleExport()
        {

        }

        public virtual void HandleHelp()
        {

        }

        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GenericView
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "GenericView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GenericView_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GeneralView_KeyDown);
            this.ResumeLayout(false);

        }


        protected void GeneralView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        protected void LockProcessingForm()
        {
            this.Cursor = Cursors.WaitCursor;
        }

        protected void ReleaseProcessingForm()
        {
            this.Cursor = Cursors.Arrow;
        }
        protected void ShowErrorMessageBox(string errMessage)
        {
            MessageBox.Show(errMessage, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            //int pos = 0;

            if (string.IsNullOrWhiteSpace(currencyTextBox.Text))
            {
                currencyTextBox.Text = "0";
            }
            else if (decimal.TryParse(currencyTextBox.Text, out value))
            {
                //pos = currencyTextBox.SelectionStart;
                currencyTextBox.Text = CurrencyUtil.ToString(value);
                currencyTextBox.SelectionStart = currencyTextBox.Text.Length;
            }
        }

        protected void GenericView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_closeViewCallBack != null) _closeViewCallBack(this);
        }

        protected void Gridview_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.ValueType == typeof(decimal))
                e.Column.DefaultCellStyle.Format = "N3";
        }

    }
}
