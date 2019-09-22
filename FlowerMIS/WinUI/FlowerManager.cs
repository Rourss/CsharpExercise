using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlowerMIS.DataAccess;
using FlowerMIS.Logic;
using System.IO;

namespace FlowerMIS.WinUI
{
    public partial class FlowerManager : Form
    {
        private FlowerLogic logic;

        private string fileName = "";
        private string flowerID = "";
        private byte[] readPhoto;
        private int currentIndex; //字段,用于存放当前行的下标

        public FlowerManager()
        {
            InitializeComponent();
            logic = new FlowerLogic();
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                string flowerName = txtFlowerName1.Text.Trim();
                string flowerType = cbFlowerType1.Text.Trim();

                //2.进行检索操作并显示
                DataSet ds = logic.GetFlowerByFlowerNameAndFlowerType(flowerName,flowerType); //调用查找方法
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count == 0) //如果没有记录则显示
                {
                    dgFlower.DataSource = false; //刷新
                    MessageBox.Show("没有您查找的数据!");
                    txtFlowerName1.Text = "";
                    txtFlowerName1.Focus();
                    return;
                }
                dgFlower.DataSource = dt; //填充
                dgFlower.Columns["FlowerPhoto"].Visible = false; //把照片的列隐藏
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FlowerManager_Load(object sender, EventArgs e)
        {
            try
            {
                cbFlowerType1.SelectedIndex = 0;
                cbFlowerType2.SelectedIndex = 0;
                rbUpdateFlower.Enabled = false;
                rbDeleteFlower.Enabled = false;
                if (cbStock.Checked)
                {
                    cbNotStock.Checked = false;
                }
                else
                {
                    cbStock.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //使用foreach循环该分组框的全部控件
            foreach (Control c in gbFlower2.Controls)
            {
                if (c is TextBox && c.Text.Trim() == "") //当它是文本框并为空值时
                {
                    MessageBox.Show("请输入花卉信息!");
                    c.Focus();
                    return;
                }
            }
            flowerID = txtFlowerID.Text.Trim();
            string flowerName = txtFlowerName2.Text.Trim();
            //转换不成功会抛出异常
            double price=0;
            try
            {
                price = Convert.ToDouble(txtPrice.Text.Trim());
            }
            catch 
            {

                MessageBox.Show("单价格式不正确！");
                txtPrice.Text = "";
                txtPrice.Focus();
                return;
            }
            string flowerType = cbFlowerType2.Text;
            int flowerStatus=0;
            if (cbStock.Checked)
            {
                flowerStatus = Convert.ToInt32(cbStock.Checked);
            }
            else
            {
                flowerStatus = 0;
            }

            try
            {
                
                if (rbInsertFlower.Checked)
                {
                    if (fileName == "" || Path.GetFileName(fileName)=="no.gif")
                    {
                        //调用方法插入新的花卉（没照片）
                        if (logic.InsertFlowerNotPhoto(flowerID, flowerName, flowerType, price, flowerStatus))
                        {
                            MessageBox.Show("新增成功!");
                            rbUpdateFlower.Enabled = true;
                            //刷新
                            dgFlower.DataSource = logic.GetFlowerByFlowerNameAndFlowerType(flowerName, flowerType).Tables[0];
                            dgFlower.Columns["FlowerPhoto"].Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("新增失败!");
                        }
                    }
                    else
                    {
                        //调用方法插入新的花卉（有照片）
                        if (logic.InsertFlower(flowerID, flowerName, flowerType, price, flowerStatus,fileName))
                        {
                            MessageBox.Show("新增成功!");
                            rbUpdateFlower.Enabled = true;
                            rbDeleteFlower.Enabled = true;
                            //刷新
                            dgFlower.DataSource = logic.GetFlowerByFlowerNameAndFlowerType(flowerName, flowerType).Tables[0];
                            dgFlower.Columns["FlowerPhoto"].Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("新增失败!");
                        }
                    }
                }
                else if (rbUpdateFlower.Checked)
                {
                    if (fileName == "")
                    {
                        //更新花卉信息（维持原样）
                        if (logic.UpdateFlowerAndPhoto(flowerID,flowerName,flowerType,price,flowerStatus,readPhoto))
                        {
                            MessageBox.Show("修改成功!");
                            rbUpdateFlower.Enabled = true;
                            //刷新
                            dgFlower.DataSource = logic.GetFlowerByFlowerNameAndFlowerType(flowerName, flowerType).Tables[0];
                            dgFlower.Columns["FlowerPhoto"].Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("修改失败!");
                        }
                    }
                    else if (Path.GetFileName(fileName) == "no.gif")
                    {
                        //更新花卉信息（清空照片）
                        if (logic.UpdateFlowerDelPhoto(flowerID,flowerName,flowerType,price,flowerStatus))
                        {
                            MessageBox.Show("修改成功!");
                            rbUpdateFlower.Enabled = true;
                            //刷新
                            dgFlower.DataSource = logic.GetFlowerByFlowerNameAndFlowerType(flowerName, flowerType).Tables[0];
                            dgFlower.Columns["FlowerPhoto"].Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("修改失败!");
                        }
                    }
                    else
                    {
                        //更新花卉信息（有照片）
                        if (logic.UpdateFlower(flowerID, flowerName, flowerType, price, flowerStatus,fileName))
                        {
                            MessageBox.Show("修改成功!");
                            rbUpdateFlower.Enabled = true;
                            //刷新
                            dgFlower.DataSource = logic.GetFlowerByFlowerNameAndFlowerType(flowerName, flowerType).Tables[0];
                            dgFlower.Columns["FlowerPhoto"].Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("修改失败!");
                        }
                    }

                }
                else
                {
                    if (rbDeleteFlower.Checked)
                    {
                        DialogResult result = MessageBox.Show("是否要删除?", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);  //显示一个选项框
                        if (result == DialogResult.Yes) //如果选择是
                        {
                            if (logic.DelFlower(flowerID))
                            {
                                MessageBox.Show("删除成功！");
                                dgFlower.DataSource = logic.GetFlowerByFlowerNameAndFlowerType(flowerName, flowerType).Tables[0];
                                dgFlower.Columns["FlowerPhoto"].Visible = false;
                                ClearContorls();
                            }
                            else
                            {
                                MessageBox.Show("删除失败！");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgFlower_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //1.将当前行反蓝
                dgFlower.CurrentRow.Selected = true;//用属性获取当前行是否被选中，如果选中则获取该值
                rbUpdateFlower.Enabled = true;
                DataTable dt = dgFlower.DataSource as DataTable; // as 用于引用类型转换
                currentIndex = dgFlower.CurrentRow.Index; //定义一个字段，用于存放该视图当前选中行的下标
                DataRow dr = dt.Rows[currentIndex]; //设置一个行变量用来存放数据表的行的内容（行的内容用CurrentRow属性的下标获得）
                flowerID = dr["FlowerID"].ToString();
                txtFlowerID.Text = flowerID;
                txtFlowerName2.Text = dr["FlowerName"].ToString();
                txtPrice.Text = dr["Price"].ToString();
                cbFlowerType2.Text = dr["FlowerType"].ToString();

                if (Convert.ToInt32(dr["FlowerStatus"]) == 1) //判断字段(转换成int),如果是1就激活单选按钮
                {
                    cbNotStock.Checked = false;
                    cbStock.Checked = true;//设置单选按钮的Checked属性为真,即可激活
                }
                else
                {
                    cbStock.Checked = false;
                    cbNotStock.Checked = true; //调用单选按钮的Select方法来激活按钮
                }
                
                if (dr["FlowerPhoto"] == Convert.DBNull) //如果这个字段的值为数据库的：NULL 则显示”暂无“
                {
                    pbFlowerPhoto.Image = Image.FromFile("no.gif"); //通过读取文件显示图片
                }
                else
                {
                    byte[] photo = dr["FlowerPhoto"] as byte[]; //把字段的值放入二进制数组中
                    readPhoto = photo;
                    MemoryStream ms = new MemoryStream(photo); //创建一个内存流的对象，把二进制数组传入
                    pbFlowerPhoto.Image = Image.FromStream(ms); //读取流的数据并转成图片显示出来
                }
                
                rbUpdateFlower.Select();
                rbDeleteFlower.Enabled = true;
                rbInsertFlower.Enabled = false;
                txtFlowerID.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbFlowerPhoto_Click(object sender, EventArgs e)
        {
            //当单击图像控件时，打开资源管理器，找图片文件并显示到控件
            try
            {
                openFileDialog1.InitialDirectory = "F:\\期中测试(2018级)\\picture"; //通过属性设置默认路径
                openFileDialog1.FileName = ""; //清空文件名
                openFileDialog1.Filter = "JPG文件(*.jpg)|*.jpg|位图文件(*.bmp)|*.bmp|GIF文件(*.gif)|*.gif"; //设置筛选器,成对出现

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
                        pbFlowerPhoto.Image = Image.FromFile(fileName); //把指定的文件创建成图片,然后放到图片框中显示出来
                    }
                }
            }
            catch
            {
                MessageBox.Show("请选择图片文件!");
            }
        }

        private void rbInsertFlower_Click(object sender, EventArgs e)
        {
            txtFlowerID.Enabled = true;
        }

        private void cbFlowerType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFlowerType2.SelectedIndex = cbFlowerType1.SelectedIndex;
        }

        private void rbUpdateFlower_Click(object sender, EventArgs e)
        {
            txtFlowerID.Enabled = false;
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            ClearContorls();
        }

        private void ClearContorls()
        {
            fileName = "";
            pbFlowerPhoto.Image = null;
            foreach (Control c in gbFlower2.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                cbFlowerType1.SelectedIndex = 0;
                cbFlowerType2.SelectedIndex = 0;
                cbStock.Checked = false;
                cbNotStock.Checked = false;
                rbInsertFlower.Enabled = true;
                rbInsertFlower.Checked = true;
                dgFlower.DataSource = false;
                txtFlowerName1.Text = "";
                txtFlowerID.Enabled = true;
                rbUpdateFlower.Enabled = false;
                rbDeleteFlower.Enabled = false;
            }
        }

        private void cbStock_Click(object sender, EventArgs e)
        {
            cbNotStock.Checked = false;
        }

        private void cbNotStock_Click(object sender, EventArgs e)
        {
            cbStock.Checked = false;
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            ClearContorls();
        }

    }
}
