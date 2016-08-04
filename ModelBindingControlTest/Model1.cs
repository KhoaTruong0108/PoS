using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lhk.POS.Core.Domain;

namespace ModelBindingControlTest
{
    public class Model1 : INotifyPropertyChanged
    {
        IEnumerable<User> _users;

        public IEnumerable<User> Users
        {
            get { return _users; }
            set { _users = value; InvokePropertyChanged(new PropertyChangedEventArgs("Users")); }
        }

        private User _selectedUser;

        public User SelectedUser
        {
            get { return _selectedUser; }
            set { _selectedUser = value; InvokePropertyChanged(new PropertyChangedEventArgs("SelectedUser")); }
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
