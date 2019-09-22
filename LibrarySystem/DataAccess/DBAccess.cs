using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Library.DataAccess
{
    public class DBAccess
    {
        /// <summary>
        /// 执行insert，update，delete命令，返回受影响的行数
        /// </summary>
        /// <param name="cmd">要执行的命令</param>
        /// <returns>返回受影响的行数</returns>
        public static int ExecuteSQL(SqlCommand cmd)
        {
            //1.创建连接对象
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Mylibrary"].ConnectionString);
            //2.创建命令对象(不用创建，从参数传入)
            cmd.Connection = conn; //设置参数的连接属性
            try
            { //可能出现异常的语句

                //3.打开连接
                conn.Open();
                //4.执行命令
                int num = cmd.ExecuteNonQuery(); //执行SQL命令
                return num;
            }
            catch (Exception ex)
            { //抛出异常

                throw new DBException(ex);
            }
            finally
            { //出现异常后还继续运行的语句

                //5.关闭连接
                if (conn.State == ConnectionState.Open) //判断连接是否打开，如果打开就关闭连接
                {
                    conn.Close();
                }
            }
            
        }

        /// <summary>
        ///执行select命令，返回一项数据(首行首列) 
        /// </summary>
        /// <param name="cmd">要执行的命令</param>
        /// <returns>查到的一项数据(首行首列)</returns>
        public static object GetScalar(SqlCommand cmd)
        {
            //1.创建连接对象
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Mylibrary"].ConnectionString);
            //2.创建命令对象(不用创建，从参数传入)
            cmd.Connection = conn; //设置参数的连接属性
            try
            { //可能出现异常的语句

                //3.打开连接
                conn.Open();
                //4.执行命令
                object num = cmd.ExecuteScalar();//执行SQL命令
                return num;
            }
            catch (Exception ex)
            { //抛出异常

                throw new DBException(ex);
            }
            finally
            { //出现异常后还继续运行的语句

                //5.关闭连接
                if (conn.State == ConnectionState.Open) //判断连接是否打开，如果打开就关闭连接
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// 执行select命令，返回数据集
        /// </summary>
        /// <param name="cmd">要执行的命令</param>
        /// <returns>查到的数据集</returns>
        public static DataSet QueryData(SqlCommand cmd)
        {
            //1.创建连接对象
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Mylibrary"].ConnectionString);
            //2.创建命令对象(不用创建，从参数传入)
            cmd.Connection = conn; //设置参数的连接属性
            //2.1.创建数据适配器对象
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            //2.2.创建数据集对象
            DataSet ds = new DataSet();

            try
            { //可能出现异常的语句

                ////3.打开连接（因为数据集会自动打开连接）
                //conn.Open();
                //4.执行命令
                ada.Fill(ds); //填充数据集
                return ds;
            }
            catch (Exception ex)
            { //抛出异常

                throw new DBException(ex);
            }
            //finally
            //{ //出现异常后还继续运行的语句

            //    ////5.关闭连接（因为数据集会自动关闭连接）
            //    //if (conn.State == ConnectionState.Open) //判断连接是否打开，如果打开就关闭连接
            //    //{
            //    //    conn.Close();
            //    //}
            //}
        }
    }
}
