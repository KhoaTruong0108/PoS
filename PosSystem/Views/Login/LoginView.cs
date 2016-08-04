using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lhk.POS.Core;
using lhk.POS.Core.Domain;
using lhk.POS.Data;
using lhk.POS.Presentation.Models;
using lhk.POS.Presentation.Presenters;
using Nop.Core.Infrastructure;
using PosSystem.Depency;

namespace lhk.POS.Presentation.Views
{
    public partial class LoginView : Form, ILoginView
    {
        private LoginPresenter _presenter;
        private LoginModel _model;

        private LoginView()
        {
            InitializeComponent();

        }

        public LoginView(Constants.UserRole currentRole)
            : this()
        {
            _presenter = new LoginPresenter(this, currentRole);
        }

        public void InitView(LoginModel model)
        {
            _model = model;

            this.tbUserName.DataBindings.Add("Text", this._model, "UserName", true, DataSourceUpdateMode.OnPropertyChanged);
            this.tbPassword.DataBindings.Add("Text", this._model, "Password", false, DataSourceUpdateMode.OnPropertyChanged);
            this.lblErrorMessage.DataBindings.Add("Text", this._model, "Message", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                if (_presenter.DoLogin())
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
        }

        #region Private Methods

        private bool ValidateInput()
        {
            bool result = true;
            lblErrorMessage.Text = string.Empty;
            ICollection<string> errorMessages = new List<string>();
            if (string.IsNullOrEmpty(tbUserName.Text))
            {
                errorMessages.Add(Constants.Messages.BLANK_USERNAME_ALERT);
            }
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                errorMessages.Add(Constants.Messages.BLANK_PASSWORD_ALERT);
            }
            if (errorMessages.Count > 0)
            {
                StringBuilder message = new StringBuilder();
                message.AppendLine("Lỗi:");
                foreach (string errMessage in errorMessages)
                {
                    message.AppendLine(string.Format(" - {0}", errMessage));
                }
                MessageBox.Show(message.ToString(), Constants.Messages.ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                result = false;
            }

            return result;
        }
        #endregion

        private void OnEnter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).SelectAll();
            }
        }
    }
}
