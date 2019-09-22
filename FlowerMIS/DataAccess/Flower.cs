using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using FlowerMIS.Comm;

namespace FlowerMIS.DataAccess
{
   public class Flower
    {
        private SqlCommand cmd; //字段
        private Photo ph;
        public Flower()
        {
            cmd = new SqlCommand(); //初始化
            ph = new Photo();
            cmd.CommandType = CommandType.StoredProcedure; //设置文本的类型为存储过程
        }
       /// <summary>
       /// 通过花卉编号来删除花卉
       /// </summary>
       /// <param name="flowerID"></param>
       /// <returns></returns>
        public bool DelFlower(string flowerID)
        {
            cmd.CommandText = "DelFlower"; //设置文本参数为这个存储过程
            cmd.Parameters.Clear(); //清除参数
            cmd.Parameters.Add("@flowerID", SqlDbType.VarChar, 50).Value = flowerID; //添加参数,指定类型和大小
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
       /// 新添花卉的方法(无照片)
       /// </summary>
       /// <param name="flowerID"></param>
       /// <param name="flowerName"></param>
       /// <param name="flowerType"></param>
       /// <param name="price"></param>
       /// <param name="flowerStatu"></param>
       /// <returns></returns>
        public bool InsertFlowerNotPhoto(string flowerID, string flowerName, string flowerType, double price, int flowerStatus)
        {
            cmd.CommandText = "InsertFlower";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@flowerID", SqlDbType.Char, 10).Value = flowerID;
            cmd.Parameters.Add("@flowerName", SqlDbType.VarChar, 50).Value = flowerName;
            cmd.Parameters.Add("@flowerType", SqlDbType.VarChar, 50).Value = flowerType;
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = price;
            cmd.Parameters.Add("@flowerStatus", SqlDbType.Bit).Value = flowerStatus;
            cmd.Parameters.Add("@flowerphoto", SqlDbType.Image).Value = Convert.DBNull;
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
       /// 新添花卉的方法(有照片)
       /// </summary>
       /// <param name="flowerID"></param>
       /// <param name="flowerName"></param>
       /// <param name="flowerType"></param>
       /// <param name="price"></param>
       /// <param name="flowerStatu"></param>
       /// <param name="flowerPhoto"></param>
       /// <returns></returns>
        public bool InsertFlower(string flowerID, string flowerName, string flowerType, double price, int flowerStatus, string flowerPhoto)
        {
            cmd.CommandText = "InsertFlower";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@flowerID", SqlDbType.Char, 10).Value = flowerID;
            cmd.Parameters.Add("@flowerName", SqlDbType.VarChar, 50).Value = flowerName;
            cmd.Parameters.Add("@flowerType", SqlDbType.VarChar, 50).Value = flowerType;
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = price;
            cmd.Parameters.Add("@flowerStatus", SqlDbType.Bit).Value = flowerStatus;
            cmd.Parameters.Add("@flowerPhoto", SqlDbType.Image).Value = ph.ReadPhoto(flowerPhoto);
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
       /// 更新花卉信息的方法(有照片)
       /// </summary>
       /// <param name="flowerID"></param>
       /// <param name="flowerName"></param>
       /// <param name="flowerType"></param>
       /// <param name="price"></param>
       /// <param name="flowerStatu"></param>
       /// <returns></returns>
        public bool UpdateFlower(string flowerID, string flowerName, string flowerType, double price, int flowerStatus,string flowerPhoto)
        {
            cmd.CommandText = "UpdateFlower";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@flowerID", SqlDbType.Char, 10).Value = flowerID;
            cmd.Parameters.Add("@flowerName", SqlDbType.VarChar, 50).Value = flowerName;
            cmd.Parameters.Add("@flowerType", SqlDbType.VarChar, 50).Value = flowerType;
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = price;
            cmd.Parameters.Add("@flowerStatus", SqlDbType.Bit).Value = flowerStatus;
            cmd.Parameters.Add("@flowerPhoto", SqlDbType.Image).Value = ph.ReadPhoto(flowerPhoto);
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
       /// 更新花卉信息的方法(清空照片)
       /// </summary>
       /// <param name="flowerID"></param>
       /// <param name="flowerName"></param>
       /// <param name="flowerType"></param>
       /// <param name="price"></param>
       /// <param name="flowerStatu"></param>
       /// <returns></returns>
        public bool UpdateFlowerDelPhoto(string flowerID, string flowerName, string flowerType, double price, int flowerStatus)
        {
            cmd.CommandText = "UpdateFlower";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@flowerID", SqlDbType.Char, 10).Value = flowerID;
            cmd.Parameters.Add("@flowerName", SqlDbType.VarChar, 50).Value = flowerName;
            cmd.Parameters.Add("@flowerType", SqlDbType.VarChar, 50).Value = flowerType;
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = price;
            cmd.Parameters.Add("@flowerStatus", SqlDbType.Bit).Value = flowerStatus;
            cmd.Parameters.Add("@flowerPhoto", SqlDbType.Image).Value = Convert.DBNull;
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
       /// 更新花卉信息的方法(维持原样)
       /// </summary>
       /// <param name="flowerID"></param>
       /// <param name="flowerName"></param>
       /// <param name="flowerType"></param>
       /// <param name="price"></param>
       /// <param name="flowerStatu"></param>
       /// <param name="flowerPhoto"></param>
       /// <returns></returns>
        public bool UpdateFlowerAndPhoto(string flowerID, string flowerName, string flowerType, double price, int flowerStatus,byte[] flowerPhoto)
        {
            cmd.CommandText = "UpdateFlower";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@flowerID", SqlDbType.Char, 10).Value = flowerID;
            cmd.Parameters.Add("@flowerName", SqlDbType.VarChar, 50).Value = flowerName;
            cmd.Parameters.Add("@flowerType", SqlDbType.VarChar, 50).Value = flowerType;
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = price;
            cmd.Parameters.Add("@flowerStatus", SqlDbType.Bit).Value = flowerStatus;
            cmd.Parameters.Add("@flowerPhoto", SqlDbType.Image).Value = flowerPhoto;
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
       /// 通过花卉名和花卉类别查找花卉信息(花卉名可模糊)
       /// </summary>
       /// <param name="flowerName"></param>
       /// <param name="flowerType"></param>
       /// <returns></returns>
        public DataSet GetFlowerByFlowerNameAndFlowerType(string flowerName, string flowerType)
        {
            cmd.CommandText = "GetFlowerByFlowerNameAndFlowerType";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@flowerName", SqlDbType.VarChar, 50).Value = flowerName;
            cmd.Parameters.Add("@flowerType", SqlDbType.NChar, 10).Value = flowerType;
            DataSet ds = DBAccess.QueryData(cmd);
            return ds;
        }
    }
}
