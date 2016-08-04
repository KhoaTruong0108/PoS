using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lhk.POS.Presentation.Models
{
    public class OrderItemReportEntity
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
        private decimal _price;

        public decimal Price
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

        private decimal _discount;

        public decimal Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
        private decimal _total;

        public decimal Total
        {
            get { return _total; }
            set { _total = value; }
        }

        
    }
}
