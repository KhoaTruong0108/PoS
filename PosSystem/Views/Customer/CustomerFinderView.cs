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
    public partial class CustomerFinderView : GenericView, ICustomerFinderView
    {
        protected CustomerFinderModel _model;
        protected CustomerFinderPresenter _presenter;

        public Customer SelectedCustomer
        {
            get { return _model.Customer; }
        }
        public bool IsNoResult()
        {
            return _model.Customers.Count <= 0;
        }

        public CustomerFinderView(string Phone = "", string name = "", bool isSearchPhone = true)
        {
            InitializeComponent();

            _presenter = new CustomerFinderPresenter(this);

            _model.Phone = Phone;
            _model.Name = name;

            if (isSearchPhone) tbPhone.Select();
            else tbName.Select();

            _presenter.HandleSearchCustomer();
        }

        public Customer getUniqueItem()
        {
            if (_model.Customers.Count == 1)
            {
                return _model.Customers.FirstOrDefault();
            }
            return null;
        }

        public void InitView(CustomerFinderModel model)
        {
            _model = model;

            tbPhone.DataBindings.Add("Text", _model, "Phone", true, DataSourceUpdateMode.OnPropertyChanged);
            tbName.DataBindings.Add("Text", _model, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            dgvCustomers.DataBindings.Add("DataSource", _model, "Customers", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SearchCustomerView_Load(object sender, EventArgs e)
        {
            tbName.Focus();
        }

        private void _btnChoose_Click(object sender, EventArgs e)
        {
            ChooseCustomer();
        }

        private void _btnClose_Click(object sender, EventArgs e)
        {
            _model.Customer = null;
            this.Close();
        }

        private void SearchCustomerView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    ChooseCustomer();
                    break;
                case Keys.Back:
                    tbPhone.Text = "";
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Up:
                case Keys.Down:
                    this.dgvCustomers.Focus();
                    break;
            }
        }

        public void ChooseCustomer()
        {
            try
            {
                if (dgvCustomers.SelectedRows != null && dgvCustomers.SelectedRows.Count > 0)
                {
                    AppLogger.logDebug( "HandleChooseCustomer");
                    _model.Customer = (Customer)dgvCustomers.SelectedRows[0].DataBoundItem;
                }
                this.Close();
            }
            catch (Exception exc)
            {
                AppLogger.logError( exc);
            }
        }

        private void _txtBarcord_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.NumberOnlyTextBox_KeyPress(sender, e);
        }

        private void _dgvListCustomer_DoubleClick(object sender, EventArgs e)
        {
            ChooseCustomer();
        }


    }
}
