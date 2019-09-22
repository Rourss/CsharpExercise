using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QiuXingMing.DAL;
using QiuXingMing.Model;

namespace QiuXingMing.BLL
{
   public class CategoryBLL
    {
       private CategoryDAL cDAL;
       public CategoryBLL()
       {
           cDAL = new CategoryDAL();
       }
       public List<Category> FindByName(string name)
       {
           return cDAL.FindByName(name);
       }
       public Category FindByID(string id)
       {
           return cDAL.FindByID(id);
       }
       public List<Category> GetALL()
       {
           return cDAL.GetALL();
       }
       public bool Insert(Category o)
       {
           return cDAL.Insert(o);
       }
       public bool Update(Category o)
       {
           return cDAL.Update(o);
       }
       public bool Delete(Category o)
       {
           return cDAL.Delete(o);
       }
    }
}
