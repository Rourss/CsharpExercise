using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QiuXingMing.DAL;
using QiuXingMing.Model;

namespace QiuXingMing.BLL
{
   public class CustomerBLL
    {
       private CustomerDAL cDAL;
       public CustomerBLL()
       {
           cDAL = new CustomerDAL();
       }
       public List<Customer> FindByName(string name)
       {
           return cDAL.FindByName(name);
       }
       public Customer FindByID(string id)
       {
           return cDAL.FindByID(id);
       }
       public List<Customer> GetALL()
       {
           return cDAL.GetALL();
       }
       public bool Insert(Customer o)
       {
           return cDAL.Insert(o);
       }
       public bool Update(Customer o)
       {
           return cDAL.Update(o);
       }
       public bool Delete(Customer o)
       {
           return cDAL.Delete(o);
       }
    }
}
