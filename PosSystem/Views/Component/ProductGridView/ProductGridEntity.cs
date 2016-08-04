using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lhk.POS.Presentation.Views
{
    public class ProductGridEntity
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _barcode;

        public string Barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private double _discount;

        public double Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
        private double _total;

        public double Total
        {
            get { return _total; }
            set { _total = value; }
        }

        
    }
}
