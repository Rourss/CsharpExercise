using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QiuXingMing.Model
{
   public  class Supplier
    {
        private string supplierID;
        private string supplierName;
        private string spellingCode;
        private string address;
        private string zipCode;
        private string tel;
        private string fax;
        private string bankName;
        private string bankAccount;
        private string contacter;
        private string email;
        
        public string SupplierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }
        
        public string SupplierName
        {
            get { return supplierName; }
            set { supplierName = value; }
        }
        
        public string SpellingCode
        {
            get { return spellingCode; }
            set { spellingCode = value; }
        }
        
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        
        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }
        
        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }
        }
        
        public string BankAccount
        {
            get { return bankAccount; }
            set { bankAccount = value; }
        }
        
        public string Contacter
        {
            get { return contacter; }
            set { contacter = value; }
        }
        
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Supplier()
        {

        }
        public Supplier(string supplierID, string supplierName, string spellingCode, string address, string zipCode, string tel, string fax, string bankName, string bankAccount, string contacter, string email)
        {
            this.supplierID = supplierID;
            this.supplierName = supplierName;
            this.spellingCode = spellingCode;
            this.address = address;
            this.zipCode = zipCode;
            this.tel = tel;
            this.fax = fax;
            this.bankName = bankName;
            this.bankAccount = bankAccount;
            this.contacter = contacter;
            this.email = email;
        }
    }
}
