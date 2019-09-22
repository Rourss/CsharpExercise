using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QiuXingMing.DBUtility;
using QiuXingMing.Model;
using System.Data.SqlClient;
using System.Data;

namespace QiuXingMing.DAL
{
   public class CustomerDAL : IDAL<Customer>
    {
        private SqlCommand cmd;
        public CustomerDAL()
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
        }
        public List<Customer> FindByName(string name)
        {
            cmd.CommandText = "usp_GetCustomerByName";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@customerName", SqlDbType.NVarChar, 6).Value = name;
            SqlDataReader reader = DBAccess.ExcuteReader(cmd);
            List<Customer> list = new List<Customer>();
            while (reader.Read())
            {
                Customer c = new Customer();
                c.CustomerID = reader["customerID"].ToString();
                c.CustomerName = reader["customerName"].ToString();
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
        public Customer FindByID(string id)
        {
            cmd.CommandText = "usp_FindCustomerByID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@customerID", SqlDbType.NVarChar, 6).Value = id;
            SqlDataReader reader = DBAccess.ExcuteReader(cmd);
            if (reader.Read())
            {
                Customer c = new Customer();
                c.CustomerID = reader["customerID"].ToString();
                c.CustomerName = reader["customerName"].ToString();
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

        public List<Customer> GetALL()
        {
            cmd.CommandText = "usp_SelectAllCustomers";
            cmd.Parameters.Clear();
            SqlDataReader reader = DBAccess.ExcuteReader(cmd);
            List<Customer> list = new List<Customer>();
            while (reader.Read())
            {
                Customer c = new Customer();
                c.CustomerID = reader["customerID"].ToString();
                c.CustomerName = reader["customerName"].ToString();
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

        public bool Insert(Customer o)
        {
            cmd.CommandText = "usp_InsertCustomer";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@customerID", SqlDbType.NVarChar, 6).Value = o.CustomerID;
            cmd.Parameters.Add("@customerName", SqlDbType.NVarChar, 80).Value = o.CustomerName;
            cmd.Parameters.Add("@spellingCode", SqlDbType.NVarChar, 80).Value = o.SpellingCode;
            cmd.Parameters.Add("@address", SqlDbType.NVarChar, 20).Value = o.Address;
            cmd.Parameters.Add("@zipCode", SqlDbType.NVarChar, 6).Value = o.ZipCode;
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

        public bool Update(Customer o)
        {
            cmd.CommandText = "usp_UpdateCustomer";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@customerID", SqlDbType.NVarChar, 6).Value = o.CustomerID;
            cmd.Parameters.Add("@customerName", SqlDbType.NVarChar, 80).Value = o.CustomerName;
            cmd.Parameters.Add("@spellingCode", SqlDbType.NVarChar, 80).Value = o.SpellingCode;
            cmd.Parameters.Add("@address", SqlDbType.NVarChar, 20).Value = o.Address;
            cmd.Parameters.Add("@zipCode", SqlDbType.NVarChar, 6).Value = o.ZipCode;
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

        public bool Delete(Customer o)
        {
            cmd.CommandText = "usp_DeleteCustomer";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@customerID", SqlDbType.NVarChar, 6).Value = o.CustomerID;
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
