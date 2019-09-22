using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QiuXingMing.UI.BaseForm
{
    public partial class Frm_BaseInfo : Form
    {
        protected Operation op;
        public Frm_BaseInfo()
        {
            InitializeComponent();
            op = Operation.None;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            op = Operation.Insert;
            gbInfo.Visible = true;
            gbInfo.Text = "新增记录信息";
            btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            op = Operation.Update;
            gbInfo.Visible = true;
            gbInfo.Text = "修改记录信息";
            btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            op = Operation.Delete;
            gbInfo.Visible = true;
            gbInfo.Text = "删除记录信息";
            btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            op = Operation.None;
            gbInfo.Visible = false;
            btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = true;
        }
        public void SetSelectdIndex(DataGridView dg)
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
            dg.DataSource = null;
        }
    }
}
