using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiuXingMing.Model
{
   public class PurchaseBill
    {
        private string purchaseID;
        private string supplierID;
        private DateTime purchaseDate;
        private DateTime stockDate;
        private string clerk;
        private string examiner;
        private string custodian;
        private Int16 onProcess;
        private string memo;
        public string PurchaseID
        {
            get { return purchaseID; }
            set { purchaseID = value; }
        } 
        public string SupplierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }  
        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set { purchaseDate = value; }
        }
        public DateTime StockDate
        {
            get { return stockDate; }
            set { stockDate = value; }
        }  
        public string Clerk
        {
            get { return clerk; }
            set { clerk = value; }
        }
        public string Examiner
        {
            get { return examiner; }
            set { examiner = value; }
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
        private List<PurchaseDetail> detailList; //明细列表

        public List<PurchaseDetail> DetailList
        {
            get { return detailList; }
            set { detailList = value; }
        }
 
        public PurchaseBill()
        {

        }
        public PurchaseBill(string purchaseID, string supplierID, DateTime purchaseDate, DateTime stockDate, string clerk, string examiner, string custodian, Int16 onProcess, string memo,List<PurchaseDetail> detailList)
        {
            this.purchaseID = purchaseID;
            this.supplierID = supplierID;
            this.purchaseDate = purchaseDate;
            this.stockDate = stockDate;
            this.clerk = clerk;
            this.examiner = examiner;
            this.custodian = custodian;
            this.onProcess = onProcess;
            this.memo = memo;
            this.detailList = detailList;
        }
    }
}
