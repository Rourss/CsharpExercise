using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiuXingMing.Model
{
   public class SaleDetail
    {
        private string saleID;
        private string saleDetailID;
        private string productID;
        private decimal salePrice;
        private string quantity;

        public string SaleID
        {
            get { return saleID; }
            set { saleID = value; }
        }
        
        public string SaleDetailID
        {
            get { return saleDetailID; }
            set { saleDetailID = value; }
        }
        
        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        
        public decimal SalePrice
        {
            get { return salePrice; }
            set { salePrice = value; }
        }
        
        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public SaleDetail()
        {

        }
        public SaleDetail(string saleID, string saleDetailID, string productID, decimal salePrice, string quantity)
        {
            this.saleID = saleID;
            this.saleDetailID = saleDetailID;
            this.productID = productID;
            this.salePrice = salePrice;
            this.quantity = quantity;
        }
    }
}
