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
    public partial class PaymentDetailView : GenericView, IPaymentDetailView
    {
        public enum PaymentResult
        {
            Payout,
            PayandPrint,
            Cancel
        }

        protected PaymentDetailModel _model;
        protected PaymentDetailPresenter _presenter;

        //private bool m_isPaid = false;

        //public bool IsPaid
        //{
        //    get { return m_isPaid; }
        //    set { m_isPaid = value; }
        //}

        public PaymentResult Result { get; set; }


        public PaymentDetailView(Order order, Customer customer)
        {
            InitializeComponent();

            _presenter = new PaymentDetailPresenter(this, order, customer);
        }

        public void InitView(PaymentDetailModel model)
        {
            _model = model;

            lblCusId.DataBindings.Add("Text", _model, "CusId", true, DataSourceUpdateMode.OnPropertyChanged);
            lblCusName.DataBindings.Add("Text", _model, "CusName", true, DataSourceUpdateMode.OnPropertyChanged);
            lblCusPhone.DataBindings.Add("Text", _model, "CusPhone", true, DataSourceUpdateMode.OnPropertyChanged);
            lblCusPoint.DataBindings.Add("Text", _model, "TotalPurchase", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCusChange.DataBindings.Add("Text", _model, "CusChange", true, DataSourceUpdateMode.OnPropertyChanged);
            txtCusPay.DataBindings.Add("Text", _model, "CusCash", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTotalPayment.DataBindings.Add("Text", _model, "TotalPayment", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTotalQuantity.DataBindings.Add("Text", _model, "TotalQuantity", true, DataSourceUpdateMode.OnPropertyChanged);

            txtCusPay.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Result = PaymentResult.Cancel;
            this.Close();
        }

        private void btnPayOut_Click(object sender, EventArgs e)
        {
            if (CurrencyUtil.ToDecimal(_model.CusChange) < 0) return;

            Result = PaymentResult.Payout;
            this.Close();
        }

        private void btnPayPrint_Click(object sender, EventArgs e)
        {
            if (CurrencyUtil.ToDecimal(_model.CusChange) < 0) return;

            Result = PaymentResult.PayandPrint;
            this.Close();
        }

        private void txtCusPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.NumberOnlyTextBox_KeyPress(sender, e);
        }

        private void txtCusPay_TextChanged(object sender, EventArgs e)
        {
            base.CurrencyTextBox_TextChanged(sender, e);
        }


    }
}
