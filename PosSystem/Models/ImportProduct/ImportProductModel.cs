//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : ProductModel.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System.Collections.Generic;
using System.ComponentModel;
using lhk.POS.Core.Domain;
using lhk.POS.Core.Util;
using System;

namespace lhk.POS.Presentation.Models
{
    public class ImportProductModel : INotifyPropertyChanged
    {
        private Import _import;

        public ImportProductModel(Import import)
        {
            _import = import;

            _searchDateFrom = DateTime.Now.AddDays(-1);
            _searchDateTo = DateTime.Now;
        }

        public Import Import
        {
            get { return _import; }
            set { _import = value; }
        }

        private bool _isEditingStatus = false;

        public bool IsEditingStatus
        {
            get { return _isEditingStatus; }
            set { _isEditingStatus = value; InvokePropertyChanged(new PropertyChangedEventArgs("IsEditingStatus")); }
        }
        public bool IsNotEditingStatus
        {
            get { return !_isEditingStatus; }
            set { InvokePropertyChanged(new PropertyChangedEventArgs("IsNotEditingStatus")); }
        }

        public string Id
        {
            get { return _import.Id.ToString(); }
            set
            {
                _import.Id = StringUtil.ToInt(value); InvokePropertyChanged(new PropertyChangedEventArgs("Id"));
            }
        }

        public DateTime Date
        {
            get { return _import.Date; }
            set
            {
                _import.Date = value; InvokePropertyChanged(new PropertyChangedEventArgs("Date"));
            }
        }

        public string Description
        {
            get { return _import.Description; }
            set
            {
                _import.Description = value; InvokePropertyChanged(new PropertyChangedEventArgs("Description"));
            }
        }

        private int _quantity;
        public string Quantity
        {
            get { return _quantity.ToString(); }
            set
            {
                _quantity = StringUtil.ToInt(value); InvokePropertyChanged(new PropertyChangedEventArgs("Quantity"));
            }
        }

        private int _payment;
        public string Payment
        {
            get { return _payment.ToString(); }
            set
            {
                _payment = StringUtil.ToInt(value); InvokePropertyChanged(new PropertyChangedEventArgs("Payment"));
            }
        }

        private List<Import> _imports;

        public List<Import> Imports
        {
            get { return _imports; }
            set { _imports = value; InvokePropertyChanged(new PropertyChangedEventArgs("Imports")); }
        }


        #region Search Section
        private string _searchBarcode;

        public string SearchBarcode
        {
            get { return _searchBarcode; }
            set { _searchBarcode = value; InvokePropertyChanged(new PropertyChangedEventArgs("SearchBarcode")); }
        }
        private string _searchName;

        public string SearchName
        {
            get { return _searchName; }
            set { _searchName = value; InvokePropertyChanged(new PropertyChangedEventArgs("SearchName")); }
        }
        private DateTime _searchDateFrom;

        public DateTime SearchDateFrom
        {
            get { return _searchDateFrom; }
            set { _searchDateFrom = value; InvokePropertyChanged(new PropertyChangedEventArgs("SearchDateFrom")); }
        }
        private DateTime _searchDateTo;

        public DateTime SearchDateTo
        {
            get { return _searchDateTo; }
            set { _searchDateTo = value; InvokePropertyChanged(new PropertyChangedEventArgs("SearchDateTo")); }
        }

        #endregion

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
