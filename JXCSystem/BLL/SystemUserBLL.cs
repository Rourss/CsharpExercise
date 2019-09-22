using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QiuXingMing.DAL;
using QiuXingMing.Model;

namespace QiuXingMing.BLL
{
   public class SystemUserBLL
    {
       private SystemUserDAL sDAL;
       public SystemUserBLL()
       {
           sDAL = new SystemUserDAL();
       }
       public SystemUser FindByID(string id)
       {
           return sDAL.FindByID(id);
       }
       public List<string> GetAllSystemUserID()
       {
           return sDAL.GetAllSystemUserID();
       }
       public bool Update(SystemUser o)
       {
           return sDAL.Update(o);
       }
       public bool ChangPWD(string adminid, string newpassword)
       {
           return sDAL.ChangPWD(adminid, newpassword);
       }
       public bool SelectSystemUser(string adminid, string password)
       {
           return sDAL.SelectSystemUser(adminid, password);
       }
    }
}
