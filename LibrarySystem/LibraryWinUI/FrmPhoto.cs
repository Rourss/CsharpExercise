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
using System.IO;

namespace Library.LibraryWinUI
{
    public partial class FrmPhoto : Form
    {
        private WinLogic logic; //字段
        private string fileName = ""; //字段，用于存放照片的文件名（含路径）
        public FrmPhoto()
        {
            InitializeComponent();
            logic = new WinLogic(); //实例化对象
        }
        private void pbPhoto_Click(object sender, EventArgs e)
        {
            //当单击图像控件时，打开资源管理器，找图片文件并显示到控件
            try
            {
                openFileDialog1.InitialDirectory = "C:\\Users\\Administrator\\Desktop\\照片"; //通过属性设置默认路径
                openFileDialog1.FileName = ""; //清空文件名
                openFileDialog1.Filter = "JPG文件|*.jpg|PNG文件|*.png|GIF文件|*.gif|所有文件|*.*"; //设置筛选器,成对出现

                if (openFileDialog1.ShowDialog() == DialogResult.OK) //如果选择打开按钮,就进入分支
                {
                    fileName = openFileDialog1.FileName;

                    if (fileName == "") //判断有没有选文件
                    {
                        MessageBox.Show("请选择图片文件!");
                        return;
                        
                    }
                    else
                    {
                        pbPhoto.Image = Image.FromFile(fileName); //把指定的文件创建成图片,然后放到图片框中显示出来
                    }
                }
            }
            catch
            {
                MessageBox.Show("请选择图片文件!");
            }
        }

        private void btnSavePhoto_Click(object sender, EventArgs e)
        {
            string userID = txtUserID.Text.Trim(); //获取ID
            
            if (userID == "") //判断是否为空！
            {
                MessageBox.Show("读者ID不能为空!");
                txtUserID.Text = "";
                txtUserID.Focus();
                return;
            }
            if (fileName == "")  //判断是否为空！
            {
                MessageBox.Show("请选择图片！");
                return;
            }
            else
            {
                if (logic.UpdateUserInfoByUserID(userID, fileName)) //调用插入新读者的方法
                {
                    MessageBox.Show("读者信息更新成功!");
                }
                else
                {
                    MessageBox.Show("读者信息更新失败!");
                }
            }
        }

        private void btnReadPhoto_Click(object sender, EventArgs e)
        {
            string userID = txtUserID.Text.Trim(); //获取ID
            DataSet ds = logic.LxGetUserInfoByUserID(userID); //调用通过ID查读者信息的方法
            DataTable dt = ds.Tables[0]; 
            DataRow dr = dt.Rows[0];
            if (dr["photo"] == Convert.DBNull) //如果这个字段的值为数据库的：NULL 则显示”暂无“
            {
                pbPhoto.Image = Image.FromFile("F:\\图书管理系统\\照片\\no.gif"); //通过读取文件显示图片
            }
            else
            {
                byte[] photo = dr["photo"] as byte[]; //把字段的值放入二进制数组中
                MemoryStream ms = new MemoryStream(photo); //创建一个内存流的对象，把二进制数组传入
                pbPhoto.Image = Image.FromStream(ms); //读取流的数据并转成图片显示出来
            }
        }
    }
}
