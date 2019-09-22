using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiuXingMing.Model
{
   public  class SaleBill
    {
        private string saleID;
        private string customerID;
        private DateTime saleDate;
        private DateTime deliveryDate;
        private string clerk;
        private string custodian;
        private Int16 onProcess;
        private string memo;

        public string SaleID
        {
            get { return saleID; }
            set { saleID = value; }
        }
       
       public string CustomerID
       {
           get { return customerID; }
           set { customerID = value; }
       }
       
       public DateTime SaleDate
       {
           get { return saleDate; }
           set { saleDate = value; }
       }
       
       public DateTime DeliveryDate
       {
           get { return deliveryDate; }
           set { deliveryDate = value; }
       }
       
       public string Clerk
       {
           get { return clerk; }
           set { clerk = value; }
       }
       
       public string Custodian
       {
           get { return custodian; }
           set { custodian = value; }
       }
       
       public Int16 OnProcess
       {
           get { return onProcess; }
           set { onProcess = value; }
       }
       
       public string Memo
       {
           get { return memo; }
           set { memo = value; }
       }
       public SaleBill()
       {

       }
       public SaleBill(string saleID, string customerID, DateTime saleDate, DateTime deliveryDate, string clerk, string custodian, Int16 onProcess, string memo)
       {
           this.saleID = saleID;
           this.customerID = customerID;
           this.saleDate = saleDate;
           this.deliveryDate = deliveryDate;
           this.clerk = clerk;
           this.custodian = custodian;
           this.onProcess = onProcess;
           this.memo = memo;
       }
   }
}
