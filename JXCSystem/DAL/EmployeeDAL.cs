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
   public class EmployeeDAL:IDAL<Employee>
    {
       private SqlCommand cmd;
       public EmployeeDAL()
       {
           cmd = new SqlCommand();
           cmd.CommandType = CommandType.StoredProcedure;
       }
       public List<Employee> FindByName(string name)
       {
           cmd.CommandText = "usp_GetEmployeeByName";
           cmd.Parameters.Clear();
           cmd.Parameters.Add("@employeeName", SqlDbType.NVarChar, 6).Value = name;
           SqlDataReader reader = DBAccess.ExcuteReader(cmd);
           List<Employee> list = new List<Employee>();
           while (reader.Read())
           {
               Employee c = new Employee();
               c.EmployeeID = reader["employeeID"].ToString();
               c.EmployeeName = reader["employeeName"].ToString();
               c.Sex = (bool)reader["sex"];
               c.Birthday = Convert.ToDateTime(reader["birthday"]);
               c.Brief = reader["brief"].ToString();
               list.Add(c);
           }
           reader.Close();
           return list;
       }
       public Employee FindByID(string id)
       {
           cmd.CommandText = "usp_FindEmployeeByID";
           cmd.Parameters.Clear();
           cmd.Parameters.Add("@employeeID", SqlDbType.NVarChar, 6).Value = id;
           SqlDataReader reader = DBAccess.ExcuteReader(cmd);
           if (reader.Read())
           {
               Employee c = new Employee();
               c.EmployeeID = reader["employeeID"].ToString();
               c.EmployeeName = reader["employeeName"].ToString();
               c.Sex = (bool)reader["sex"];
               c.Birthday = Convert.ToDateTime(reader["birthday"]);
               c.Brief = reader["brief"].ToString();
               reader.Close();
               return c;
           }
           else
           {
               reader.Close();
               return null;
           }
       }

       public List<Employee> GetALL()
       {
           cmd.CommandText = "usp_SelectAllEmployes";
           cmd.Parameters.Clear();
           SqlDataReader reader = DBAccess.ExcuteReader(cmd);
           List<Employee> list = new List<Employee>();
           while (reader.Read())
           {
               Employee c = new Employee();
               c.EmployeeID = reader["employeeID"].ToString();
               c.EmployeeName = reader["employeeName"].ToString();
               c.Sex = (bool)reader["sex"];
               c.Birthday = Convert.ToDateTime(reader["birthday"]);
               c.Brief = reader["brief"].ToString();
               list.Add(c);
           }
           reader.Close();
           return list;
       }

       public bool Insert(Employee o)
       {
           cmd.CommandText = "usp_InsertEmployee";
           cmd.Parameters.Clear();
           cmd.Parameters.Add("@employeeID", SqlDbType.NVarChar, 6).Value = o.EmployeeID;
           cmd.Parameters.Add("@employeeName", SqlDbType.NVarChar, 80).Value = o.EmployeeName;
           cmd.Parameters.Add("@sex", SqlDbType.Bit).Value = o.Sex;
           cmd.Parameters.Add("@birthday", SqlDbType.DateTime).Value = o.Birthday;
           cmd.Parameters.Add("@brief", SqlDbType.NVarChar).Value = o.Brief;
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

       public bool Update(Employee o)
       {
           cmd.CommandText = "usp_UpdateEmployee";
           cmd.Parameters.Clear();
           cmd.Parameters.Add("@employeeID", SqlDbType.NVarChar, 6).Value = o.EmployeeID;
           cmd.Parameters.Add("@employeeName", SqlDbType.NVarChar, 80).Value = o.EmployeeName;
           cmd.Parameters.Add("@sex", SqlDbType.Bit).Value = o.Sex;
           cmd.Parameters.Add("@birthday", SqlDbType.DateTime).Value = o.Birthday;
           cmd.Parameters.Add("@brief", SqlDbType.NVarChar).Value = o.Brief;
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

       public bool Delete(Employee o)
       {
           cmd.CommandText = "usp_DeleteEmployee";
           cmd.Parameters.Clear();
           cmd.Parameters.Add("@employeeID", SqlDbType.NVarChar, 6).Value = o.EmployeeID;
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
