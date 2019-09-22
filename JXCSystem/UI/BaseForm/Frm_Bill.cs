using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QiuXingMing.BLL;
using QiuXingMing.Model;

namespace QiuXingMing.UI.BaseForm
{
    public partial class Frm_Bill : Form
    {
        protected PurchaseBillBLL pBLL; //订单BLL类的对象
        protected List<string> list; //创建字符串类型的泛型字段。存放列表
        protected PurchaseBill pBill; //存储订单的字段
        protected List<PurchaseDetail> detailList; //存储明细的列表

        protected PurchaseDetail detail_Delete; //存储要删除的一笔明细
        public Frm_Bill()
        {
            InitializeComponent();
            pBLL = new PurchaseBillBLL(); //初始化
            
        }

        private void Frm_Bill_Load(object sender, EventArgs e)
        {
            try
            {
                cbQuery.SelectedIndex = 0; //设置显示的内容为第一个选项

                dgPurchaseBill.AutoGenerateColumns = false; //取消自动创建列
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void BindSupplier()
        {
            try
            {
                cbSupplierID.DataSource = new SupplierBLL().GetALL();
                cbSupplierID.DisplayMember = "SupplierName";
                cbSupplierID.ValueMember = "SupplierID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cbQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbPurchaseID.DataSource = null;
                txtQueryValue.Text = "";
                if (cbQuery.SelectedIndex >= 0 && cbQuery.SelectedIndex <= 3)
                {
                    txtQueryValue.Enabled = true;
                    dtStartDate.Enabled = dtEndDate.Enabled = false;
                }
                else
                {
                    txtQueryValue.Enabled = false;
                    dtStartDate.Enabled = dtEndDate.Enabled = true;
                }
            }
            catch
            {
                
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string seach = ""; //存储查询条件
            DateTime startDate = new DateTime(); //用于存放开始日期
            DateTime endDate = new DateTime(); //用于存放结束日期
            try
            {
                if (cbQuery.SelectedIndex >= 0 && cbQuery.SelectedIndex <= 3) //判断用户选择的选项是否在这个范围
                {
                    seach = txtQueryValue.Text.Trim(); //从文本框取出查询值
                    if (seach == "") //判断是否为空
                    {
                        MessageBox.Show("请输入查询值！");
                        txtQueryValue.Focus();
                        return;
                    }
                    //按所选的下标执行对应的查询
                    if (cbQuery.SelectedIndex == 0)
                    {
                        list = pBLL.FindPurchaseIDByID(seach);
                        //lbPurchaseID.DataSource = list;
                    }
                    else if (cbQuery.SelectedIndex == 1)
                    {
                        list = pBLL.FindPurchaseIDByClerkName(seach);
                        //lbPurchaseID.DataSource = list;
                    }
                    else if (cbQuery.SelectedIndex == 2)
                    {
                        list = pBLL.FindPurchaseIDByExaminerName(seach);
                        //lbPurchaseID.DataSource = list;
                    }
                    else if (cbQuery.SelectedIndex == 3)
                    {
                        int on = Convert.ToInt32(seach); //转换不成功抛出异常
                        if (on < 0 || on > 2) //判断用户输入的是否在这个范围
                        {
                            MessageBox.Show("查询值只能为0、1、2 ; 0表示执行，1表示插销，2表示完成!");
                            txtQueryValue.Focus();
                            return;
                        }
                        list = pBLL.FindPurchaseIDByOnProcess(on);
                        //lbPurchaseID.DataSource = list;
                    }
                }
                else  //按日期查询
                {
                    startDate = dtStartDate.Value.Date; //从控件中取出开始日期
                    endDate = dtEndDate.Value.Date; //从控件中取出结束日期
                    list = pBLL.FindPurchaseIDByPurchaseDate(startDate, endDate);
                    //lbPurchaseID.DataSource = list;
                }
                if (list.Count == 0)
                {
                    lbPurchaseID.DataSource = null;
                    MessageBox.Show("没有查找到订单！");
                    return;
                }
                lbPurchaseID.DataSource = list; //讲查询的订单编号显示在列表框
                if (list.Count > 0)
                {
                    lbPurchaseID.SelectedIndex = -1; //取消反蓝
                }
            }
            catch (FormatException ) //捕获不同的异常进行不同的处理
            {
                MessageBox.Show("查询值只能为0、1、2 ; 0表示执行，1表示插销，2表示完成!");
                txtQueryValue.Focus();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbPurchaseID_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbPurchaseID.SelectedItem == null)
                {
                    return;
                }
                string index = lbPurchaseID.SelectedItem.ToString();
                pBill = pBLL.FindByID(index);
                detailList = pBill.DetailList;
                dtPurchaseDate.Value = pBill.PurchaseDate;
                if (pBill.StockDate == Convert.ToDateTime("0001.1.1"))
                {
                    txtStockDate.Text = "";
                }
                else
                {
                    txtStockDate.Text = pBill.StockDate.ToLongDateString();
                }

                txtPurchaseID.Text = pBill.PurchaseID;
                cbSupplierID.SelectedValue = pBill.SupplierID;

                if (pBill.OnProcess == 0)
                {
                    if (pBill.Examiner == "")
                    {
                        txtOnProcess.Text = "执行(未审核)";
                    }
                    else
                    {
                        txtOnProcess.Text = "执行(已审核)";
                    }
                }
                else if (pBill.OnProcess == 1)
                {
                    txtOnProcess.Text = "撤销";
                }
                else if (pBill.OnProcess == 2)
                {
                    txtOnProcess.Text = "完成";
                }
                txtMemo.Text = pBill.Memo;
                //显示明细
                if (detailList.Count == 0)
                {
                    dgPurchaseBill.DataSource = null;
                }
                else
                {
                    dgPurchaseBill.DataSource = detailList;
                }
                if (dgPurchaseBill.CurrentCell != null)
                {
                    dgPurchaseBill.CurrentCell.Selected = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgPurchaseBill_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                decimal price = 0;
                foreach (PurchaseDetail det in detailList)
                {
                    price += det.Account;
                }
                txtPrice.Text = price.ToString();
            }
            catch
            {

            }
        }

        private void dgPurchaseBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgPurchaseBill.CurrentRow.Selected = true;

                detail_Delete = detailList[e.RowIndex];
            }
            catch 
            {
                
            }
        }

        private void dgPurchaseBill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgPurchaseBill.Columns[e.ColumnIndex].Name == "阿西吧")
                {
                    e.Value = new ProductBLL().FindByID(e.Value.ToString()).ProductName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
