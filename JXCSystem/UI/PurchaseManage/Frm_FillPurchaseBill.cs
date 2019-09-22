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
    public partial class Frm_FillPurchaseBill : BaseForm.Frm_Bill
    {
        private Operation op;
        private static PurchaseDetail detail_Add; //要增加的明细
        private string userID = "1"; //从登陆窗体传入

        public string UserID
        {
            set { userID = value; }
        }

        public static PurchaseDetail Detail_Add
        {
            get { return Frm_FillPurchaseBill.detail_Add; }
            set { Frm_FillPurchaseBill.detail_Add = value; }
        }
        public Frm_FillPurchaseBill()
        {
            InitializeComponent();
            op = Operation.None;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            op = Operation.Insert;
            try
            {
                //命令按钮的控制（7个按钮）
                btnAdd.Enabled = btnRevoke.Enabled = btnModify.Enabled = false;
                btnSave.Enabled = btnConcel.Enabled = true;
                btnAddDetail.Enabled = btnDeleteDetail.Enabled = true;

                //订单信息控件的控制（6个控件）
                dtPurchaseDate.Enabled = true;
                cbSupplierID.Enabled = true;
                txtMemo.Enabled = true;
                txtOnProcess.Enabled = txtStockDate.Enabled = txtPurchaseID.Enabled = false;

                //列表框的控制（1个控制）
                lbPurchaseID.Enabled = false;

                //DataGridView列的控制（2列）
                dgPurchaseBill.Columns[3].ReadOnly = false;
                dgPurchaseBill.Columns[4].ReadOnly = false;

                //查询控件的控制（分组框的控制）
                gbSelect.Enabled = false;
                pBill = new PurchaseBill(); //初始化订单
                detailList = new List<PurchaseDetail>(); //初始化明细列表
                ClearControls();
               
            }
            catch 
            {
                
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (pBill == null)
            {
                MessageBox.Show("请选择要修改的一笔订单！");
                return ;
            }
            if (pBill.OnProcess == 1 || pBill.OnProcess == 2)
            {
                MessageBox.Show("该订单已撤销或已完成，不能进行修改！");
                return;
            }
            if (pBill.Examiner != "")
            {
                MessageBox.Show("该订单已审核，不能进行修改！");
                return;
            }

            op = Operation.Update;
            try
            {
                //命令按钮的控制（7个按钮）
                btnAdd.Enabled = btnRevoke.Enabled = btnModify.Enabled = false;
                btnSave.Enabled = btnConcel.Enabled = true;
                btnAddDetail.Enabled = btnDeleteDetail.Enabled = true;

                //订单信息控件的控制（6个控件）
                dtPurchaseDate.Enabled = false;
                cbSupplierID.Enabled = true;
                txtMemo.Enabled = true;
                txtOnProcess.Enabled = txtStockDate.Enabled = txtPurchaseID.Enabled = false;

                //列表框的控制（1个控制）
                lbPurchaseID.Enabled = false;

                //DataGridView列的控制（2列）
                dgPurchaseBill.Columns[3].ReadOnly = false;
                dgPurchaseBill.Columns[4].ReadOnly = false;

                //查询控件的控制（分组框的控制）
                gbSelect.Enabled = false;
            }
            catch 
            {
                
            }
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            op = Operation.Delete;
            if (pBill == null)
            {
                MessageBox.Show("请选择要撤销的一笔订单！");
                return;
            }
            if (pBill.OnProcess==1)
            {
                MessageBox.Show("该订单已撤销！");
                return;
            }
            try
            {
                //命令按钮的控制（7个按钮）
                btnAdd.Enabled = btnRevoke.Enabled = btnModify.Enabled = false;
                btnSave.Enabled = btnConcel.Enabled = true;
                btnAddDetail.Enabled = btnDeleteDetail.Enabled = false;

                //订单信息控件的控制（6个控件）
                dtPurchaseDate.Enabled = false;
                cbSupplierID.Enabled = false;
                txtMemo.Enabled = true;
                txtOnProcess.Enabled = txtStockDate.Enabled = txtPurchaseID.Enabled = false;

                //列表框的控制（1个控制）
                lbPurchaseID.Enabled = false;

                //DataGridView列的控制（2列）
                dgPurchaseBill.Columns[3].ReadOnly = true;
                dgPurchaseBill.Columns[4].ReadOnly = true;

                //查询控件的控制（分组框的控制）
                gbSelect.Enabled = false;


            }
            catch
            {

            }
        }

        private void btnConcel_Click(object sender, EventArgs e)
        {
            op = Operation.None;
            try
            {
                btnAdd.Enabled = btnRevoke.Enabled = btnModify.Enabled = true;
                btnSave.Enabled = btnConcel.Enabled = false;
                btnAddDetail.Enabled = btnDeleteDetail.Enabled = false;

                //订单信息控件的控制（6个控件）
                dtPurchaseDate.Enabled = false;
                cbSupplierID.Enabled = false;
                txtMemo.Enabled = false;
                txtOnProcess.Enabled = txtStockDate.Enabled = txtPurchaseID.Enabled = false;

                //列表框的控制（1个控制）
                lbPurchaseID.Enabled = true;

                //查询控件的控制（分组框的控制）
                gbSelect.Enabled = true;

                lbPurchaseID.DataSource = null;
                pBill = null;
                ClearControls();
            }
            catch
            {

            }
        }

        private void ClearControls()
        {
            txtMemo.Text = "";
            txtQueryValue.Text = "";
            txtPrice.Text = "";
            txtPurchaseID.Text = "";
            txtOnProcess.Text = "";
            txtStockDate.Text = "";
            txtPrice.Text = "";
            dgPurchaseBill.DataSource = null;
            dtPurchaseDate.Value = DateTime.Now;
            cbQuery.SelectedIndex = 0; //设置显示的内容为第一个选项
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (detail_Delete == null)
                {
                    MessageBox.Show("请选择要删除的一笔明细！");
                    return;
                }
                DialogResult result = MessageBox.Show("您确定要删除这笔明细吗？", "确认删除", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    //1.删除这笔明细
                    detailList.Remove(detail_Delete);

                    //2.自动进行重新编号
                    int i = 1;
                    foreach (PurchaseDetail detail in detailList)
                    {
                        detail.PurchaseDetailID = Convert.ToString(i++);
                    }

                    //3.重新绑定数据
                    Binddg();
                    //4.把要删除的明细设为null
                    detail_Delete = null;
                }
            }
            catch
            {
            }
        }

        private void Binddg()
        {
            dgPurchaseBill.DataSource = null;
            if (detailList.Count == 0)
            {
                dgPurchaseBill.DataSource = null;
            }
            else
            {
                dgPurchaseBill.DataSource = detailList;
            }
            if (dgPurchaseBill.CurrentCell != null)
            {
                dgPurchaseBill.CurrentCell.Selected = false;
            }
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ChooseProduct frm = new Frm_ChooseProduct();
                frm.ShowDialog();

                if (detail_Add != null)
                {
                    //1.判断选择的产品是否已存在
                    foreach (PurchaseDetail detail in detailList)
                    {
                        if (detail.ProductID == detail_Add.ProductID)
                        {
                            MessageBox.Show("该产品已存在！");
                            return;
                        }
                    }
                    //2.将要增加的明细补全
                    detail_Add.PurchaseID = txtPurchaseID.Text.Trim();
                    detail_Add.PurchaseDetailID = Convert.ToString(detailList.Count + 1).ToString() ;

                    //3.增加到列表中
                    detailList.Add(detail_Add);
                    dgPurchaseBill.DataSource = null;
                    dgPurchaseBill.DataSource = detailList;
                    if (dgPurchaseBill.CurrentCell != null)
                    {
                        dgPurchaseBill.CurrentCell.Selected = false;
                    }
                    detail_Add = null;
                }
            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (op == Operation.Insert || op == Operation.Update)
            {
                if (detailList.Count == 0)
                {
                    MessageBox.Show("该订单没有明细信息，请新增明细！");
                    return;
                }
                foreach (PurchaseDetail detail in detailList)
                {
                    if (detail.PurchasePrice == 0 || detail.Quantity == "0")
                    {
                        MessageBox.Show("明细的单价和数量不能为0！");
                        return;
                    }
                }
            }
            try
            {
                if (op == Operation.Insert)
                {
                    pBill.PurchaseID = txtPurchaseID.Text.Trim();
                    pBill.SupplierID = cbSupplierID.SelectedValue.ToString();
                    pBill.PurchaseDate = dtPurchaseDate.Value.Date;
                    pBill.StockDate = DateTime.MinValue;
                    pBill.Clerk = userID;
                    pBill.Examiner = "";
                    pBill.Custodian = "";
                    pBill.OnProcess = 0;
                    pBill.Memo = txtMemo.Text.Trim();
                    pBill.DetailList = detailList;
                    if (pBLL.Insert(pBill))
                    {
                        MessageBox.Show("新增成功！");
                        Binddg();
                        pBill = null;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("新增失败！");
                        pBill = null;
                        return;
                    }

                }
                else if (op == Operation.Update)
                {
                    pBill.SupplierID = cbSupplierID.SelectedValue.ToString();
                    pBill.Memo = txtMemo.Text.Trim();
                    pBill.DetailList = detailList;
                    if (pBLL.Update(pBill))
                    {
                        MessageBox.Show("修改成功！");
                        Binddg();
                        pBill = null;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                        pBill = null;
                        return;
                    }
                }
                else if (op == Operation.Delete)
                {
                    pBill.OnProcess = 1;
                    pBill.Memo = txtMemo.Text.Trim();
                    if (pBLL.Update(pBill))
                    {
                        MessageBox.Show("撤销成功！");
                        Binddg();
                        pBill = null;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("撤销失败！");
                        pBill = null;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dtPurchaseDate_ValueChanged(object sender, EventArgs e)
        {
            if (op == Operation.Insert)
            {
                txtPurchaseID.Text = pBLL.CreatePurchaseID(dtPurchaseDate.Value);
            }
            
        }

        private void Frm_FillPurchaseBill_Load(object sender, EventArgs e)
        {
            try
            {
                BindSupplier();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtPurchaseID_TextChanged(object sender, EventArgs e)
        {
            if (op == Operation.Insert && detailList.Count > 0)
            {
                foreach (PurchaseDetail detail in detailList)
                {
                    detail.PurchaseID = txtPurchaseID.Text.Trim();
                }
            }
            Binddg();
        }
    }
}
