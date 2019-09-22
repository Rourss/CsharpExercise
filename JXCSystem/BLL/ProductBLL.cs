using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QiuXingMing.DAL;
using QiuXingMing.Model;

namespace QiuXingMing.BLL
{
   public class ProductBLL
    {
       private ProductDAL pDAL;
       public ProductBLL()
       {
           pDAL = new ProductDAL();
       }
       public List<Product> FindByName(string name)
       {
           return pDAL.FindByName(name);
       }
       public Product FindByID(string id)
       {
           return pDAL.FindByID(id);
       }
       public List<Product> GetALL()
       {
           return pDAL.GetALL();
       }
       public bool Insert(Product o)
       {
           return pDAL.Insert(o);
       }
       public bool Update(Product o)
       {
           return pDAL.Update(o);
       }
       public bool Delete(Product o)
       {
           return pDAL.Delete(o);
       }
    }
}
