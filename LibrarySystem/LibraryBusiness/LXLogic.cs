using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess;
using System.Data;

namespace Library.LibraryBusiness
{
    
   public  class LXLogic
    {
       private LXUser lx; //字段
       public LXLogic()
       {
           lx = new LXUser(); //实例化对象
       }
       public bool LxInsertUser(string userid, string photoFile)
       {
           return lx.LxInsertUser(userid, photoFile);
       }
       public DataSet LxGetUserInfoByUserID(string userid)
       {
           return lx.LxGetUserInfoByUserID(userid);
       }
    }
}
