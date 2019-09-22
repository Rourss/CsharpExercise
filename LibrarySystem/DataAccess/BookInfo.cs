using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library.DataAccess
{
    public class BookInfo
    {
        private SqlCommand cmd; //字段
        public BookInfo()
        {
            cmd = new SqlCommand(); //初始化
            cmd.CommandType = CommandType.StoredProcedure; //设置文本的类型为存储过程
        }
        /// <summary>
        /// 按图书编号删除图书的方法
        /// </summary>
        /// <param name="bookid">实参</param>
        /// <returns>返回结果</returns>
        public bool DeleteBook(string bookid)
        {
            cmd.CommandText = "DeleteBook"; //设置文本参数为这个存储过程
            cmd.Parameters.Clear(); //清除参数
            cmd.Parameters.Add("@BookID", SqlDbType.VarChar, 50).Value = bookid; //添加参数,指定类型和大小
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
                return false; //如果出现异常也让用户看到假
            }
        }
        /// <summary>
        /// 按指定的书名和类型编号查找图书的信息,书名按模糊查找
        /// </summary>
        /// <param name="bookname">可模糊查找</param>
        /// <param name="classid">可为空</param>
        /// <returns>数据集</returns>
        public DataSet GetBookInfo(string bookname, string classid)
        {
            cmd.CommandText = "GetBookInfoByClassIDAndBookName";  //设置文本参数为这个存储过程
            cmd.Parameters.Clear(); //清除参数
            cmd.Parameters.Add("@ClassID", SqlDbType.Char, 1).Value = classid; //添加参数,指定类型和大小
            cmd.Parameters.Add("@BookName", SqlDbType.NVarChar, 50).Value = bookname; //添加参数,指定类型和大小
            DataSet ds = DBAccess.QueryData(cmd); //创建一个数据集变量用来存放调用底层后返回的值
            return ds; 
        }
        /// <summary>
        /// 按图书编号查找图书的信息
        /// </summary>
        /// <param name="bookid">实参</param>
        /// <returns>返回数据集</returns>
        public DataSet GetBookInfo(string bookid)
        {
            cmd.CommandText = "GetBookInfoByBookID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@BookID", SqlDbType.VarChar, 50).Value = bookid;
            DataSet ds = DBAccess.QueryData(cmd);
            return ds;
        }
        /// <summary>
        /// 按ISBN,图书名,作者,类别编号查找图书的信息,可模糊查找
        /// </summary>
        /// <param name="isbn">实参,可空</param>
        /// <param name="bookname">实参,可模糊查找</param>
        /// <param name="author">实参,可空</param>
        /// <param name="classid">实参,可空</param>
        /// <returns>数据集</returns>
        public DataSet GetBookInfo(string isbn, string bookname, string author, string classid)
        {
            cmd.CommandText = "GetBookInfoByCondition";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ISBN", SqlDbType.VarChar, 50).Value = isbn;
            cmd.Parameters.Add("@BookName", SqlDbType.NVarChar, 50).Value = bookname;
            cmd.Parameters.Add("@Author", SqlDbType.NVarChar, 50).Value = author;
            cmd.Parameters.Add("@ClassID", SqlDbType.Char, 1).Value = classid;
            DataSet ds = DBAccess.QueryData(cmd);
            return ds;
        }
        /// <summary>
        /// 插入图书信息
        /// </summary>
        /// <param name="bookid"></param>
        /// <param name="isbn"></param>
        /// <param name="bookname"></param>
        /// <param name="author"></param>
        /// <param name="publishdate"></param>
        /// <param name="bookversion"></param>
        /// <param name="wordcount"></param>
        /// <param name="pagecount"></param>
        /// <param name="publisher"></param>
        /// <param name="classid"></param>
        /// <returns>返回结果</returns>
        public bool InsertNewBook(string bookid, string isbn, string bookname, string author, DateTime publishdate, string bookversion, int wordcount, int pagecount, string publisher, string classid)
        {
            cmd.CommandText = "InsertNewBook";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@BookID", SqlDbType.VarChar, 50).Value = bookid;
            cmd.Parameters.Add("@ISBN", SqlDbType.Char, 20).Value = isbn;
            cmd.Parameters.Add("@BookName", SqlDbType.NVarChar, 50).Value = bookname;
            cmd.Parameters.Add("@Author", SqlDbType.NVarChar, 50).Value = author;
            cmd.Parameters.Add("@PublisherDate", SqlDbType.DateTime).Value = publishdate;
            cmd.Parameters.Add("@BookVersion", SqlDbType.NVarChar, 50).Value = bookversion;
            cmd.Parameters.Add("@WordCount", SqlDbType.Int).Value = wordcount;
            cmd.Parameters.Add("@PageCount", SqlDbType.SmallInt).Value = pagecount;
            cmd.Parameters.Add("@Publisher", SqlDbType.NVarChar, 50).Value = publisher;
            cmd.Parameters.Add("@ClassID", SqlDbType.Char, 1).Value = classid;
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
        /// 更新图书信息
        /// </summary>
        /// <param name="bookid"></param>
        /// <param name="isbn"></param>
        /// <param name="bookname"></param>
        /// <param name="author"></param>
        /// <param name="publishdate"></param>
        /// <param name="bookversion"></param>
        /// <param name="wordcount"></param>
        /// <param name="pagecount"></param>
        /// <param name="publisher"></param>
        /// <param name="classid"></param>
        /// <returns>返回结果</returns>
        public bool UpdateBookInfo(string bookid, string isbn, string bookname, string author, DateTime publishdate, string bookversion, int wordcount, int pagecount, string publisher, string classid)
        {
            cmd.CommandText = "UpdateBookInfo";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@BookID", SqlDbType.VarChar, 50).Value = bookid;
            cmd.Parameters.Add("@ISBN", SqlDbType.Char, 20).Value = isbn;
            cmd.Parameters.Add("@BookName", SqlDbType.NVarChar, 50).Value = bookname;
            cmd.Parameters.Add("@Author", SqlDbType.NVarChar, 50).Value = author;
            cmd.Parameters.Add("@PublisherDate", SqlDbType.DateTime).Value = publishdate;
            cmd.Parameters.Add("@BookVersion", SqlDbType.NVarChar, 50).Value = bookversion;
            cmd.Parameters.Add("@WordCount", SqlDbType.Int).Value = wordcount;
            cmd.Parameters.Add("@PageCount", SqlDbType.SmallInt).Value = pagecount;
            cmd.Parameters.Add("@Publisher", SqlDbType.NVarChar,50).Value = publisher;
            cmd.Parameters.Add("@ClassID", SqlDbType.Char, 1).Value = classid;
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
        /// 查看图书类型编号和类型名称
        /// </summary>
        /// <returns>返回数据集</returns>
        public DataSet GetAllBookClass()
        {
            cmd.CommandText = "GetAllBookClass";
            cmd.Parameters.Clear();
            DataSet ds = DBAccess.QueryData(cmd);
            return ds;
        }

        /// <summary>
        /// 按图书书名,ISBN,出版社分组,查看图书馆里有多少本
        /// </summary>
        /// <returns>返回数据集</returns>
        public DataSet GetBookStatisticInfo()
        {
            cmd.CommandText = "GetBookStatisticInfo";
            cmd.Parameters.Clear();
            DataSet ds = DBAccess.QueryData(cmd);
            return ds;
        }

        /// <summary>
        /// 通过图书编号在借阅表查找是否逾期,逾期则返回对应的天数
        /// </summary>
        /// <param name="bookID"></param>
        /// <returns></returns>
        public string IsOverdueDateTime(string bookID)
        {
            cmd.CommandText = "IsOverdueDateTime";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@BookID", SqlDbType.Char, 10).Value = bookID;
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
        /// 各个查询方法的集合，存储过程由参数传入
        /// </summary>
        /// <param name="procedure">存储过程名字</param>
        /// <returns>返回数据集</returns>
        public DataSet Overloads(string procedure)
        {
            cmd.CommandText = procedure;
            cmd.Parameters.Clear();
            DataSet ds = DBAccess.QueryData(cmd);
            return ds;
        }
    }
}
