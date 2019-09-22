namespace QiuXingMing.UI.PurchaseManage
{
    partial class Frm_FillPurchaseBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnConcel = new System.Windows.Forms.Button();
            this.btnDeleteDetail = new System.Windows.Forms.Button();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.gbSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPurchaseID
            // 
            this.txtPurchaseID.TextChanged += new System.EventHandler(this.txtPurchaseID_TextChanged);
            // 
            // dtPurchaseDate
            // 
            this.dtPurchaseDate.ValueChanged += new System.EventHandler(this.dtPurchaseDate_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(118, 299);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnRevoke
            // 
            this.btnRevoke.Location = new System.Drawing.Point(220, 299);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(75, 23);
            this.btnRevoke.TabIndex = 11;
            this.btnRevoke.Text = "撤销";
            this.btnRevoke.UseVisualStyleBackColor = true;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(685, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "存盘";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnConcel
            // 
            this.btnConcel.Enabled = false;
            this.btnConcel.Location = new System.Drawing.Point(778, 299);
            this.btnConcel.Name = "btnConcel";
            this.btnConcel.Size = new System.Drawing.Size(75, 23);
            this.btnConcel.TabIndex = 11;
            this.btnConcel.Text = "取消";
            this.btnConcel.UseVisualStyleBackColor = true;
            this.btnConcel.Click += new System.EventHandler(this.btnConcel_Click);
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.Enabled = false;
            this.btnDeleteDetail.Location = new System.Drawing.Point(452, 573);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(400, 27);
            this.btnDeleteDetail.TabIndex = 11;
            this.btnDeleteDetail.Text = "删除明细信息";
            this.btnDeleteDetail.UseVisualStyleBackColor = true;
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Enabled = false;
            this.btnAddDetail.Location = new System.Drawing.Point(14, 573);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(400, 27);
            this.btnAddDetail.TabIndex = 11;
            this.btnAddDetail.Text = "增加明细信息";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // Frm_FillPurchaseBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 612);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.btnDeleteDetail);
            this.Controls.Add(this.btnConcel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRevoke);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Name = "Frm_FillPurchaseBill";
            this.Text = "填写进货单窗口";
            this.Load += new System.EventHandler(this.Frm_FillPurchaseBill_Load);
            this.Controls.SetChildIndex(this.txtPrice, 0);
            this.Controls.SetChildIndex(this.gbSelect, 0);
            this.Controls.SetChildIndex(this.lbPurchaseID, 0);
            this.Controls.SetChildIndex(this.txtPurchaseID, 0);
            this.Controls.SetChildIndex(this.txtOnProcess, 0);
            this.Controls.SetChildIndex(this.txtMemo, 0);
            this.Controls.SetChildIndex(this.dtPurchaseDate, 0);
            this.Controls.SetChildIndex(this.cbSupplierID, 0);
            this.Controls.SetChildIndex(this.txtStockDate, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnModify, 0);
            this.Controls.SetChildIndex(this.btnRevoke, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnConcel, 0);
            this.Controls.SetChildIndex(this.btnDeleteDetail, 0);
            this.Controls.SetChildIndex(this.btnAddDetail, 0);
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRevoke;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnConcel;
        private System.Windows.Forms.Button btnDeleteDetail;
        private System.Windows.Forms.Button btnAddDetail;
    }
}