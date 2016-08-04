using System;
using System.Linq;
using System.Windows.Forms;
using lhk.POS.Core;
using lhk.POS.Core.Util;
using lhk.POS.Presentation.Models;

namespace lhk.POS.Presentation.Views
{
    public partial class Main : Form
    {
        #region -Private properties
        private GenericView CurrentView { get; set; }
        public MainModel _model;
        #endregion

        #region View methods
        public Main()
        {
            InitializeComponent();

            _model = new MainModel();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                AppLogger.logInfo(this.Name, ":: Main_Manager_Load");

                m_menuStrip.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                m_tsbAddNew.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                m_tsbCancelTask.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                m_tsbDelete.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                m_tsbEdit.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                m_tsbExport.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                m_tsbSaveTask.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                m_tsbPrint.DataBindings.Add("Enabled", _model, "IsLoggedIn");
                m_tsbSearch.DataBindings.Add("Enabled", _model, "IsLoggedIn");

                m_tsbAddNew.DataBindings.Add("Visible", _model, "IsNotEditing");
                m_tsbDelete.DataBindings.Add("Visible", _model, "IsNotEditing");
                m_tsbEdit.DataBindings.Add("Visible", _model, "IsNotEditing");
                m_tsbExport.DataBindings.Add("Visible", _model, "IsNotEditing");
                m_tsbPrint.DataBindings.Add("Visible", _model, "IsNotEditing");
                m_tsbSearch.DataBindings.Add("Visible", _model, "IsNotEditing");
                m_tsbCancelTask.DataBindings.Add("Visible", _model, "IsEditing");
                m_tsbSaveTask.DataBindings.Add("Visible", _model, "IsEditing");

                m_tssUserName.Text = string.Format("Name: {0}", SystemParam.CurrentUser.UserName);
                m_tssUserRole.Text = string.Format("Role: {0}", EnumHelper.Parse<Constants.UserRole>(SystemParam.CurrentUser.Role).GetDescription());

                _model.IsLoggedIn = true;
                _model.IsEditing = false;
                _model.UserId = SystemParam.CurrentUser.Id;
                _model.UserName = SystemParam.CurrentUser.UserName;
                _model.UserRole = SystemParam.CurrentUser.Role;

            }
            catch (Exception exc)
            {
                AppLogger.logError(this.Name, exc);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected void logout()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            SystemParam.IsLogged = false;
            SystemParam.CurrentUser = null;

            _model.IsLoggedIn = false;
        }
        #endregion

        #region -Menu event

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiUser_Click(object sender, EventArgs e)
        {
            UserView formDialog = new UserView();
            formDialog.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiSetupSystem_Click(object sender, EventArgs e)
        {
            //SystemConfigView formDialog = new SystemConfigView();
            //formDialog.ShowDialog();
        }

        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiCustomer_Click(object sender, EventArgs e)
        {
            this.ShowView(this, new CustomerView(), typeof(CustomerView));
            //(new CustomerQuickAddView()).ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiFinancial_Click(object sender, EventArgs e)
        {
            this.ShowView(this, new ReportView(), typeof(ReportView));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiProduct_Click(object sender, EventArgs e)
        {
            this.ShowView(this, new ProductView(), typeof(ProductView));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsiImport_Click(object sender, EventArgs e)
        {
            this.ShowView(this, new ImportProductView(), typeof(ImportProductView));
        }

        #endregion

        #region -Common button event
        private void tsbLogout_Click(object sender, EventArgs e)
        {
            if (SystemParam.IsLogged)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn Đăng Xuất không?", "Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    logout();
                    this.Close();
                }
            }
            //else
            //{
            //    LoginView newForm = new LoginView();

            //    newForm.ShowDialog();

            //    this.HandleActiveView(newForm);

            //    _model.IsLoggedIn = newForm.IsLoginSucess;
            //}
        }

        private void m_tsbAddNew_Click(object sender, EventArgs e)
        {
            AppLogger.logInfo(this.Name, "handle tsbAddNew");
            this.HandleCreateNew();
        }
        
        private void m_tsbSave_Click(object sender, EventArgs e)
        {
            AppLogger.logInfo(this.Name, "handle tsbSave");
            this.HandleSaveTask();
        }

        private void m_tsbCancelTask_Click(object sender, EventArgs e)
        {
            AppLogger.logInfo(this.Name, "handle tsbCancel");
            this.HandleCancelTask();
        }

        private void m_tsbEdit_Click(object sender, EventArgs e)
        {
            AppLogger.logInfo(this.Name, "handle tsbEdit");
            this.HandleEdit();
        }

        private void m_tsbDelete_Click(object sender, EventArgs e)
        {
            AppLogger.logInfo(this.Name, "handle tsbDelete");
            this.HandleDelete();
        }

        private void m_tsbSearch_Click(object sender, EventArgs e)
        {
            AppLogger.logInfo(this.Name, "handle tsbSearch");
            this.HandleSearch();
        }

        private void m_tsbPrint_Click(object sender, EventArgs e)
        {
            AppLogger.logInfo(this.Name, "handle tsbPrint");
            this.HandlePrint();
        }

        private void m_tsbExport_Click(object sender, EventArgs e)
        {
            AppLogger.logInfo(this.Name, "handle tsbExport");
            this.HandleExport();
        }
        #endregion

        #region -Private Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainForm"></param>
        /// <param name="newForm"></param>
        /// <param name="type"></param>
        public void ShowView(Form mainForm, GenericView newForm, Type type)
        {
            foreach (Form f in mainForm.MdiChildren)
            {
                if (f.GetType() == type)
                {
                    f.Activate();
                    HandleActiveView(f as GenericView);

                    return;
                }
            }
            newForm.MdiParent = mainForm;
            newForm.WindowState = FormWindowState.Maximized;
            newForm.ShowIcon = false;
            newForm.Show();

            HandleActiveView(newForm);

            newForm._closeViewCallBack = CloseView;
        }

        public void HandleActiveView(GenericView view)
        {
            this.CurrentView = view;
        }

        public void CloseView(GenericView view)
        {
            Form f = this.MdiChildren.FirstOrDefault(v => v.GetType() != view.GetType());
            if (f != null)
            {
                f.Activate();
                HandleActiveView(f as GenericView);

                return;
            }

            HandleActiveView(null);
        }

        public void HandleBarcodeHit(string barcode)
        {
            if (this.CurrentView != null)
            {
                this.CurrentView.HandleBarcodeHit(barcode);
            }
        }

        public void HandleCreateNew()
        {
            if (this.CurrentView != null)
            {
                _model.IsEditing = this.CurrentView.HandleCreateNew();
            }
        }

        public void HandleEdit()
        {
            if (this.CurrentView != null)
            {
                _model.IsEditing = this.CurrentView.HandleEdit();
            }
        }

        public void HandleDelete()
        {
            if (this.CurrentView != null)
            {
                this.CurrentView.HandleDelete();
            }
        }

        public void HandleSaveTask()
        {
            if (this.CurrentView != null)
            {
                bool result = this.CurrentView.HandleSaveTask();
                _model.IsEditing = !result;
            }
        }

        public void HandleCancelTask()
        {
            if (this.CurrentView != null)
            {
                this.CurrentView.HandleCancelTask();
                _model.IsEditing = false;
            }
        }

        public void HandlePrint()
        {
            if (this.CurrentView != null)
            {
                this.CurrentView.HandlePrint();
            }
        }

        public void HandleExport()
        {
            if (this.CurrentView != null)
            {
                this.CurrentView.HandleExport();
            }
        }

        public void HandleSearch()
        {
            if (this.CurrentView != null)
            {
                this.CurrentView.HandleSearch();
            }
        }

        public void HandleHelp()
        {
            if (this.CurrentView != null)
            {
                this.CurrentView.HandleHelp();
            }
        }

        #endregion

        private void banHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowView(this, new SaleView(), typeof(SaleView));
        }
    }
}
