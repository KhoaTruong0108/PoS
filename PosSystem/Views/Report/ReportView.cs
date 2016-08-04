using lhk.POS.Core.Domain;
using lhk.POS.Core.Util;
using lhk.POS.Presentation.Models;
using lhk.POS.Presentation.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace lhk.POS.Presentation.Views
{
    public partial class ReportView : GenericView, IReportView
    {
        protected ReportPresenter _presenter;
        protected ReportModel _model;
        protected bool _isCreating = false;

        public ReportView()
        {
            InitializeComponent();

            _presenter = new ReportPresenter(this);
        }

        public void InitView(ReportModel model)
        {
            try
            {
                _model = model;

                tbExpense.DataBindings.Add("Text", _model, "Expense", true, DataSourceUpdateMode.OnPropertyChanged);
                tbRevenue.DataBindings.Add("Text", _model, "Revenue", true, DataSourceUpdateMode.OnPropertyChanged);
                tbProfit.DataBindings.Add("Text", _model, "Profit", true, DataSourceUpdateMode.OnPropertyChanged);
                tbSubPayment.DataBindings.Add("Text", _model, "SubPayment", true, DataSourceUpdateMode.OnPropertyChanged);
                tbSubQuantity.DataBindings.Add("Text", _model, "SubCost", true, DataSourceUpdateMode.OnPropertyChanged);

                _dtpFromDate.DataBindings.Add("Value", _model, "ReportDateFrom", true, DataSourceUpdateMode.OnPropertyChanged);
                _dtpToDate.DataBindings.Add("Value", _model, "ReportDateTo", true, DataSourceUpdateMode.OnPropertyChanged);
                dgvOrders.DataBindings.Add("DataSource", _model, "OrderDisplay", true, DataSourceUpdateMode.OnPropertyChanged);
                dgvOrderItem.DataBindings.Add("DataSource", _model, "OrderItems", true, DataSourceUpdateMode.OnPropertyChanged);
                _cbQuarter.DataBindings.Add("DataSource", _model, "Quarters", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.ToString(), exc);
            }
        }


        #region IView Members

        override public bool HandleCreateNew()
        {
            try
            {
                _presenter.ClearAll();
                _isCreating = true;
                _model.IsEditingStatus = true;

                return true;
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.ToString(), exc);
                return false;
            }
        }

        private void _dgvImportList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrders.SelectedRows.Count > 0)
                {
                    _model.SelectedOrder = (OrderDisplay)dgvOrders.SelectedRows[0].DataBoundItem;

                    _presenter.LoadOrderDetail(_model.SelectedOrder);

                   
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }
        #endregion

        private void _btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                _presenter.ExecuteReport();
            }
            catch (Exception exc)
            {
                AppLogger.logError(exc);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtDate_CheckedChanged(object sender, EventArgs e)
        {
            _model.Type = rbtDate.Checked ? ReportModel.ReportType.Date :
                rbtMonth.Checked ? ReportModel.ReportType.Month :
                rbtQuarter.Checked ? ReportModel.ReportType.Quarter :
                ReportModel.ReportType.Year;
            _cbQuarter.Enabled = _model.Type == ReportModel.ReportType.Quarter;
            _dtpFromDate.Enabled = _dtpToDate.Enabled = _model.Type != ReportModel.ReportType.Quarter;
        }



    }
}
