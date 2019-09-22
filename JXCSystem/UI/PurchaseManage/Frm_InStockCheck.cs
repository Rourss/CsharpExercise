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

namespace QiuXingMing.UI.PurchaseManage
{
    public partial class Frm_InStockCheck : BaseForm.Frm_Bill
    {
        private EmployeeBLL eBLL;
        private string userID= "3";

        public string UserID
        {
            set { userID = value; }
        }
        public Frm_InStockCheck()
        {
            InitializeComponent();
            eBLL = new EmployeeBLL();
        }

        private void lbPurchaseID_Click(object sender, EventArgs e)
        {
            if (lbPurchaseID.SelectedItem == null)
            {
                return;
            }
            try
            {
                txtClerkName.Text = eBLL.FindByID(pBill.Clerk).EmployeeName;
                if (pBill.Examiner == "")
                {
                    txtExaminerName.Text = "";
                }
                else
                {
                    txtExaminerName.Text = eBLL.FindByID(pBill.Examiner).EmployeeName;
                }
                if (pBill.Custodian == "")
                {
                    txtCustodianName.Text = "";
                }
                else
                {
                    txtCustodianName.Text = eBLL.FindByID(pBill.Custodian).EmployeeName;
                }

                txtMemo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCustodianS_Click(object sender, EventArgs e)
        {
            try
            {
                if (pBill == null)
                {
                    MessageBox.Show("请选择要检验的一笔订单！");
                    return;
                }
                if (pBill.Examiner == "")
                {
                    MessageBox.Show("该订单未审核，不能进行货品检验入库！");
                    return;
                }
                if (pBill.OnProcess == 1 || pBill.OnProcess == 2)
                {
                    MessageBox.Show("该订单已撤销或已完成，不能进行货品检验入库！");
                    return;
                }
                pBill.Custodian = userID;
                pBill.OnProcess = 2;
                pBill.StockDate = DateTime.Now;
                if (pBLL.Update(pBill))
                {
                    MessageBox.Show("货品检验入库成功！");
                    txtCustodianName.Text = eBLL.FindByID(pBill.Custodian).EmployeeName;
                    txtOnProcess.Text = "完成";
                    txtStockDate.Text = pBill.StockDate.ToShortDateString();
                    return;
                }
                else
                {
                    MessageBox.Show("货品检验入库失败！");
                    return;
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRepeal_Click(object sender, EventArgs e)
        {
            try
            {
                if (pBill == null)
                {
                    MessageBox.Show("请选择要撤销的一笔订单！");
                    return;
                }
                if (pBill.OnProcess == 2)
                {
                    MessageBox.Show("该订单已完成，不能进行撤销！");
                    return;
                }
                if (pBill.OnProcess == 1)
                {
                    MessageBox.Show("该订单已撤销，不能再次撤销！");
                    return;
                }
                pBill.OnProcess = 1;
                pBill.Memo = txtMemo.Text.Trim();
                if (pBLL.Update(pBill))
                {
                    MessageBox.Show("撤销成功！");
                    txtOnProcess.Text = "撤销";
                    return;
                }
                else
                {
                    MessageBox.Show("撤销失败！");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            try
            {
                if (pBill == null)
                {
                    MessageBox.Show("请选择要恢复的一笔订单！");
                    return;
                }
                if (pBill.OnProcess == 2)
                {
                    MessageBox.Show("该订单已完成，不能进行撤销！");
                    return;
                }
                if (pBill.OnProcess != 1)
                {
                    MessageBox.Show("该订单未撤销！");
                    return;
                }
                pBill.OnProcess = 0;
                pBill.Memo = txtMemo.Text.Trim();
                if (pBLL.Update(pBill))
                {
                    MessageBox.Show("恢复成功！");
                    txtOnProcess.Text = "执行(未审核)";
                    return;
                }
                else
                {
                    MessageBox.Show("恢复失败！");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
