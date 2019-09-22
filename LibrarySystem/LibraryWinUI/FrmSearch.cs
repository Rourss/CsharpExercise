using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.LibraryBusiness;

namespace Library.LibraryWinUI
{
    public partial class FrmSearch : Form
    {
        private WinLogic logic; //字段
        public FrmSearch()
        {
            InitializeComponent();
            logic = new WinLogic(); //初始化字段
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string adminID = txtAdminID.Text.Trim(); //获取管理员ID
            string adminpass=txtAdminPass.Text.Trim(); //获取管理员密码

            if (adminID == "") //判断是否为空
            {
                MessageBox.Show("管理员ID和密码不能为空!");
                txtAdminID.Text = "";
                txtAdminID.Focus();
                return;
            }
            if (adminpass == "") //判断是否为空
            {
                MessageBox.Show("管理员ID和密码不能为空!");
                txtAdminPass.Text = "";
                txtAdminPass.Focus();
                return;
            }

            if (logic.Login(adminID, adminpass)) //调用登陆方法,ID和密码正确则返回真
            {
                MessageBox.Show("登陆成功!");
                FrmLibrarySystem frm = new FrmLibrarySystem(adminID); //显示业务窗体
                this.Hide(); //隐藏登陆窗体
                frm.ShowDialog(); //把业务窗体以对话框形式显示
                this.Show(); //显示登录窗体
                ClearContorls(); //调用方法清空文本框
            }
            else
            {
                MessageBox.Show("登陆失败!");
                ClearContorls();
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearContorls();
        }

        private void ClearContorls()
        {
            txtAdminID.Text = "";
            txtAdminPass.Text = "";
            txtAdminID.Focus();
        }
    }
}
