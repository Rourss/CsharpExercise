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
    public partial class Frm_Supplier : BaseForm.Frm_BaseInfo
    {
        private SupplierBLL sBLL;
        private List<Supplier> list;
        private Supplier s;
        private int currentIndex;
        public Frm_Supplier()
        {
            InitializeComponent();
            sBLL = new SupplierBLL();
        }

        private void Frm_Supplier_Load(object sender, EventArgs e)
        {
            try
            {
                //BindData();
                cbQuery.SelectedIndex = 0;
                dgSupplierInfo.AutoGenerateColumns = false; //取消自动创建列
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindData()
        {
            list = sBLL.GetALL();
            dgSupplierInfo.DataSource = list;
            if (list.Count > 0)
            {
                dgSupplierInfo.CurrentCell.Selected = false; //设置当前单元格不反蓝
            }
        }

        private void dgSupplierInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                 dgSupplierInfo.CurrentRow.Selected = true;
                 currentIndex = dgSupplierInfo.CurrentRow.Index;
                 s = list[currentIndex]; //获取当前行的产品类别信息

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
            txtSupplierID.Text = s.SupplierID;
            txtSupplierName.Text = s.SupplierName;
            txtSpellingCode.Text = s.SpellingCode;
            txtAddress.Text = s.Address;
            txtZipCode.Text = s.ZipCode;
            txtTel.Text = s.Tel;
            txtFax.Text = s.Fax;
            txtBankName.Text = s.BankName;
            txtBankAccount.Text = s.BankAccount;
            txtContacter.Text = s.Contacter;
            txtEmail.Text = s.Email;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtSpellingCode.Enabled = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (s != null)
            {
                ShowSupplier();
            }
            txtSupplierID.Enabled = false;
            txtSpellingCode.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (s != null)
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
                    foreach (Control c in gbInfo.Controls)
                    {
                        if (c is TextBox && c.Text == "")
                        {
                            MessageBox.Show("请输入所有值！");
                            c.Focus();
                            return;
                        }
                    }
                    s = new Supplier();
                    s.SupplierID = txtSupplierID.Text.Trim();
                    s.SupplierName = txtSupplierName.Text.Trim();
                    s.SpellingCode = txtSpellingCode.Text.Trim();
                    s.Address = txtAddress.Text.Trim();
                    s.ZipCode = txtZipCode.Text.Trim();
                    s.Tel = txtTel.Text.Trim();
                    s.Fax = txtFax.Text.Trim();
                    s.BankName = txtBankName.Text.Trim();
                    s.BankAccount = txtBankAccount.Text.Trim();
                    s.Contacter=txtContacter.Text.Trim();
                    s.Email = txtEmail.Text.Trim();

                    if (sBLL.Insert(s))
                    {
                        MessageBox.Show("新增成功！");
                        BindData();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].SupplierID == s.SupplierID)
                            {
                                dgSupplierInfo.Rows[i].Selected = true;
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
                    if (s == null)
                    {
                        MessageBox.Show("请选择要修改的记录！");
                        return;
                    }
                    s.SupplierName = txtSupplierName.Text.Trim();
                    s.SpellingCode = txtSpellingCode.Text.Trim();
                    s.Address = txtAddress.Text.Trim();
                    s.ZipCode = txtZipCode.Text.Trim();
                    s.Tel = txtTel.Text.Trim();
                    s.Fax = txtFax.Text.Trim();
                    s.BankName = txtBankName.Text.Trim();
                    s.BankAccount = txtBankAccount.Text.Trim();
                    s.Contacter = txtContacter.Text.Trim();
                    s.Email = txtEmail.Text.Trim();

                    if (sBLL.Update(s))
                    {
                        MessageBox.Show("修改成功！");
                        BindData();
                        dgSupplierInfo.Rows[currentIndex].Selected = true;
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
                else if (op == Operation.Delete)
                {
                    if (s == null)
                    {
                        MessageBox.Show("请选择要删除的记录！");
                        return;
                    }

                    if (sBLL.Delete(s))
                    {
                        MessageBox.Show("删除成功！");
                        BindData();
                        s = null;
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

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            txtSpellingCode.Text = Common.HZToSpell(txtSupplierName.Text);
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
            s = null;
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
                    s = sBLL.FindByID(seach);
                    if (s != null)
                    {
                        list = new List<Supplier>();
                        list.Add(s);
                        dgSupplierInfo.DataSource = null;
                        dgSupplierInfo.DataSource = list;
                        if (list.Count > 0)
                        {
                            dgSupplierInfo.CurrentCell.Selected = false; //取消反蓝
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
                    list = sBLL.FindByName(txtQueryValue.Text.Trim());
                    if (list == null)
                    {
                        MessageBox.Show("没有查询到记录！");
                        txtQueryValue.Text = "";
                        txtQueryValue.Focus();
                        return;
                    }
                    if (list.Count > 0)
                    {
                        dgSupplierInfo.DataSource = null;
                        dgSupplierInfo.DataSource = list;
                        dgSupplierInfo.CurrentCell.Selected = false; //取消反蓝
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
            SetSelectdIndex(dgSupplierInfo);
            dgSupplierInfo.AutoGenerateColumns = false; //取消自动创建列
            list = null;
            txtQueryValue.Text = "";
            txtQueryValue.Focus();
        }
    }
}
