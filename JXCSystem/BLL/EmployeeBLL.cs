using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QiuXingMing.DAL;
using QiuXingMing.Model;

namespace QiuXingMing.BLL
{
   public class EmployeeBLL
    {
       private EmployeeDAL eDAL;
       public EmployeeBLL()
       {
           eDAL = new EmployeeDAL();
       }
       public List<Employee> FindByName(string name)
       {
           return eDAL.FindByName(name);
       }
       public Employee FindByID(string id)
       {
           return eDAL.FindByID(id);
       }
       public List<Employee> GetALL()
       {
           return eDAL.GetALL();
       }
       public bool Insert(Employee o)
       {
           return eDAL.Insert(o);
       }
       public bool Update(Employee o)
       {
           return eDAL.Update(o);
       }
       public bool Delete(Employee o)
       {
           return eDAL.Delete(o);
       }
    }
}
