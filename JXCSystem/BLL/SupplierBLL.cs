using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QiuXingMing.DAL;
using QiuXingMing.Model;

namespace QiuXingMing.BLL
{
   public class SupplierBLL
    {
       private SupplierDAL sDAL;
       public SupplierBLL()
       {
           sDAL = new SupplierDAL();
       }
       public List<Supplier> FindByName(string name)
       {
           return sDAL.FindByName(name);
       }
       public Supplier FindByID(string id)
       {
           return sDAL.FindByID(id);
       }
       public List<Supplier> GetALL()
       {
           return sDAL.GetALL();
       }
       public bool Insert(Supplier o)
       {
           return sDAL.Insert(o);
       }
       public bool Update(Supplier o)
       {
           return sDAL.Update(o);
       }
       public bool Delete(Supplier o)
       {
           return sDAL.Delete(o);
       }
    }
}
