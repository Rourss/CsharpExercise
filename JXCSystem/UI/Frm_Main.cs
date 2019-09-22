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

namespace QiuXingMing.UI
{
    public partial class Frm_Main : Form
    {
        private SystemUserBLL sBLL;
        private SystemUser su;
        public Frm_Main()
        {
            InitializeComponent();
            sBLL = new SystemUserBLL();
        }

        private void 产品分类管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<InfoManage.Frm_Category>();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userid = txtUserID.Text.Trim();
                string pwd = txtPWD.Text.Trim();
                if (userid == "")
                {
                    MessageBox.Show("请输入用户名！");
                    txtUserID.Focus();
                    return;
                }
                if (pwd == "")
                {
                    MessageBox.Show("请输入密码！");
                    txtPWD.Focus();
                    return;
                }
                if (sBLL.SelectSystemUser(userid, pwd))
                {
                    gbLogin.Visible = false;
                    gbExit.Visible = true;
                    lblUserID.Text = userid;

                    su = sBLL.FindByID(userid);
                    InitMenu(su.BaseFunction, 0);
                    InitMenu(su.PurchaseFunction, 1);
                    InitMenu(su.SaleFunction, 2);
                    InitMenu(su.UserFunction, 3);
                }
                else
                {
                    MessageBox.Show("用户名或密码不正确，请重新输入！");
                    txtUserID.Text = "";
                    txtPWD.Text = "";
                    txtUserID.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbExit.Visible = false;
            gbLogin.Visible = true;
            txtUserID.Text = "";
            txtPWD.Text = "";
            
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            DisableMenu();
        }
        private void InitMenu(int authtity, int menuIndex)
        {
            if (authtity == 0)
            {
                //menuIndex对应的主菜单项不可用
                ((ToolStripMenuItem)menuStrip1.Items[menuIndex]).Enabled = false;
            }
            else
            {
                //menuIndex对应的主菜单项可用
                ((ToolStripMenuItem)menuStrip1.Items[menuIndex]).Enabled = true;
                
                //2.控制对应下拉菜单
                //2.1 控制对应下拉菜单的长度
                int length = ((ToolStripMenuItem)menuStrip1.Items[menuIndex]).DropDownItems.Count;
                //2.2 按照长度构造数组
                ToolStripMenuItem[] t = new ToolStripMenuItem[length];
                //2.3 初始化数组
                ((ToolStripMenuItem)menuStrip1.Items[menuIndex]).DropDownItems.CopyTo(t, 0);
                //2.4 控制菜单的可用性
                for (int i = 0; i < t.Length; i++)
                {
                    if (authtity % 2 == 1)
                    {
                        t[i].Enabled= true;
                    }
                    else
                    {
                        t[i].Enabled = false;
                    }
                    authtity /= 2;
                }
            }
        }
        private void DisableMenu()
        {
            for (int i = 0; i < 4; i++)
            {
                InitMenu(0, i);
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            DisableMenu();
            txtUserID.Focus();
        }

        private void 产品信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (Form f in this.MdiChildren)
            //{
            //    if (f is InfoManage.Frm_Product)
            //    {
            //        f.Activate();
            //        f.WindowState = FormWindowState.Maximized;
            //        return;
            //    }
            //}
            //InfoManage.Frm_Product frm = new InfoManage.Frm_Product();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();

            ShowForm<InfoManage.Frm_Product>();
        }
        private T ShowForm<T>() where T:Form,new()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is T)
                {
                    f.Activate();
                    f.WindowState = FormWindowState.Maximized;
                    return f as T;
                }
            }
            T frm = new T();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            return frm;
        }

        private void 供应商信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<InfoManage.Frm_Supplier>();
        }

        private void 客户信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<InfoManage.Frm_Customer>();
        }

        private void 员工信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<InfoManage.Frm_Employee>();
        }

        private void 填写进货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseManage.Frm_FillPurchaseBill frm = ShowForm<PurchaseManage.Frm_FillPurchaseBill>();
            frm.UserID = su.UserID;
        }

        private void 审核进货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseManage.Frm_ExamPurchaseBill frm = ShowForm<PurchaseManage.Frm_ExamPurchaseBill>();
            frm.UserID = su.UserID;
        }

        private void 检查货物ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseManage.Frm_InStockCheck frm = ShowForm<PurchaseManage.Frm_InStockCheck>();
            frm.UserID = su.UserID;
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManage.Frm_ChangePassword frm = ShowForm<UserManage.Frm_ChangePassword>();
            frm.UserID = su.UserID;
        }

        private void 用户管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowForm<UserManage.Frm_SystemUser>();
        }
    }
}
