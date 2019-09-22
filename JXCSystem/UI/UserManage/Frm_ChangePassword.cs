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

namespace QiuXingMing.UI.UserManage
{
    public partial class Frm_ChangePassword : Form
    {
        private SystemUserBLL sBLL;
        private string userID = "5";

        public string UserID
        {
            set { userID = value; }
        }
        public Frm_ChangePassword()
        {
            InitializeComponent();
            sBLL = new SystemUserBLL();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string oglPWD = txtOriginalPWD.Text.Trim(); //定义一个变量用来存放输入的原始密码
                string newPWD = txtNewPWD.Text.Trim(); //定义一个变量用来存放输入的新密码
                string cfmPWD = txtConfirmPWD.Text.Trim(); //定义一个变量用来存放输入的确认密码
                //下边的三个if都是用来判断变量是否为空
                if (oglPWD == "")
                {
                    MessageBox.Show("密码不能为空!");
                    txtOriginalPWD.Focus();
                    return;
                }
                if (newPWD == "")
                {
                    MessageBox.Show("密码不能为空!");
                    txtNewPWD.Focus();
                    return;
                }
                if (cfmPWD == "")
                {
                    MessageBox.Show("密码不能为空!");
                    txtConfirmPWD.Focus();
                    return;
                }

                //当新密码和确认密码一致时,才进入分支
                if (newPWD == cfmPWD)
                {
                    //验证原始密码是否正确
                    if (sBLL.SelectSystemUser(userID,oglPWD))
                    {
                        //执行修改密码的方法
                        if (sBLL.ChangPWD(userID,newPWD))
                        {
                            MessageBox.Show("密码修改成功!"); //弹出消息框
                            ClearContorls(); //清除控件
                        }
                        else
                        {
                            MessageBox.Show("密码修改失败!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("原始密码不正确!");
                        txtOriginalPWD.Text = "";
                        txtOriginalPWD.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("新密码和确认密码不一致");
                    txtNewPWD.Text = "";
                    txtConfirmPWD.Text = "";
                    txtNewPWD.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearContorls()
        {
            txtOriginalPWD.Text = "";
            txtNewPWD.Text = "";
            txtConfirmPWD.Text = "";
            txtOriginalPWD.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearContorls();
        }
    }
}
