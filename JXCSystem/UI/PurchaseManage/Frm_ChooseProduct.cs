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
    public partial class Frm_ChooseProduct : Form
    {
        private ProductBLL pBLL;
        private List<Product> list;
        private Product p;
        public Frm_ChooseProduct()
        {
            InitializeComponent();
            pBLL = new ProductBLL();
        }

        private void Frm_ChooseProduct_Load(object sender, EventArgs e)
        {
            try
            {
                lblValue.Visible = false;
                txtQueryValue.Visible = false;
                cbQuery.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindData()
        {
            list = pBLL.GetALL();
            dgProductInfo.DataSource = list;
            if (dgProductInfo.CurrentCell != null)
            {
                dgProductInfo.CurrentCell.Selected = false;
            }
        }

        private void dgProductInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgProductInfo.Columns[e.ColumnIndex].Name == "阿西吧")
                {
                    e.Value = new CategoryBLL().FindByID(e.Value.ToString()).CategoryName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgProductInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgProductInfo.CurrentRow.Selected = true;
                p = list[e.RowIndex]; //将选择的产品取出来
                dgProductInfo.AutoGenerateColumns = false; //取消自动创建列
            }
            catch
            {
                
            }
        }

        private void dgProductInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PurchaseDetail detail_Add = new PurchaseDetail(); //要增加的明细，传递到填写进货单窗体
                detail_Add.ProductID = p.ProductID; //设置产品编号
                detail_Add.PurchasePrice = 0;
                detail_Add.Quantity = Convert.ToString(0);

                Frm_FillPurchaseBill.Detail_Add = detail_Add; //把增加的明细传到进货单窗体
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string seach = ""; //存储查询条件
            try
            {
                if (cbQuery.SelectedIndex == 0)
                {
                    BindData();
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
                    p = pBLL.FindByID(seach);
                    if (p != null)
                    {
                        list = new List<Product>();
                        list.Add(p);
                        dgProductInfo.DataSource = null;
                        dgProductInfo.DataSource = list;
                        if (list.Count > 0)
                        {
                            dgProductInfo.CurrentCell.Selected = false; //取消反蓝
                        }
                        return;
                    }
                    else
                    {
                        MessageBox.Show("没有查询到记录！");
                        txtQueryValue.Text = "";
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
                    list = pBLL.FindByName(txtQueryValue.Text.Trim());
                    if (list != null)
                    {
                        dgProductInfo.DataSource = null;
                        dgProductInfo.DataSource = list;
                        if (list.Count > 0)
                        {
                            dgProductInfo.CurrentCell.Selected = false; //取消反蓝
                        }
                        return;
                    }
                    else
                    {
                        MessageBox.Show("没有查询到记录！");
                        txtQueryValue.Text = "";
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
            if (cbQuery.SelectedIndex == 0)
            {
                lblValue.Visible = false;
                txtQueryValue.Visible = false;
            }
            else if (cbQuery.SelectedIndex == 1 || cbQuery.SelectedIndex == 2)
            {
                lblValue.Visible = true;
                txtQueryValue.Visible = true;
            }
            txtQueryValue.Text = "";
            dgProductInfo.DataSource = null;
            list = null;
        }

    }
}
