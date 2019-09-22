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

namespace QiuXingMing.UI.InfoManage
{
    public partial class Frm_Category : BaseForm.Frm_BaseInfo
    {
        private CategoryBLL cBLL;
        private List<Category> list; //存储所有的产品类别
        private Category c; //存储一个产品类别

        private int currentIndex; //定义一个字段，用于存放该视图当前选中行的下标
        public Frm_Category()
        {
            InitializeComponent();
            cBLL = new CategoryBLL();
        }

        private void Frm_Category_Load(object sender, EventArgs e)
        {
            try
            {
                //BindDate();
                cbQuery.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindDate()
        {
            list = cBLL.GetALL(); //调用方法获取所有产品类别，放到产品类别列表里
            dgCategoryInfo.DataSource = list; //设置数据源为产品类别列表
            if (list.Count > 0)
            {
                dgCategoryInfo.CurrentCell.Selected = false; //设置当前单元格不反蓝
            }
           dgCategoryInfo.AutoGenerateColumns = false; //取消自动创建列
        }

        private void dgCategoryInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //1.将选中的行反蓝
                dgCategoryInfo.CurrentRow.Selected = true;
                //2.获取选中的内容，并显示
                currentIndex = dgCategoryInfo.CurrentRow.Index; //获取当前行的下标，存入变量中
                c = list[currentIndex]; //获取当前行的产品类别信息

                if (op == Operation.Update || op == Operation.Delete)
                {
                    ShowCategoryInfo();
                }
            }
            catch 
            {

            }
        }

        private void ShowCategoryInfo()
        {
            txtCategoryID.Text = c.CategoryID; //文本框显示产品类别编号
            txtCategoryName.Text = c.CategoryName; //文本框显示产品类别名称
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            txtCategoryID.Enabled = true;
            txtCategoryName.Enabled = true;
            txtCategoryID.Text = "";
            txtCategoryName.Text = "";
            txtCategoryID.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (c != null)
            {
                ShowCategoryInfo();
            }
            txtCategoryID.Enabled = false;
            txtCategoryName.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (c != null)
            {
                ShowCategoryInfo();
            }
            txtCategoryID.Enabled = false;
            txtCategoryName.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (op == Operation.Insert)
                {
                    foreach (Control con in gbInfo.Controls)
                    {
                        if (con is TextBox && con.Text == "")
                        {
                            MessageBox.Show("请输入所有值！");
                            con.Focus();
                            return;
                        }
                    }
                    c = new Category();
                    c.CategoryID = txtCategoryID.Text.Trim();
                    c.CategoryName = txtCategoryName.Text.Trim();

                    if (cBLL.Insert(c))
                    {
                        MessageBox.Show("新增成功！");
                        BindDate();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].CategoryID == c.CategoryID)
                            {
                                dgCategoryInfo.Rows[i].Selected = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("新增失败！");
                    }
                }
                else if (op == Operation.Update)
                {
                    if (c == null)
                    {
                        MessageBox.Show("请选择要修改的记录！");
                        return;
                    }
                    c.CategoryName = txtCategoryName.Text.Trim();

                    if (cBLL.Update(c))
                    {
                        MessageBox.Show("修改成功！");
                        BindDate();
                        dgCategoryInfo.Rows[currentIndex].Selected = true;
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
                else if (op == Operation.Delete)
                {
                    if (c == null)
                    {
                        MessageBox.Show("请选择要删除的记录！");
                        return;
                    }
                    if (cBLL.Delete(c))
                    {
                        MessageBox.Show("删除成功！");
                        BindDate();
                        c = null;
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Control cc in gbInfo.Controls)
            {
                if (cc is TextBox)
                {
                    cc.Text = "";
                    cc.Enabled = true;
                }
            }
            c = null;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string seach = ""; //存储查询条件
            try
            {
                if (cbQuery.SelectedIndex == 0)
                {
                    BindDate();
                    return;
                }
                else if (cbQuery.SelectedIndex == 1)
                {
                    seach = txtQueryValue.Text.Trim(); //从文本框取出查询值
                    if (seach == "") //判断是否为空
                    {
                        MessageBox.Show("请输入查询值！");
                        txtQueryValue.Focus();
                        return;
                    }
                    c = cBLL.FindByID(seach);
                    if (c != null)
                    {
                        list = new List<Category>();
                        list.Add(c);
                        dgCategoryInfo.DataSource = null;
                        dgCategoryInfo.DataSource = list;
                        if (list.Count > 0)
                        {
                            dgCategoryInfo.CurrentCell.Selected = false; //取消反蓝
                        }
                        return;
                    }
                    else
                    {
                        MessageBox.Show("没有查询到记录！");
                        txtQueryValue.Text = "";
                        txtQueryValue.Focus();
                        return;
                    }
                }
                else if (cbQuery.SelectedIndex == 2)
                {
                    seach = txtQueryValue.Text.Trim(); //从文本框取出查询值
                    if (seach == "") //判断是否为空
                    {
                        MessageBox.Show("请输入查询值！");
                        txtQueryValue.Focus();
                        return;
                    }
                    list = cBLL.FindByName(txtQueryValue.Text.Trim());
                    if (list == null)
                    {
                        MessageBox.Show("没有查询到记录！");
                        txtQueryValue.Text = "";
                        txtQueryValue.Focus();
                        return;
                    }
                    if (list.Count > 0)
                    {
                        dgCategoryInfo.DataSource = null;
                        dgCategoryInfo.DataSource = list;
                        dgCategoryInfo.CurrentCell.Selected = false; //取消反蓝
                        return;
                    }
                    else
                    {
                        MessageBox.Show("没有查询到记录！");
                        txtQueryValue.Text = "";
                        txtQueryValue.Focus();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectdIndex(dgCategoryInfo);
            dgCategoryInfo.AutoGenerateColumns = false; //取消自动创建列
            list = null;
            txtQueryValue.Text = "";
            txtQueryValue.Focus();
        }
    }
}
