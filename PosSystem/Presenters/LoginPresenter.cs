//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : LoginPresenter.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//

using System;
using System.Linq;
using lhk.POS.Common.Business;
using lhk.POS.Core;
using lhk.POS.Core.Domain;
using lhk.POS.Core.Util;
using lhk.POS.Data;
using lhk.POS.Presentation.Models;
using lhk.POS.Presentation.Views;
using Nop.Core.Infrastructure;
using PosSystem.Depency;
using Utility.Password;

namespace lhk.POS.Presentation.Presenters
{
    public class LoginPresenter
    {
        private LoginModel _model;
        private ILoginView _view;

        private UserBusiness _business;

        public LoginPresenter(ILoginView view, Constants.UserRole role)
        {
            User user = new User();

            _business = new UserBusiness(Singleton<PosEngine>.Instance.Resolve<IRepository<User>>());
            _view = view;

            _model = new LoginModel(user);
            _model.Role = role.ToString();
            _view.InitView(_model);

            //_model.UserName = "admin";
            //_model.Password = "admin";
        }

        public bool DoLogin()
        {
            if (string.IsNullOrEmpty(_model.Role))
            {
                _model.Message = Constants.Messages.INVALID_USER_ROLE;
            }
            
            User validatedUser = validatedUser = ValidateUser(_model.UserName, _model.Password, _model.Role);
            if (validatedUser != null)
            {
                SystemParam.IsLogged = true;
                SystemParam.CurrentUser = validatedUser;

                return true;
            }
            else
            {
                _model.Message = Constants.Messages.INVALID_USERNAME_OR_PASSWORD;
                return false;
            }
        }

        protected User ValidateUser(string userName, string password, string role)
        {
            // TO DO: implement a custom UserException to display custom error message
            User validatedUser = null;
            try
            {
                string message = string.Empty;


                AppLogger.logInfo("Begin validating user.");
                validatedUser = _business.GetUser(userName, role);
                if (validatedUser != null)
                {
                    if (true)// (PasswordServiceProvider.Match(userName.ToLowerInvariant(), password, validatedUser.Password))
                    {
                        message = "User name & Password matched.";
                    }
                    else
                    {
                        validatedUser = null;
                        message = "User name & Password not matched.";
                    }
                }
                else
                {
                    message = "User does not exist.";
                }

                AppLogger.logInfo(string.Format(message));
                AppLogger.logInfo(string.Format("Finish validating user: {0}", userName));
            }
            catch (Exception ex)
            {
                AppLogger.logError("Error occurs when validating user.", ex);
            }

            return validatedUser;
        }
    }
}
