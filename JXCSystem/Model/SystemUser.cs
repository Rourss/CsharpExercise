using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiuXingMing.Model
{
   public class SystemUser
    {
        private string userID;
        private string password;
        private int baseFunction;
        private int purchaseFunction;
        private int saleFunction;
        private int userFunction;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        
        public int BaseFunction
        {
            get { return baseFunction; }
            set { baseFunction = value; }
        }
        
        public int PurchaseFunction
        {
            get { return purchaseFunction; }
            set { purchaseFunction = value; }
        }
        
        public int SaleFunction
        {
            get { return saleFunction; }
            set { saleFunction = value; }
        }
        
        public int UserFunction
        {
            get { return userFunction; }
            set { userFunction = value; }
        }
        public SystemUser()
        {

        }
        public SystemUser(string userID, string password, int baseFunction, int purchaseFunction, int saleFunction, int userFunction)
        {
            this.userID = userID;
            this.password = password;
            this.baseFunction = baseFunction;
            this.purchaseFunction = purchaseFunction;
            this.saleFunction = saleFunction;
            this.userFunction = userFunction;
        }
    }
}
