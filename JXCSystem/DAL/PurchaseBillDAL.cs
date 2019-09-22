using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QiuXingMing.Model;
using System.Data;
using System.Data.SqlClient;
using QiuXingMing.DBUtility;


namespace QiuXingMing.DAL
{
   public class PurchaseBillDAL:IDAL<PurchaseBill>
    {
        private SqlCommand cmd;
        public PurchaseBillDAL()
        {
            cmd=new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
        }
        public List<string> FindPurchaseIDByID(string id)
        {
            cmd.CommandText = "usp_FindPurchaseIDByID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@purchaseID", SqlDbType.NVarChar, 12).Value = id;
            SqlDataReader reader = DBAccess.ExcuteReader(cmd);
            List<string> list =new List<string>();
            while (reader.Read())
            {
                string purchaseID = reader["PurchaseID"].ToString();
                list.Add(purchaseID);
            }
            reader.Close();
            return list;
        }
        public List<string> FindPurchaseIDByClerkName(string name)
        {
            cmd.CommandText = "usp_FindPurchaseIDByClerkName";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@employeeName", SqlDbType.NVarChar, 80).Value = name;
            SqlDataReader reader = DBAccess.ExcuteReader(cmd);
            List<string> list = new List<string>();
            while (reader.Read())
            {
                string purchaseID = reader["PurchaseID"].ToString();
                list.Add(purchaseID);
            }
            reader.Close();
            return list;
        }
        public List<string> FindPurchaseIDByExaminerName(string name)
        {
            cmd.CommandText = "usp_FindPurchaseIDByExaminerName";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@employeeName", SqlDbType.NVarChar, 80).Value = name;
            SqlDataReader reader = DBAccess.ExcuteReader(cmd);
            List<string> list = new List<string>();
            while (reader.Read())
            {
                string purchaseID = reader["PurchaseID"].ToString();
                list.Add(purchaseID);
            }
            reader.Close();
            return list;
        }
        public List<string> FindPurchaseIDByOnProcess(int process)
        {
            cmd.CommandText = "usp_FindPurchaseIDByOnProcess";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@onProcess", SqlDbType.SmallInt).Value = process;
            SqlDataReader reader = DBAccess.ExcuteReader(cmd);
            List<string> list = new List<string>();
            while (reader.Read())
            {
                string purchaseID = reader["PurchaseID"].ToString();
                list.Add(purchaseID);
            }
            reader.Close();
            return list;
        }
        public List<string> FindPurchaseIDByPurchaseDate(DateTime start,DateTime end)
        {
            cmd.CommandText = "usp_FindPurchaseIDByPurchaseDate";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@startDate", SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@endDate", SqlDbType.DateTime).Value = end;
            SqlDataReader reader = DBAccess.ExcuteReader(cmd);
            List<string> list = new List<string>();
            while (reader.Read())
            {
                string purchaseID = reader["PurchaseID"].ToString();
                list.Add(purchaseID);
            }
            reader.Close();
            return list;
        }


        public PurchaseBill FindByID(string id)
        {
            //1.从明细表中查出明细信息
            cmd.CommandText = "usp_FindPurchaseBillDetailsByPurchaseID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@puchaseID", SqlDbType.NVarChar, 12).Value = id;
            SqlDataReader reader = DBAccess.ExcuteReader(cmd);
            List<PurchaseDetail> detailList = new List<PurchaseDetail>();
            while (reader.Read())
            {
                PurchaseDetail pDetail = new PurchaseDetail();
                pDetail.PurchaseID = reader["PurchaseID"].ToString();
                pDetail.PurchaseDetailID = reader["PurchaseDetailID"].ToString();
                pDetail.ProductID = reader["ProductID"].ToString();
                pDetail.PurchasePrice = Convert.ToDecimal(reader["PurchasePrice"]);
                pDetail.Quantity = reader["Quantity"].ToString();
                detailList.Add(pDetail);
            }
            reader.Close();

            //2.从订单表中读出订单信息
            cmd.CommandText = "usp_FindPurchaseBillByID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@puchaseID", SqlDbType.NVarChar, 12).Value = id;
            SqlDataReader reader2 = DBAccess.ExcuteReader(cmd);
            if (reader2.Read())
            {
                PurchaseBill pBill = new PurchaseBill();
                pBill.PurchaseID = reader2["PurchaseID"].ToString();
                pBill.SupplierID = reader2["SupplierID"].ToString();
                pBill.PurchaseDate = Convert.ToDateTime(reader2["PurchaseDate"]);
                if (reader2["StockDate"] != Convert.DBNull)
                {
                    pBill.StockDate = Convert.ToDateTime(reader2["StockDate"]);
                }
                else
                {
                    pBill.StockDate = Convert.ToDateTime("0001.1.1"); //当数据库为空时，给默认值
                }
                pBill.Clerk = reader2["Clerk"].ToString();
                pBill.Examiner = reader2["Examiner"].ToString(); //当数据库为空时，自动给空串
                pBill.Custodian = reader2["Custodian"].ToString(); //当数据库为空时，自动给空串
                pBill.OnProcess = Convert.ToInt16(reader2["OnProcess"]);
                pBill.Memo = reader2["Memo"].ToString(); //当数据库为空时，自动给空串
                pBill.DetailList = detailList;
                reader2.Close();
                return pBill;
            }
            else
            {
                reader2.Close();
                return null;
            }
        }

        public List<PurchaseBill> GetALL()
        {
            throw new NotImplementedException();
        }

        public bool Insert(PurchaseBill o)
        {
            SqlTransaction tran = DBAccess.ExcuteSQLTransaction(cmd);
            try
            {
                //1.插入到订单表中
                cmd.CommandText = "usp_InsertPurchaseBill";
                cmd.Parameters.Clear();
                SetParameters(o);
                cmd.ExecuteNonQuery(); //执行命令

                //2.将所有明细插入到明细表
                foreach (PurchaseDetail detail in o.DetailList)
                {
                    cmd.CommandText = "usp_InsertPurchaseDetail";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@purchaseID", SqlDbType.NVarChar, 12).Value = detail.PurchaseID;
                    cmd.Parameters.Add("@purchaseDetailID", SqlDbType.SmallInt).Value = detail.PurchaseDetailID;
                    cmd.Parameters.Add("@productID", SqlDbType.NVarChar, 6).Value = detail.ProductID;
                    cmd.Parameters.Add("@purchasePrice", SqlDbType.Decimal).Value = detail.PurchasePrice;
                    cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = detail.Quantity;
                    cmd.ExecuteNonQuery(); //执行命令
                }
                tran.Commit(); //提交事务
                return true;
            }
            catch 
            {
                tran.Rollback(); //回滚事务
                return false;
            }
            finally
            {
                DBAccess.CloseConnection();
            }
        }

        private void SetParameters(PurchaseBill o)
        {
            cmd.Parameters.Add("@purchaseID", SqlDbType.NVarChar, 12).Value = o.PurchaseID;
            cmd.Parameters.Add("@supplierID", SqlDbType.NVarChar, 6).Value = o.SupplierID;
            cmd.Parameters.Add("@purchaseDate", SqlDbType.DateTime).Value = o.PurchaseDate;
            if (o.StockDate != Convert.ToDateTime("0001.1.1"))
            {
                cmd.Parameters.Add("@stockDate", SqlDbType.DateTime).Value = o.StockDate;
            }
            else
            {
                cmd.Parameters.Add("@stockDate", SqlDbType.DateTime).Value = Convert.DBNull;

            }
            cmd.Parameters.Add("@clerk", SqlDbType.NVarChar, 6).Value = o.Clerk;

            if (o.Examiner != "")
            {
                cmd.Parameters.Add("@examiner", SqlDbType.NVarChar, 6).Value = o.Examiner;
            }
            else
            {
                cmd.Parameters.Add("@examiner", SqlDbType.NVarChar, 6).Value = Convert.DBNull;
            }
            if (o.Custodian != "")
            {
                cmd.Parameters.Add("@custodian", SqlDbType.NVarChar, 6).Value = o.Custodian;
            }
            else
            {
                cmd.Parameters.Add("@custodian", SqlDbType.NVarChar, 6).Value = Convert.DBNull;
            }
            cmd.Parameters.Add("@onProcess", SqlDbType.SmallInt).Value = o.OnProcess;

            if (o.Memo != "")
            {
                cmd.Parameters.Add("@memo", SqlDbType.NVarChar, 100).Value = o.Memo;
            }
            else
            {
                cmd.Parameters.Add("@memo", SqlDbType.NVarChar, 100).Value = Convert.DBNull;
            }
        }

        public bool Update(PurchaseBill o)
        {
            SqlTransaction tran = DBAccess.ExcuteSQLTransaction(cmd);
            try
            {
                //1.修改订单表中
                cmd.CommandText = "usp_UpdatePurchaseBill";
                cmd.Parameters.Clear();
                SetParameters(o);
                cmd.ExecuteNonQuery(); //执行命令

                //2.删除所有明细
                cmd.CommandText = "usp_DeletePurchaseDetail";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@purchaseID", SqlDbType.NVarChar, 12).Value = o.PurchaseID;
                cmd.ExecuteNonQuery(); //执行命令

                //2.将所有明细插入到明细表
                foreach (PurchaseDetail detail in o.DetailList)
                {
                    cmd.CommandText = "usp_InsertPurchaseDetail";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@purchaseID", SqlDbType.NVarChar, 12).Value = detail.PurchaseID;
                    cmd.Parameters.Add("@purchaseDetailID", SqlDbType.SmallInt).Value = detail.PurchaseDetailID;
                    cmd.Parameters.Add("@productID", SqlDbType.NVarChar, 6).Value = detail.ProductID;
                    cmd.Parameters.Add("@purchasePrice", SqlDbType.Decimal).Value = detail.PurchasePrice;
                    cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = detail.Quantity;
                    cmd.ExecuteNonQuery(); //执行命令
                }
                tran.Commit(); //提交事务
                return true;
            }
            catch
            {
                tran.Rollback(); //回滚事务
                return false;
            }
            finally
            {
                DBAccess.CloseConnection();
            }
        }

        public bool Delete(PurchaseBill o)
        {
            throw new NotImplementedException();
        }
       public string CreatePurchaseID(DateTime purchaseDate)
        {
            cmd.CommandText = "usp_CreatePurchaseID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@purchaseDate", SqlDbType.DateTime).Value = purchaseDate;
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
    }
}
