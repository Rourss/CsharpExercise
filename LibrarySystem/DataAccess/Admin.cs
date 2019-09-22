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
    public class Admin
    {
        private SqlCommand cmd; //字段
        private Encrypt en; //字段
        public Admin() //构造函数
        {
            cmd = new SqlCommand(); //初始化字段
            cmd.CommandType = CommandType.StoredProcedure; //设置类型为存储过程

            en=new Encrypt(); //初始化字段
        }
        /// <summary>
        /// 通过输入管理员编号和密码,验证是否有这个管理员
        /// </summary>
        /// <param name="adminid">管理员编号</param>
        /// <param name="password">管理员密码</param>
        /// <returns>返回首行首列</returns>
        public bool Login(string adminid, string password)
        {
            cmd.CommandText = "AdminLogin"; 
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@AdminID", SqlDbType.Char, 10).Value = adminid;
            cmd.Parameters.Add("@PassWord", SqlDbType.Binary, 20).Value = en.EncryptPassword(password); //调用接口类的方法把传入的(参数)字符串加密再传给数据库
            try
            {
                object obj = DBAccess.GetScalar(cmd);
                if (Convert.ToInt32(obj) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// 通过对应的管理员编号修改此管理员密码的方法
        /// </summary>
        /// <param name="adminid">管理员编号</param>
        /// <param name="newpassword">管理员密码</param>
        /// <returns></returns>
        public bool ChangePassword(string adminid, string newpassword)
        {
            cmd.CommandText = "ChangeAdminPassword";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@AdminID", SqlDbType.Char, 10).Value = adminid;
            cmd.Parameters.Add("@PassWord", SqlDbType.Binary, 20).Value = en.EncryptPassword(newpassword); //调用接口类的方法把传入的(参数)字符串加密再传给数据库
            try
            {
                int num = DBAccess.ExecuteSQL(cmd); //声明一个变量,用来存放调用底层方法后返回的值
                if (num > 0) //如果大于零返回真
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
                return false; //如果出现异常返回假
            }
        }
        /// <summary>
        /// 通过指定的管理员编号找管理员名字
        /// </summary>
        /// <param name="adminid"></param>
        /// <returns></returns>
        public string GetAdminNameByID(string adminid)
        {
            cmd.CommandText = "GetAdminNameByID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@AdminID", SqlDbType.Char, 10).Value = adminid;
            //由于转换不成功会抛出异常，所以加try
            try
            {
                object obj = DBAccess.GetScalar(cmd);
                return Convert.ToString(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        /// <summary>
        /// 添加新的管理员
        /// </summary>
        /// <param name="adminid">管理员编号</param>
        /// <param name="adminname">管理员名字</param>
        /// <param name="password">管理员密码</param>
        /// <param name="email">管理员邮箱</param>
        /// <returns></returns>
        public bool InsertAdmin(string adminid, string adminname, string password, string email)
        {
            cmd.CommandText = "InsertNewAdmin";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@AdminID", SqlDbType.Char, 10).Value = adminid;
            cmd.Parameters.Add("@AdminName", SqlDbType.NVarChar, 30).Value = adminname;
            cmd.Parameters.Add("@PassWord", SqlDbType.Binary, 20).Value = en.EncryptPassword(password); //调用接口类的方法把传入的(参数)字符串加密再传给数据库
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 40).Value = email;
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

