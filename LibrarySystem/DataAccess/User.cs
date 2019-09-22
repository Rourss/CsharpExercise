using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using Library.Comm;

namespace Library.DataAccess
{
    public class User
    {
        private SqlCommand cmd; //字段
        private Photo ph; //字段
        public User()
        {
            cmd = new SqlCommand(); //实例化对象
            ph = new Photo(); //实例化对像
            cmd.CommandType = CommandType.StoredProcedure; //设置文本类型为存储过程
        }
        /// <summary>
        /// 通过读者编号查找读者信息的方法
        /// </summary>
        /// <param name="userid">读者编号</param>
        /// <returns>返回数据集</returns>
        public DataSet GetUserName(string userid)
        {
            cmd.CommandText = "GetUserInfoByID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@UserID", SqlDbType.VarChar, 50).Value = userid;
            DataSet ds = DBAccess.QueryData(cmd);
            return ds;
        }
        //public bool Login(string userid, string password)
        /// <summary>
        /// 插入新的读者
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="sex"></param>
        /// <param name="email"></param>
        /// <param name="classname"></param>
        /// <returns>返回结果</returns>
        public bool InsertUser(string userid, string username, string password, int sex, string email, string classname)
        {
            cmd.CommandText = "InsertNewUserG";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@UserID", SqlDbType.VarChar, 50).Value = userid;
            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value = username;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar, 20).Value = password;
            cmd.Parameters.Add("@Sex", SqlDbType.Int).Value = sex;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = email;
            cmd.Parameters.Add("@Class", SqlDbType.NVarChar, 40).Value = classname;
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
        /// 通过读者ID更新读者照片的方法
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="photo">照片为文件（包含路径）</param>
        /// <returns></returns>
        public bool UpdateUserInfoByUserID(string userid, string photo)
        {
            cmd.CommandText = "UpdateUserInfoByUserID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userID", SqlDbType.VarChar, 50).Value = userid;
            cmd.Parameters.Add("@photo", SqlDbType.Image).Value = ph.ReadPhoto(photo);
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
    }
}
