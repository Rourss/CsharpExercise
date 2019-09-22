using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library.DataAccess
{
    public class BorrowInfo
    {
        private SqlCommand cmd; //字段
        public BorrowInfo()
        {
            cmd = new SqlCommand(); //初始化
            cmd.CommandType = CommandType.StoredProcedure; //设置文本类型为存储过程

        }
        /// <summary>
        /// 通过图书编号和读者编号在借阅表中借书的方法
        /// </summary>
        /// <param name="bookid">图书编号</param>
        /// <param name="userid">读者编号</param>
        /// <returns>返回结果</returns>
        public bool BorrowBook(string bookid, string userid)
        {
            cmd.CommandText = "BorrowBook";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@BookID", SqlDbType.VarChar, 50).Value = bookid;
            cmd.Parameters.Add("@UserID", SqlDbType.VarChar, 50).Value = userid;
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
        /// 通过图书编号还书的方法
        /// </summary>
        /// <param name="bookid">图书编号</param>
        /// <returns>返回结果</returns>
        public bool ReturnBook(string bookid)
        {
            cmd.CommandText = "ReturnBook";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@BookID", SqlDbType.VarChar, 50).Value = bookid;
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
        /// 通过图书编号续借图书的方法
        /// </summary>
        /// <param name="bookid">图书编号</param>
        /// <returns>返回结果</returns>
        public bool ReBorrow(string bookid)
        {
            cmd.CommandText = "ReborrowBook";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@BookID", SqlDbType.VarChar, 50).Value = bookid;
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
        /// 通过图书编号查找借阅信息的方法
        /// </summary>
        /// <param name="bookid">图书编号</param>
        /// <returns>数据集</returns>
        public DataSet GetBorrowInfoByBookID(string bookid)
        {
            cmd.CommandText = "GetBorrowInfoByBookID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@BookID", SqlDbType.VarChar, 50).Value = bookid;
            DataSet ds = DBAccess.QueryData(cmd);
            return ds;
        }
        /// <summary>
        /// 通过读者编号查找借阅信息的方法
        /// </summary>
        /// <param name="userid">读者编号</param>
        /// <returns>数据集</returns>
        public DataSet GetBorrowInfoByUserID(string userid)
        {
            cmd.CommandText = "GetBorrowInfoByUserID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@UserID", SqlDbType.VarChar, 50).Value = userid;
            DataSet ds = DBAccess.QueryData(cmd);
            return ds;
        }
        /// <summary>
        /// 通过图书编号查找这本书是否被借出
        /// </summary>
        /// <param name="bookid"></param>
        /// <returns>假为未借出，真为已借出</returns>
        public bool IsBorrowed(string bookid)
        {
            cmd.CommandText = "IsBorrowed";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@BookID", SqlDbType.VarChar, 50).Value = bookid;
            object obj = DBAccess.GetScalar(cmd);
            if (obj == null)
            {
                return false;
            }
            else
            {
                if (Convert.ToInt32(obj) == 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        /// <summary>
        /// 通过图书编号查询是否有这本书
        /// </summary>
        /// <param name="bookid"></param>
        /// <returns>真为有，假为不存在</returns>
        public bool HasBook(string bookid)
        {
            cmd.CommandText = "HasThisBook";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@BookID", SqlDbType.VarChar, 50).Value = bookid;
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
        /// <summary>
        /// 查找是否逾期的方法
        /// </summary>
        /// <param name="bookid"></param>
        /// <returns>返回结果</returns>
        public bool IsOverdue(string bookid)
        {
            cmd.CommandText = "IsOverdue";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@BookID", SqlDbType.VarChar, 50).Value = bookid;
            object obj=DBAccess.GetScalar(cmd); 
            if (Convert.ToInt32(obj) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
