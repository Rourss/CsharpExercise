using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Library.Comm;

namespace Library.DataAccess
{
   public class LXUser
    {
       private SqlCommand cmd; //字段
       private Photo photo; //字段

       public LXUser()
       {
           cmd = new SqlCommand(); //实例化对象
           cmd.CommandType = CommandType.StoredProcedure; //设置参数的属性为存储过程

           photo =new Photo(); //实例化对象
       }
       /// <summary>
       /// 插入新的读者的方法
       /// </summary>
       /// <param name="userid"></param>
       /// <param name="photoFile"> 照片文件（含路径）</param>
       /// <returns></returns>
       public bool LxInsertUser(string userid, string photoFile)
       {
           cmd.CommandText = "LxInsertUser";
           cmd.Parameters.Clear();
           cmd.Parameters.Add("@userid", SqlDbType.Char, 11).Value = userid;
           cmd.Parameters.Add("@photo", SqlDbType.Image).Value = photo.ReadPhoto(photoFile);
           try
           {
               int num = DBAccess.ExecuteSQL(cmd);
               if (num > 0)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
           catch 
           {
               return false;
           }
       }
       /// <summary>
       /// 通过读者ID找读者的信息的方法
       /// </summary>
       /// <param name="userid"></param>
       /// <returns></returns>
       public DataSet LxGetUserInfoByUserID(string userid)
       {
           cmd.CommandText = "LxGetUserInfoByUserID";
           cmd.Parameters.Clear();
           cmd.Parameters.Add("@userid", SqlDbType.Char, 11).Value = userid;
           return DBAccess.QueryData(cmd);       }
    }
}
