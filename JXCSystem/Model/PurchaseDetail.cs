using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiuXingMing.Model
{
   public class PurchaseDetail
    {
        private string purchaseID;
        private string purchaseDetailID;
        private string productID;
        private decimal purchasePrice;
        private string quantity;

        public string PurchaseID
        {
            get { return purchaseID; }
            set { purchaseID = value; }
        }
        
        public string PurchaseDetailID
        {
            get { return purchaseDetailID; }
            set { purchaseDetailID = value; }
        }
       
        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        
        public decimal PurchasePrice
        {
            get { return purchasePrice; }
            set { purchasePrice = value; }
        }
        
        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public decimal Account
        {
            get { return Convert.ToDecimal(quantity) * purchasePrice; }
        }
        public PurchaseDetail()
        {

        }
        public PurchaseDetail(string purchaseID, string purchaseDetailID, string productID, decimal purchasePrice, string quantity)
        {
            this.purchaseID = purchaseID;
            this.purchaseDetailID = purchaseDetailID;
            this.productID = productID;
            this.purchasePrice = purchasePrice;
            this.quantity = quantity;
        }
    }
}
