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
   public class SupplierDAL:IDAL<Supplier>
    {
       private SqlCommand cmd;
       public SupplierDAL()
       {
           cmd = new SqlCommand();
           cmd.CommandType = CommandType.StoredProcedure;
       }
       public List<Supplier> FindByName(string name)
       {
           cmd.CommandText = "usp_GetSupplierByName";
           cmd.Parameters.Clear();
           cmd.Parameters.Add("@supplierName", SqlDbType.NVarChar, 6).Value = name;
           SqlDataReader reader = DBAccess.ExcuteReader(cmd);
           List<Supplier> list = new List<Supplier>();
           while (reader.Read())
           {
               Supplier c = new Supplier();
               c.SupplierID = reader["supplierID"].ToString();
               c.SupplierName = reader["supplierName"].ToString();
               c.SpellingCode = reader["spellingCode"].ToString();
               c.Address = reader["address"].ToString();
               c.ZipCode = reader["zipCode"].ToString();
               c.Tel = reader["tel"].ToString();
               c.Fax = reader["fax"].ToString();
               c.BankName = reader["bankName"].ToString();
               c.BankAccount = reader["bankAccount"].ToString();
               c.Contacter = reader["contacter"].ToString();
               c.Email = reader["email"].ToString();
               list.Add(c);
           }
           reader.Close();
           return list;
       }
       public Supplier FindByID(string id)
       {
           cmd.CommandText = "usp_FindSupplierByID";
           cmd.Parameters.Clear();
           cmd.Parameters.Add("@supplierID", SqlDbType.NVarChar, 6).Value = id;
           SqlDataReader reader = DBAccess.ExcuteReader(cmd);
           if (reader.Read())
           {
               Supplier c = new Supplier();
               c.SupplierID = reader["supplierID"].ToString();
               c.SupplierName=reader["supplierName"].ToString();
               c.SpellingCode = reader["spellingCode"].ToString();
               c.Address = reader["address"].ToString();
               c.ZipCode = reader["zipCode"].ToString();
               c.Tel = reader["tel"].ToString();
               c.Fax = reader["fax"].ToString();
               c.BankName = reader["bankName"].ToString();
               c.BankAccount = reader["bankAccount"].ToString();
               c.Contacter = reader["contacter"].ToString();
               c.Email = reader["email"].ToString();
               reader.Close();
               return c;
           }
           else
           {
               reader.Close();
               return null;
           }
       }

       public List<Supplier> GetALL()
       {
           cmd.CommandText = "usp_SelectSupplier";
           cmd.Parameters.Clear();
           SqlDataReader reader = DBAccess.ExcuteReader(cmd);
           List<Supplier> list = new List<Supplier>();
           while (reader.Read())
           {
               Supplier c = new Supplier();
               c.SupplierID = reader["supplierID"].ToString();
               c.SupplierName = reader["supplierName"].ToString();
               c.SpellingCode = reader["spellingCode"].ToString();
               c.Address = reader["address"].ToString();
               c.ZipCode = reader["zipCode"].ToString();
               c.Tel = reader["tel"].ToString();
               c.Fax = reader["fax"].ToString();
               c.BankName = reader["bankName"].ToString();
               c.BankAccount = reader["bankAccount"].ToString();
               c.Contacter = reader["contacter"].ToString();
               c.Email = reader["email"].ToString();
               list.Add(c);
           }
           reader.Close();
           return list;
       }

       public bool Insert(Supplier o)
       {
           cmd.CommandText = "usp_InsertSupplier";
           cmd.Parameters.Clear();
           cmd.Parameters.Add("@supplierID", SqlDbType.NVarChar, 6).Value = o.SupplierID;
           cmd.Parameters.Add("@supplierName", SqlDbType.NVarChar, 80).Value = o.SupplierName;
           cmd.Parameters.Add("@spellingCode", SqlDbType.NVarChar, 20).Value = o.SpellingCode;
           cmd.Parameters.Add("@address", SqlDbType.NVarChar, 80).Value = o.Address;
           cmd.Parameters.Add("@zipCode", SqlDbType.Char, 6).Value = o.ZipCode;
           cmd.Parameters.Add("@tel", SqlDbType.NVarChar, 20).Value = o.Tel;
           cmd.Parameters.Add("@fax", SqlDbType.NVarChar, 20).Value = o.Fax;
           cmd.Parameters.Add("@bankName", SqlDbType.NVarChar, 40).Value = o.BankName;
           cmd.Parameters.Add("@bankAccount", SqlDbType.NVarChar, 50).Value = o.BankAccount;
           cmd.Parameters.Add("@contacter", SqlDbType.NVarChar, 20).Value = o.Contacter;
           cmd.Parameters.Add("@email", SqlDbType.NVarChar, 30).Value = o.Email;
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

       public bool Update(Supplier o)
       {
           cmd.CommandText = "usp_UpdateSupplier";
           cmd.Parameters.Clear();
           cmd.Parameters.Add("@supplierID", SqlDbType.NVarChar, 6).Value = o.SupplierID;
           cmd.Parameters.Add("@supplierName", SqlDbType.NVarChar, 80).Value = o.SupplierName;
           cmd.Parameters.Add("@spellingCode", SqlDbType.NVarChar, 20).Value = o.SpellingCode;
           cmd.Parameters.Add("@address", SqlDbType.NVarChar, 80).Value = o.Address;
           cmd.Parameters.Add("@zipCode", SqlDbType.Char, 6).Value = o.ZipCode;
           cmd.Parameters.Add("@tel", SqlDbType.NVarChar, 20).Value = o.Tel;
           cmd.Parameters.Add("@fax", SqlDbType.NVarChar, 20).Value = o.Fax;
           cmd.Parameters.Add("@bankName", SqlDbType.NVarChar, 40).Value = o.BankName;
           cmd.Parameters.Add("@bankAccount", SqlDbType.NVarChar, 50).Value = o.BankAccount;
           cmd.Parameters.Add("@contacter", SqlDbType.NVarChar, 20).Value = o.Contacter;
           cmd.Parameters.Add("@email", SqlDbType.NVarChar, 30).Value = o.Email;
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

       public bool Delete(Supplier o)
       {
           cmd.CommandText = "usp_DeleteSupplier";
           cmd.Parameters.Clear();
           cmd.Parameters.Add("@supplierID", SqlDbType.NVarChar, 6).Value = o.SupplierID;
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
