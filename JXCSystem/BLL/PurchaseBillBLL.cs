using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QiuXingMing.DAL;
using QiuXingMing.Model;

namespace QiuXingMing.BLL
{
   public class PurchaseBillBLL
    {
       private PurchaseBillDAL pDAL;
       public PurchaseBillBLL()
       {
           pDAL = new PurchaseBillDAL();
       }
       public List<string> FindPurchaseIDByID(string id)
       {
           return pDAL.FindPurchaseIDByID(id);
       }
       public List<string> FindPurchaseIDByClerkName(string name)
       {
           return pDAL.FindPurchaseIDByClerkName(name);
       }
       public List<string> FindPurchaseIDByExaminerName(string name)
       {
           return pDAL.FindPurchaseIDByExaminerName(name);
       }
        public List<string> FindPurchaseIDByOnProcess(int process)
       {
           return pDAL.FindPurchaseIDByOnProcess(process);
       }
        public List<string> FindPurchaseIDByPurchaseDate(DateTime start, DateTime end)
        {
            return pDAL.FindPurchaseIDByPurchaseDate(start, end);
        }
        public PurchaseBill FindByID(string id)
        {
            return pDAL.FindByID(id);
        }
        public bool Insert(PurchaseBill o)
        {
            return pDAL.Insert(o);
        }
        public bool Update(PurchaseBill o)
        {
            return pDAL.Update(o);
        }
        public string CreatePurchaseID(DateTime purchaseDate)
        {
            return pDAL.CreatePurchaseID(purchaseDate);
        }
    }
}
