using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QiuXingMing.DBUtility;
using QiuXingMing.DAL;
using QiuXingMing.Model;
using System.Data.SqlClient;
using System.Data;

namespace QiuXingMing.DAL
{
   public class SystemUserDAL:IDAL<SystemUser>
    {
        private SqlCommand cmd;
        public SystemUserDAL()
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
        }
        public SystemUser FindByID(string id)
        {
            cmd.CommandText = "usp_FindSystemUserByID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userID", SqlDbType.NVarChar, 6).Value = id;
            SqlDataReader reader = DBAccess.ExcuteReader(cmd);
            if (reader.Read())
            {
                SystemUser user = new SystemUser();
                user.UserID = reader["userID"].ToString();
                user.Password = reader["Password"].ToString();
                user.BaseFunction = Convert.ToInt32(reader["BaseFunction"]);
                user.PurchaseFunction = Convert.ToInt32(reader["PurchaseFunction"]);
                user.SaleFunction = Convert.ToInt32(reader["SaleFunction"]);
                user.UserFunction = Convert.ToInt32(reader["UserFunction"]);
                reader.Close();
                return user;
            }
            else
            {
                reader.Close();
                return null;
            }
        }

        public List<SystemUser> GetALL()
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllSystemUserID()
        {
            cmd.CommandText = "usp_GetAllSystemUserID";
            cmd.Parameters.Clear();
            SqlDataReader reader = DBAccess.ExcuteReader(cmd);
            List<string> list = new List<string>();
            while (reader.Read())
            {
                string str = reader["UserID"].ToString();
                list.Add(str);
            }
            reader.Close();
            return list;
            
        }
        public bool Insert(SystemUser o)
        {
            throw new NotImplementedException();
        }
        public bool ChangPWD(string adminid, string newpassword)
        {
            cmd.CommandText = "usp_ChangPassword";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userID", SqlDbType.NVarChar,6).Value = adminid;
            cmd.Parameters.Add("@pwd", SqlDbType.NVarChar, 10).Value = newpassword;
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
        public bool SelectSystemUser(string adminid, string password)
        {
            cmd.CommandText = "usp_SelectSystemUser";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userID", SqlDbType.NVarChar, 6).Value = adminid;
            cmd.Parameters.Add("@pwd", SqlDbType.NVarChar, 10).Value = password; //调用接口类的方法把传入的(参数)字符串加密再传给数据库
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

        public bool Update(SystemUser o)
        {
            cmd.CommandText = "usp_UpdateSystemUser";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@userID", SqlDbType.NVarChar, 6).Value = o.UserID;
            cmd.Parameters.Add("@pwd", SqlDbType.NVarChar, 10).Value = o.Password;
            cmd.Parameters.Add("@baseFunction", SqlDbType.Int).Value = o.BaseFunction;
            cmd.Parameters.Add("@purchaseFunction", SqlDbType.Int).Value = o.PurchaseFunction;
            cmd.Parameters.Add("@saleFunction", SqlDbType.Int).Value = o.SaleFunction;
            cmd.Parameters.Add("@userFunction", SqlDbType.Int).Value = o.UserFunction;
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

        public bool Delete(SystemUser o)
        {
            throw new NotImplementedException();
        }
    }
}
