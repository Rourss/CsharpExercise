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
    public partial class Frm_Employee : BaseForm.Frm_BaseInfo
    {
        private EmployeeBLL eBLL;
        private List<Employee> list;
        private Employee em;

        private int currentIndex; //定义一个字段，用于存放该视图当前选中行的下标
        public Frm_Employee()
        {
            InitializeComponent();
            eBLL = new EmployeeBLL();
        }

        private void Frm_Employee_Load(object sender, EventArgs e)
        {
            try
            {
                //BindData();
                cbQuery.SelectedIndex = 0;
                dgEmployeeInfo.AutoGenerateColumns = false; //取消自动创建列
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindData()
        {
            list = eBLL.GetALL();
            dgEmployeeInfo.DataSource = list;
            if (list.Count > 0)
            {
                dgEmployeeInfo.CurrentCell.Selected = false; //设置当前单元格不反蓝
            }
        }

        private void dgEmployeeInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgEmployeeInfo.CurrentRow.Selected = true;
                currentIndex = dgEmployeeInfo.CurrentRow.Index;
                em = list[currentIndex]; //获取当前行的产品类别信息

                if (op == Operation.Update || op == Operation.Delete)
                {
                    ShowEmployee();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowEmployee()
        {
            txtEmployeeID.Text = em.EmployeeID;
            txtEmployeeName.Text = em.EmployeeName;
            txtBrief.Text = em.Brief;
            if (em.Sex == true)
            {
                cbSex.SelectedIndex = 0;
            }
            else
            {
                cbSex.SelectedIndex = 1;
            }
            dtBirthday.Value = em.Birthday;
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
                    em = new Employee();
                    em.EmployeeID = txtEmployeeID.Text;
                    em.EmployeeName = txtEmployeeName.Text;
                    if (cbSex.Text == "男")
                    {
                        em.Sex = true;
                    }
                    else
                    {
                        em.Sex = false;
                    }
                    em.Birthday = dtBirthday.Value.Date;
                    em.Brief = txtBrief.Text;

                    if (eBLL.Insert(em))
                    {
                        MessageBox.Show("新增成功！");
                        BindData();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].EmployeeID == em.EmployeeID)
                            {
                                dgEmployeeInfo.Rows[i].Selected = true;
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
                    if (em == null)
                    {
                        MessageBox.Show("请选择要修改的记录！");
                        return;
                    }
                    em.EmployeeName = txtEmployeeName.Text;
                    if (cbSex.Text == "男")
                    {
                        em.Sex = true;
                    }
                    else
                    {
                        em.Sex = false;
                    }
                    em.Birthday = dtBirthday.Value;
                    em.Brief = txtBrief.Text;

                    if (eBLL.Update(em))
                    {
                        MessageBox.Show("修改成功！");
                        BindData();
                        dgEmployeeInfo.Rows[currentIndex].Selected = true;
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                    }
                }
                else if (op == Operation.Delete)
                {
                    if (em == null)
                    {
                        MessageBox.Show("请选择要删除的记录！");
                        return;
                    }

                    if (eBLL.Delete(em))
                    {
                        MessageBox.Show("删除成功！");
                        em = null;
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (em != null)
            {
                ShowEmployee();
            }
            txtEmployeeID.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (em != null)
            {
                ShowEmployee();
            }
            foreach (Control cc in gbInfo.Controls)
            {
                if (cc is TextBox || cc is ComboBox || cc is DateTimePicker)
                {
                    cc.Enabled = false;
                }
            }
        }

        private void dgEmployeeInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgEmployeeInfo.Columns[e.ColumnIndex].Name == "性别")
            {
                if ((bool)e.Value)
                {
                    e.Value = "男";
                }
                else
                {
                    e.Value = "女";
                }
            }
            if (dgEmployeeInfo.Columns[e.ColumnIndex].Name == "Birthday")
            {
                e.Value = Convert.ToDateTime(e.Value).ToLongDateString();
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
            cbSex.Enabled = true;
            em = null;
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
                    em = eBLL.FindByID(seach);
                    if (em != null)
                    {
                        list = new List<Employee>();
                        list.Add(em);
                        dgEmployeeInfo.DataSource = null;
                        dgEmployeeInfo.DataSource = list;
                        if (list.Count > 0)
                        {
                            dgEmployeeInfo.CurrentCell.Selected = false; //取消反蓝
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
                    list = eBLL.FindByName(txtQueryValue.Text.Trim());
                    if (list == null)
                    {
                        MessageBox.Show("没有查询到记录！");
                        txtQueryValue.Text = "";
                        txtQueryValue.Focus();
                        return;
                    }
                    if (list.Count > 0)
                    {
                        dgEmployeeInfo.DataSource = null;
                        dgEmployeeInfo.DataSource = list;
                        dgEmployeeInfo.CurrentCell.Selected = false; //取消反蓝
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
            SetSelectdIndex(dgEmployeeInfo);
            dgEmployeeInfo.AutoGenerateColumns = false; //取消自动创建列
            list = null;
            txtQueryValue.Text = "";
            txtQueryValue.Focus();
        }
    }
}
