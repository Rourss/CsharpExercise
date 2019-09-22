using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QiuXingMing.DBUtility;
using QiuXingMing.Model;
using System.Data;
using System.Data.SqlClient;

namespace QiuXingMing.DAL
{
   public class CategoryDAL:IDAL<Category>
    {
       private SqlCommand cmd;
       public CategoryDAL()
       {
           cmd = new SqlCommand();
           cmd.CommandType = CommandType.StoredProcedure;
       }
       public List<Category> FindByName(string name)
       {
           cmd.CommandText = "usp_GetCategoryByName";
           cmd.Parameters.Clear();
           cmd.Parameters.Add("@categoryName", SqlDbType.NVarChar, 6).Value = name;
           SqlDataReader reader = DBAccess.ExcuteReader(cmd);
           List<Category> list = new List<Category>();
           while (reader.Read())
           {
               Category c = new Category();
               c.CategoryID = reader["CategoryID"].ToString();
               c.CategoryName = reader["CategoryName"].ToString();
               list.Add(c);
           }
           reader.Close();
           return list;
       }
        public Category FindByID(string id)
        {
            cmd.CommandText = "usp_FindCategoryByID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@categoryID", SqlDbType.NVarChar, 6).Value = id;
            SqlDataReader reader = DBAccess.ExcuteReader(cmd);
            if (reader.Read())
            {
                Category c = new Category();
                c.CategoryID = reader["CategoryID"].ToString();
                c.CategoryName = reader["CategoryName"].ToString();
                reader.Close();
                return c;
            }
            else
            {
                reader.Close();
                return null;
            }
        }

        public List<Category> GetALL()
        {
            cmd.CommandText = "usp_SelectAllCategories";
            cmd.Parameters.Clear();
            SqlDataReader reader = DBAccess.ExcuteReader(cmd);
            List<Category> list = new List<Category>();
            while (reader.Read())
            {
                Category c = new Category();
                c.CategoryID=reader["categoryID"].ToString();
                c.CategoryName=reader["categoryName"].ToString();
                list.Add(c);
            }
            reader.Close();
            return list;
        }

        public bool Insert(Category o)
        {
            cmd.CommandText = "usp_InsertCategory";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@categoryID", SqlDbType.NVarChar, 6).Value = o.CategoryID;
            cmd.Parameters.Add("@categoryName", SqlDbType.NVarChar, 80).Value = o.CategoryName;
            try
            {
                int num = DBAccess.ExecuteSQL(cmd);
                if(num>0)
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

        public bool Update(Category o)
        {
            cmd.CommandText = "usp_UpdateCategory";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@categoryID", SqlDbType.NVarChar, 6).Value = o.CategoryID;
            cmd.Parameters.Add("@categoryName", SqlDbType.NVarChar, 80).Value = o.CategoryName;
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

        public bool Delete(Category o)
        {
            cmd.CommandText = "usp_DeleteCategory";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@categoryID", SqlDbType.NVarChar, 6).Value = o.CategoryID;
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
