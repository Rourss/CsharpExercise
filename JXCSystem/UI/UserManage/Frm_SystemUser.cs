using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QiuXingMing.Model;
using QiuXingMing.BLL;

namespace QiuXingMing.UI.UserManage
{
    public partial class Frm_SystemUser : Form
    {
        private SystemUserBLL sBLL;
        private List<string> sulist; //存放用户编号
        private SystemUser su; //存放一个用户

        CheckBox[] c1 = new CheckBox[5];
        CheckBox[] c2 = new CheckBox[3];
        CheckBox[] c3 = new CheckBox[2];
        CheckBox[] c4 = new CheckBox[2];

        public Frm_SystemUser()
        {
            InitializeComponent();
            sBLL = new SystemUserBLL();

            c1[0] = cbProduct;
            c1[1] = cbProductInfo;
            c1[2] = cbSupplier;
            c1[3] = cbCustomer;
            c1[4] = cbEmployee;

            c2[0] = cbFillPurchaseBill;
            c2[1] = cbExamPurchaseBill;
            c2[2] = cbInStockCheck;

            c3[0] = cbSaleInfo;
            c3[1] = cbSaleReturn;

            c4[0] = cbChangPWD;
            c4[1] = cbSystemUser;
        }

        private void Frm_SystemUser_Load(object sender, EventArgs e)
        {
            try
            {
                sulist = sBLL.GetAllSystemUserID();
                lbUser.DataSource = sulist;
                if (sulist.Count > 0)
                {
                    lbUser.SelectedIndex = -1; //取消反蓝
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 通过传入权限值和复选框数组，对页面的权限进行控制
        /// </summary>
        /// <param name="c">复选框数组</param>
        /// <param name="authtity">权限值</param>
        public void SetFunctionByAuthtity(CheckBox[] c, int authtity)
        {
            int function = authtity;
            for (int i = 0; i < c.Length; i++)
            {
                if (function % 2 == 1)
                {
                    c[i].Checked = true;
                }
                else
                {
                    c[i].Checked = false;
                }
                function /= 2;
            }
        }
        private void lbUser_Click(object sender, EventArgs e)
        {
            try
            {
                //1.取出用户编号
                if (lbUser.SelectedItem == null)
                {
                    return;
                }
                string userid=lbUser.SelectedItem.ToString();
                //2.通过用户编号查找用户信息，并显示
                su = sBLL.FindByID(userid);
                txtUserID.Text = su.UserID.ToString();
                txtPWD.Text = su.Password.ToString();
                txtName.Text = new EmployeeBLL().FindByID(su.UserID).EmployeeName;

                SetFunctionByAuthtity(c1, su.BaseFunction);
                SetFunctionByAuthtity(c2, su.PurchaseFunction);
                SetFunctionByAuthtity(c3, su.SaleFunction);
                SetFunctionByAuthtity(c4, su.UserFunction);

                btnRecovery.Enabled = btnRecovery1.Enabled = btnRecovery2.Enabled = btnRecovery3.Enabled = btnRecovery4.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPermission1_Click(object sender, EventArgs e)
        {
            SelectAll(c1);
        }
        /// <summary>
        /// 把全部复选框选中
        /// </summary>
        /// <param name="c"></param>
        private void SelectAll(CheckBox[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                c[i].Checked = true;
            }
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            NoSelectAll(c1);
        }

        /// <summary>
        /// 根据传入的值选择或清除权限
        /// </summary>
        /// <param name="value">布尔值</param>
        /// <param name="c">复选框数组</param>
        private void SelectOrClear(bool value, CheckBox[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                c[i].Checked = value;
            }
        }
       /// <summary>
       /// 把全部复选框去除选中
       /// </summary>
       /// <param name="c"></param>
        private void NoSelectAll(CheckBox[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                c[i].Checked = false;
            }
        }

        private void btnPermission2_Click(object sender, EventArgs e)
        {
            SelectAll(c2);
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            NoSelectAll(c2);
        }

        private void btnPermission3_Click(object sender, EventArgs e)
        {
            SelectAll(c3);
        }

        private void btnClear3_Click(object sender, EventArgs e)
        {
            NoSelectAll(c3);
        }

        private void btnPermission4_Click(object sender, EventArgs e)
        {
            SelectAll(c4);
        }

        private void btnClear4_Click(object sender, EventArgs e)
        {
            NoSelectAll(c4);
        }

        private void btnRecovery1_Click(object sender, EventArgs e)
        {
            SetFunctionByAuthtity(c1, su.BaseFunction);
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            SelectAll(c1);
            SelectAll(c2);
            SelectAll(c3);
            SelectAll(c4);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            NoSelectAll(c1);
            NoSelectAll(c2);
            NoSelectAll(c3);
            NoSelectAll(c4);
        }

        private void btnRecovery2_Click(object sender, EventArgs e)
        {
            SetFunctionByAuthtity(c2, su.PurchaseFunction);
        }

        private void btnRecovery3_Click(object sender, EventArgs e)
        {
            SetFunctionByAuthtity(c3, su.SaleFunction);
        }

        private void btnRecovery4_Click(object sender, EventArgs e)
        {
            SetFunctionByAuthtity(c4, su.UserFunction);
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            SetFunctionByAuthtity(c1, su.BaseFunction);
            SetFunctionByAuthtity(c2, su.PurchaseFunction);
            SetFunctionByAuthtity(c3, su.SaleFunction);
            SetFunctionByAuthtity(c4, su.UserFunction);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (su == null)
            {
                MessageBox.Show("请选择一个要修改的用户！");
                return;
            }
            su.Password = txtPWD.Text.Trim();
            su.BaseFunction = ComputeAuthtity(c1);
            su.PurchaseFunction = ComputeAuthtity(c2);
            su.SaleFunction = ComputeAuthtity(c3);
            su.UserFunction = ComputeAuthtity(c4);
            if (sBLL.Update(su))
            {
                MessageBox.Show("修改成功！");
                return;
            }
            else
            {
                MessageBox.Show("修改失败！");
                return;
            }
        }
        /// <summary>
        /// 二进制转换成十进制
        /// </summary>
        /// <param name="c">复选框数组</param>
        /// <returns>返回十进制</returns>
        private int ComputeAuthtity(CheckBox[] c)
        {
            int authtity = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i].Checked)
                {
                    authtity += Convert.ToInt32(Math.Pow(2, i)); //调用math类的幂方法计算
                }
            }
            return authtity;
        }

        private void btnConcel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtUserID.Text = "";
            txtPWD.Text = "";
            NoSelectAll(c1);
            NoSelectAll(c2);
            NoSelectAll(c3);
            NoSelectAll(c4);
            btnRecovery.Enabled = btnRecovery1.Enabled = btnRecovery2.Enabled = btnRecovery3.Enabled = btnRecovery4.Enabled = false;
            if (sulist.Count > 0)
            {
                lbUser.SelectedIndex = -1; //取消反蓝
            }
            su = null;
        }
    }
}
