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
    public class ProductDAL : IDAL<Product>
    {
        private SqlCommand cmd;
        public ProductDAL()
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
        }

        public List<Product> FindByName(string name)
        {
            cmd.CommandText = "usp_GetProductByName";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@productName", SqlDbType.NVarChar, 6).Value = name;
            SqlDataReader reader = DBAccess.ExcuteReader(cmd);
            List<Product> list = new List<Product>();
            while(reader.Read())
            {
                Product c = new Product();
                c.ProductID = reader["ProductID"].ToString();
                c.ProductName = reader["ProductName"].ToString();
                c.SpellingCode = reader["spellingCode"].ToString();
                c.BarCode = reader["barcode"].ToString();
                c.Special = reader["special"].ToString();
                c.Unit = reader["unit"].ToString();
                c.Origin = reader["origin"].ToString();
                c.CategoryID = reader["categoryID"].ToString();
                c.PurchasePrice = Convert.ToDecimal(reader["purchasePrice"]);
                c.SalePrice = Convert.ToDecimal(reader["salePrice"]);
                c.Quantity = Convert.ToInt32(reader["quantity"]);
                list.Add(c);
            }
            reader.Close();
            return list;
        }
        public Product FindByID(string id)
        {
            cmd.CommandText = "usp_FindProductByID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@productID", SqlDbType.NVarChar, 6).Value = id;
            SqlDataReader reader = DBAccess.ExcuteReader(cmd);
            if (reader.Read())
            {
                Product c = new Product();
                c.ProductID = reader["ProductID"].ToString();
                c.ProductName = reader["ProductName"].ToString();
                c.SpellingCode = reader["spellingCode"].ToString();
                c.BarCode = reader["barcode"].ToString();
                c.Special = reader["special"].ToString();
                c.Unit = reader["unit"].ToString();
                c.Origin = reader["origin"].ToString();
                c.CategoryID = reader["categoryID"].ToString();
                c.PurchasePrice = Convert.ToDecimal(reader["purchasePrice"]);
                c.SalePrice = Convert.ToDecimal(reader["salePrice"]);
                c.Quantity = Convert.ToInt32(reader["quantity"]);
                reader.Close();
                return c;
            }
            else
            {
                reader.Close();
                return null;
            }
        }

        public List<Product> GetALL()
        {
            cmd.CommandText = "usp_SelectAllProducts";
            cmd.Parameters.Clear();
            SqlDataReader reader = DBAccess.ExcuteReader(cmd);
            List<Product> list = new List<Product>();
            while (reader.Read())
            {
                Product c = new Product();
                c.ProductID = reader["ProductID"].ToString();
                c.ProductName = reader["ProductName"].ToString();
                c.SpellingCode = reader["spellingCode"].ToString();
                c.BarCode = reader["barcode"].ToString();
                c.Special = reader["special"].ToString();
                c.Unit = reader["unit"].ToString();
                c.Origin = reader["origin"].ToString();
                c.CategoryID = reader["categoryID"].ToString();
                c.PurchasePrice = Convert.ToDecimal(reader["purchasePrice"]);
                c.SalePrice = Convert.ToDecimal(reader["salePrice"]);
                c.Quantity = Convert.ToInt32(reader["quantity"]);
                list.Add(c);
            }
            reader.Close();
            return list;
        }

        public bool Insert(Product o)
        {
            cmd.CommandText = "usp_InsertProduct";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@productID", SqlDbType.NVarChar, 6).Value = o.ProductID;
            cmd.Parameters.Add("@productName", SqlDbType.NVarChar, 80).Value = o.ProductName;
            cmd.Parameters.Add("@spellingCode", SqlDbType.NVarChar, 40).Value = o.SpellingCode;
            cmd.Parameters.Add("@barcode", SqlDbType.NVarChar, 14).Value = o.BarCode;
            cmd.Parameters.Add("@special", SqlDbType.NVarChar, 40).Value = o.Special;
            cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 6).Value = o.Unit;
            cmd.Parameters.Add("@origin", SqlDbType.NVarChar, 50).Value = o.Origin;
            cmd.Parameters.Add("@categoryID", SqlDbType.NVarChar, 6).Value = o.CategoryID;
            cmd.Parameters.Add("@purchasePrice", SqlDbType.Decimal).Value = o.PurchasePrice;
            cmd.Parameters.Add("@salePrice", SqlDbType.Decimal).Value = o.SalePrice;
            cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = o.Quantity;
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

        public bool Update(Product o)
        {
            cmd.CommandText = "usp_UpdateProduct";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@productID", SqlDbType.NVarChar, 6).Value = o.ProductID;
            cmd.Parameters.Add("@productName", SqlDbType.NVarChar, 80).Value = o.ProductName;
            cmd.Parameters.Add("@spellingCode", SqlDbType.NVarChar, 40).Value = o.SpellingCode;
            cmd.Parameters.Add("@barcode", SqlDbType.NVarChar, 14).Value = o.BarCode;
            cmd.Parameters.Add("@special", SqlDbType.NVarChar, 40).Value = o.Special;
            cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 6).Value = o.Unit;
            cmd.Parameters.Add("@origin", SqlDbType.NVarChar, 50).Value = o.Origin;
            cmd.Parameters.Add("@categoryID", SqlDbType.NVarChar, 6).Value = o.CategoryID;
            cmd.Parameters.Add("@purchasePrice", SqlDbType.Decimal).Value = o.PurchasePrice;
            cmd.Parameters.Add("@salePrice", SqlDbType.Decimal).Value = o.SalePrice;
            cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = o.Quantity;
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

        public bool Delete(Product o)
        {
            cmd.CommandText = "usp_DeleteProduct";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@productID", SqlDbType.NVarChar, 6).Value = o.ProductID;
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
