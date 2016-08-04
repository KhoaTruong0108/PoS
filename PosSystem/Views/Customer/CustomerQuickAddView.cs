using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lhk.POS.Core.Domain;
using lhk.POS.Core.Util;
using lhk.POS.Presentation.Models;
using lhk.POS.Presentation.Presenters;

namespace lhk.POS.Presentation.Views
{
    public partial class CustomerQuickAddView : GenericView, ICustomerView
    {

        protected CustomerModel _model;
        protected CustomerPresenter _presenter;

        public CustomerQuickAddView()
        {
            InitializeComponent();

            _presenter = new CustomerPresenter(this);
        }

        public Customer AddedCustomer
        {
            get { return _model.Customer; }
        }
        public void InitView(CustomerModel model)
        {
            _model = model;

            tbPhone.DataBindings.Add("Text", _model, "Phone", true, DataSourceUpdateMode.OnPropertyChanged);
            tbName.DataBindings.Add("Text", _model, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            tbAddress.DataBindings.Add("Text", _model, "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            tbEmail.DataBindings.Add("Text", _model, "Email", true, DataSourceUpdateMode.OnPropertyChanged);
            
        }

        private void _btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                AppLogger.logInfo("btnOk_Click");

                var errorMessage = _presenter.InsertUpdateCustomer(false).ToString();

                if (errorMessage.Length != 0)
                {
                    ShowErrorMessageBox(errorMessage);
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc.Message);
            }
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            _model.Customer = null;
            this.Close();
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.NumberOnlyTextBox_KeyPress(sender, e);
        }

        
    }
}
