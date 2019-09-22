using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiuXingMing.Model
{
   public class Product
    {
        private string productID;
        private string productName;
        private string spellingCode;
        private string barCode;
        private string special;
        private string unit;
        private string origin;
        private string categoryID;
        private decimal purchasePrice;
        private decimal salePrice;
        private int quantity;

        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        
        public string SpellingCode
        {
            get { return spellingCode; }
            set { spellingCode = value; }
        }
        
        public string BarCode
        {
            get { return barCode; }
            set { barCode = value; }
        }
        
        public string Special
        {
            get { return special; }
            set { special = value; }
        }
       
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        
        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }
        
        public string CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }
        
        public decimal PurchasePrice
        {
            get { return purchasePrice; }
            set { purchasePrice = value; }
        }
        
        public decimal SalePrice
        {
            get { return salePrice; }
            set { salePrice = value; }
        }
        
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public Product()
        {

        }
        public Product(string productID,string productName,string spellingCode,string barCode,string special,string unit,string origin,string categoryID,decimal purchasePrice,decimal salePrice,int quantity)
        {
            this.productID = productID;
            this.productName = productName;
            this.spellingCode = spellingCode;
            this.barCode = barCode;
            this.special = special;
            this.unit = unit;
            this.origin = origin;
            this.categoryID = categoryID;
            this.purchasePrice = purchasePrice;
            this.salePrice = salePrice;
            this.quantity = quantity;
        }
    }
}
