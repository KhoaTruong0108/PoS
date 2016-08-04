//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : LoginModel.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System.ComponentModel;
using lhk.POS.Common;
using lhk.POS.Core.Domain;

namespace lhk.POS.Presentation.Models
{
    public class LoginModel : INotifyPropertyChanged
    {
        protected User _entity;

        public LoginModel(User entity)
        {
            _entity = entity;
        }

        public string UserName
        {
            get { return _entity.UserName; }
            set { _entity.UserName = value; InvokePropertyChanged(new PropertyChangedEventArgs("UserName")); }
        }

        public string Password
        {
            get { return _entity.Password; }
            set { _entity.Password = value; InvokePropertyChanged(new PropertyChangedEventArgs("Password")); }
        }
        public string Role
        {
            get { return _entity.Role; }
            set { _entity.Role = value; InvokePropertyChanged(new PropertyChangedEventArgs("Role")); }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; InvokePropertyChanged(new PropertyChangedEventArgs("Message")); }
        }

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }

        #endregion
    }
}
