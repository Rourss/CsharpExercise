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
    public partial class Frm_Product : BaseForm.Frm_BaseInfo
    {
        private ProductBLL pBLL;
        private List<Product> list;
        private Product p;

        private int currentIndex; //定义一个字段，用于存放该视图当前选中行的下标
        public Frm_Product()
        {
            InitializeComponent();
            pBLL = new ProductBLL();
            
        }

        private void Frm_Product_Load(object sender, EventArgs e)
        {
            try
            {
                //BindDate();

                cbQuery.SelectedIndex = 0;
                cbCategoryIDP.DataSource = new CategoryBLL().GetALL();
                cbCategoryIDP.DisplayMember = "CategoryName";
                cbCategoryIDP.ValueMember = "CategoryID";
                dgProductInfo.AutoGenerateColumns = false; //取消自动创建列
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindDate()
        {
            list = pBLL.GetALL();
            dgProductInfo.DataSource = list;
            if (list.Count > 0)
            {
                dgProductInfo.CurrentCell.Selected = false; //设置当前单元格不反蓝
            }
        }

        private void dgProductInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgProductInfo.CurrentRow.Selected = true;
                currentIndex = dgProductInfo.CurrentRow.Index;
                p = list[currentIndex]; //获取当前行的产品类别信息

                if (op == Operation.Update || op == Operation.Delete)
                {
                    ShowProduct();
                    dgProductInfo.AutoGenerateColumns = false; //取消自动创建列
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowProduct()
        {
            txtProductID.Text = p.ProductID;
            txtProductName.Text = p.ProductName;
            txtSpellingCode.Text = p.SpellingCode;
            txtBarCode.Text = p.BarCode;
            txtSpecial.Text = p.Special;
            txtUnit.Text = p.Unit;
            txtOrigin.Text = p.Origin;
            cbCategoryIDP.SelectedValue = p.CategoryID;
            txtPurchasePrice.Text = p.PurchasePrice.ToString();
            txtSalePrice.Text = p.SalePrice.ToString();
            txtQuantity.Text = (p.Quantity).ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtProductID.Enabled = true;
            txtPurchasePrice.Enabled = false;
            txtSalePrice.Enabled = false;
            txtQuantity.Enabled = false;
            txtSpellingCode.Enabled = false;
            txtPurchasePrice.Text = txtSalePrice.Text = txtQuantity.Text = Convert.ToString(0);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (p != null)
            {
                ShowProduct();
            }
            txtProductID.Enabled = false;
            txtPurchasePrice.Enabled = false;
            txtSalePrice.Enabled = false;
            txtQuantity.Enabled = false;
            txtSpellingCode.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (p != null)
            {
                ShowProduct();
                
            }
            foreach (Control c in gbInfo.Controls)
            {
                if(c is TextBox || c is ComboBox)
                {
                    c.Enabled = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (op == Operation.Insert)
                {
                    foreach (Control c in gbInfo.Controls)
                    {
                        if (c is TextBox && c.Text == "")
                        {
                            MessageBox.Show("请输入所有值！");
                            c.Focus();
                            return;
                        }
                    }
                    p=new Product();
                    p.ProductID = txtProductID.Text;
                    p.ProductName = txtProductName.Text;
                    p.SpellingCode = txtSpellingCode.Text;
                    p.BarCode = txtBarCode.Text;
                    p.Special = txtSpecial.Text;
                    p.Unit = txtUnit.Text;
                    p.Origin = txtOrigin.Text;
                    p.CategoryID = cbCategoryIDP.SelectedValue.ToString();
                    p.PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text);
                    p.SalePrice = Convert.ToDecimal(txtSalePrice.Text);
                    p.Quantity = Convert.ToInt32(txtQuantity.Text);
                    if (pBLL.Insert(p))
                    {
                        MessageBox.Show("新增成功！");
                        BindDate();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].ProductID == p.ProductID)
                            {
                                dgProductInfo.Rows[i].Selected = true;
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
                    if (p == null)
                    {
                        MessageBox.Show("请选择要修改的记录！");
                        return;
                    }
                    p.ProductName = txtProductName.Text.Trim();
                    p.BarCode = txtBarCode.Text.Trim();
                    p.Special = txtSpecial.Text.Trim();
                    p.Unit = txtUnit.Text.Trim();
                    p.Origin = txtOrigin.Text.Trim();
                    p.CategoryID = cbCategoryIDP.SelectedValue.ToString();

                    if (pBLL.Update(p))
                    {
                        MessageBox.Show("修改成功！");
                        BindDate();
                        dgProductInfo.Rows[currentIndex].Selected = true;
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
                else if (op == Operation.Delete)
                {
                    if (p == null)
                    {
                        MessageBox.Show("请选择要删除的记录！");
                        return;
                    }
                    if (pBLL.Delete(p))
                    {
                        MessageBox.Show("删除成功！");
                        BindDate();
                        p = null;
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

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            txtSpellingCode.Text = Common.HZToSpell(txtProductName.Text);
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
            cbCategoryIDP.Enabled = true;
            p = null;
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
                    list = pBLL.FindByName(txtQueryValue.Text.Trim());
                    if (list == null)
                    {
                        MessageBox.Show("没有查询到记录！");
                        txtQueryValue.Text = "";
                        txtQueryValue.Focus();
                        return;
                    }
                    if (list.Count > 0)
                    {
                        dgProductInfo.DataSource = null;
                        dgProductInfo.DataSource = list;
                        dgProductInfo.CurrentCell.Selected = false; //取消反蓝
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
            SetSelectdIndex(dgProductInfo);
            dgProductInfo.AutoGenerateColumns = false; //取消自动创建列
            list = null;
            txtQueryValue.Text = "";
            txtQueryValue.Focus();
        }
    }
}
