using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Inventory
{
    
    internal class ProductClass
    {
        private int _Quantity;
        private double _SellingPrice;
        private string _ProductName, _Category, _ManufacturingDate, _ExpirationDate, _Description;
        public ProductClass(string ProductName, string Category, string MfgDate, string ExpDate, double Price, int Quantity, string Description) 
        {
            this._Quantity = Quantity;
            this._SellingPrice = Price;
            this._ProductName = ProductName;
            this._Category = Category;
            this._ManufacturingDate = MfgDate;
            this._ExpirationDate = ExpDate;
            this._Description = Description;
        }

        public string productName
        {
            get { return this._ProductName; }
            set { this._ProductName = value; }
        }
        public string category
        {
            get { return this._Category; }
            set { this._Category = value; }
        }
        public string manufacturingDate
        {
            get { return this._ManufacturingDate; }
            set { this._ManufacturingDate = value; }
        }
        public string expirationDate
        {
            get { return this._ExpirationDate; }
            set { this.expirationDate = value; }
        }
        public string Description
        {
            get { return this._Description; }
            set { this._Description = value; }
        }
        public double SellingPrice
        {
            get {  return this._SellingPrice; }
            set { this._SellingPrice = value;}
        }
        public int Quantity
        {
            get { return this._Quantity; }
            set { this.Quantity = value; }
        }
    }
}
