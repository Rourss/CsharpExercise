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
    public partial class Frm_Customer : BaseForm.Frm_BaseInfo
    {
        private CustomerBLL cBLL;
        private Customer c;
        private List<Customer> list;
        private int currentIndex;

        
        public Frm_Customer()
        {
            InitializeComponent();
            cBLL = new CustomerBLL();
        }

        private void Frm_Customer_Load(object sender, EventArgs e)
        {
            try
            {
                //BindData();
                cbQuery.SelectedIndex = 0;
                dgCustomerInfo.AutoGenerateColumns = false; //取消自动创建列
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindData()
        {
            list = cBLL.GetALL();
            dgCustomerInfo.DataSource = list;
            if (list.Count > 0)
            {
                dgCustomerInfo.CurrentCell.Selected = false; //设置当前单元格不反蓝
            }
            dgCustomerInfo.AutoGenerateColumns = false; //取消自动创建列
        }

        private void dgCustomerInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgCustomerInfo.CurrentRow.Selected = true;
                currentIndex =dgCustomerInfo.CurrentRow.Index;
                c = list[currentIndex]; //获取当前行的产品类别信息

                if (op == Operation.Update || op == Operation.Delete)
                {
                    ShowSupplier();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowSupplier()
        {
            txtCustomerID.Text = c.CustomerID;
            txtCustomerName.Text = c.CustomerName;
            txtSpellingCode.Text = c.SpellingCode;
            txtAddress.Text = c.Address;
            txtZipCode.Text = c.ZipCode;
            txtTel.Text = c.Tel;
            txtFax.Text = c.Fax;
            txtBankName.Text = c.BankName;
            txtBankAccount.Text = c.BankAccount;
            txtContacter.Text = c.Contacter;
            txtEmail.Text = c.Email;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtSpellingCode.Enabled = false;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (c != null)
            {
                ShowSupplier();
            }
            txtCustomerID.Enabled = false;
            txtSpellingCode.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (c != null)
            {
                ShowSupplier();
            }
            foreach (Control cc in gbInfo.Controls)
            {
                if (cc is TextBox)
                {
                    cc.Enabled = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (op == Operation.Insert)
                {
                    foreach (Control cc in gbInfo.Controls)
                    {
                        if (cc is TextBox && cc.Text == "")
                        {
                            MessageBox.Show("请输入所有值！");
                            cc.Focus();
                            return;
                        }
                    }
                    c = new Customer();
                    c.CustomerID = txtCustomerID.Text.Trim();
                    c.CustomerName = txtCustomerName.Text.Trim();
                    c.SpellingCode = txtSpellingCode.Text.Trim();
                    c.Address = txtAddress.Text.Trim();
                    c.ZipCode = txtZipCode.Text.Trim();
                    c.Tel = txtTel.Text.Trim();
                    c.Fax = txtFax.Text.Trim();
                    c.BankName = txtBankName.Text.Trim();
                    c.BankAccount = txtBankAccount.Text.Trim();
                    c.Contacter = txtContacter.Text.Trim();
                    c.Email = txtEmail.Text.Trim();

                    if (cBLL.Insert(c))
                    {
                        MessageBox.Show("新增成功！");
                        BindData();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].CustomerID == c.CustomerID)
                            {
                                dgCustomerInfo.Rows[i].Selected = true;
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
                    c.CustomerName = txtCustomerName.Text.Trim();
                    c.SpellingCode = txtSpellingCode.Text.Trim();
                    c.Address = txtAddress.Text.Trim();
                    c.ZipCode = txtZipCode.Text.Trim();
                    c.Tel = txtTel.Text.Trim();
                    c.Fax = txtFax.Text.Trim();
                    c.BankName = txtBankName.Text.Trim();
                    c.BankAccount = txtBankAccount.Text.Trim();
                    c.Contacter = txtContacter.Text.Trim();
                    c.Email = txtEmail.Text.Trim();

                    if (cBLL.Update(c))
                    {
                        MessageBox.Show("修改成功！");
                        BindData();
                        dgCustomerInfo.Rows[currentIndex].Selected = true;
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
                        BindData();
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

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            txtSpellingCode.Text = Common.HZToSpell(txtCustomerName.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Control cc in gbInfo.Controls)
            {
                if(cc is TextBox)
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
                    c = cBLL.FindByID(seach);
                    if (c != null)
                    {
                        list = new List<Customer>();
                        list.Add(c);
                        dgCustomerInfo.DataSource = null;
                        dgCustomerInfo.DataSource = list;
                        if (list.Count > 0)
                        {
                            dgCustomerInfo.CurrentCell.Selected = false; //取消反蓝
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
                        dgCustomerInfo.DataSource = null;
                        dgCustomerInfo.DataSource = list;
                        dgCustomerInfo.CurrentCell.Selected = false; //取消反蓝
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
            SetSelectdIndex(dgCustomerInfo);
            dgCustomerInfo.AutoGenerateColumns = false; //取消自动创建列
            list = null;
            txtQueryValue.Text = "";
            txtQueryValue.Focus();
        }
    }
}
