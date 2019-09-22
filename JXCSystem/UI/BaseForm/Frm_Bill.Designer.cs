namespace QiuXingMing.UI.BaseForm
{
    partial class Frm_Bill
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
            this.lbPurchaseID = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQueryValue = new System.Windows.Forms.TextBox();
            this.cbQuery = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPurchaseID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOnProcess = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbSupplierID = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgPurchaseBill = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.阿西吧 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStockDate = new System.Windows.Forms.TextBox();
            this.gbSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseBill)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPurchaseID
            // 
            this.lbPurchaseID.FormattingEnabled = true;
            this.lbPurchaseID.ItemHeight = 12;
            this.lbPurchaseID.Location = new System.Drawing.Point(13, 13);
            this.lbPurchaseID.Name = "lbPurchaseID";
            this.lbPurchaseID.Size = new System.Drawing.Size(180, 256);
            this.lbPurchaseID.TabIndex = 0;
            this.lbPurchaseID.Click += new System.EventHandler(this.lbPurchaseID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "查询条件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "查 询 值";
            // 
            // txtQueryValue
            // 
            this.txtQueryValue.Location = new System.Drawing.Point(303, 25);
            this.txtQueryValue.Name = "txtQueryValue";
            this.txtQueryValue.Size = new System.Drawing.Size(135, 21);
            this.txtQueryValue.TabIndex = 2;
            // 
            // cbQuery
            // 
            this.cbQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuery.FormattingEnabled = true;
            this.cbQuery.Items.AddRange(new object[] {
            "按单据编号查询",
            "按业务员姓名查询",
            "按审核员姓名查询",
            "按完成状态查询",
            "按订单日期查询"});
            this.cbQuery.Location = new System.Drawing.Point(78, 26);
            this.cbQuery.Name = "cbQuery";
            this.cbQuery.Size = new System.Drawing.Size(135, 20);
            this.cbQuery.TabIndex = 3;
            this.cbQuery.SelectedIndexChanged += new System.EventHandler(this.cbQuery_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "开始日期";
            // 
            // txtPurchaseID
            // 
            this.txtPurchaseID.Enabled = false;
            this.txtPurchaseID.Location = new System.Drawing.Point(502, 131);
            this.txtPurchaseID.Name = "txtPurchaseID";
            this.txtPurchaseID.Size = new System.Drawing.Size(135, 21);
            this.txtPurchaseID.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "订单日期";
            // 
            // txtOnProcess
            // 
            this.txtOnProcess.Enabled = false;
            this.txtOnProcess.Location = new System.Drawing.Point(277, 248);
            this.txtOnProcess.Name = "txtOnProcess";
            this.txtOnProcess.Size = new System.Drawing.Size(134, 21);
            this.txtOnProcess.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "订单编号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "结束日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "完成状态";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "备注";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "供应商";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "入库日期";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(683, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "总价";
            // 
            // dtPurchaseDate
            // 
            this.dtPurchaseDate.Enabled = false;
            this.dtPurchaseDate.Location = new System.Drawing.Point(277, 128);
            this.dtPurchaseDate.Name = "dtPurchaseDate";
            this.dtPurchaseDate.Size = new System.Drawing.Size(135, 21);
            this.dtPurchaseDate.TabIndex = 4;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Enabled = false;
            this.dtEndDate.Location = new System.Drawing.Point(303, 67);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(135, 21);
            this.dtEndDate.TabIndex = 4;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(486, 67);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dtStartDate
            // 
            this.dtStartDate.Enabled = false;
            this.dtStartDate.Location = new System.Drawing.Point(78, 67);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(134, 21);
            this.dtStartDate.TabIndex = 4;
            // 
            // cbSupplierID
            // 
            this.cbSupplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplierID.Enabled = false;
            this.cbSupplierID.FormattingEnabled = true;
            this.cbSupplierID.Location = new System.Drawing.Point(278, 208);
            this.cbSupplierID.Name = "cbSupplierID";
            this.cbSupplierID.Size = new System.Drawing.Size(134, 20);
            this.cbSupplierID.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(718, 357);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(135, 21);
            this.txtPrice.TabIndex = 2;
            // 
            // txtMemo
            // 
            this.txtMemo.Enabled = false;
            this.txtMemo.Location = new System.Drawing.Point(478, 168);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(159, 101);
            this.txtMemo.TabIndex = 2;
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.label1);
            this.gbSelect.Controls.Add(this.label2);
            this.gbSelect.Controls.Add(this.btnSelect);
            this.gbSelect.Controls.Add(this.cbQuery);
            this.gbSelect.Controls.Add(this.dtEndDate);
            this.gbSelect.Controls.Add(this.txtQueryValue);
            this.gbSelect.Controls.Add(this.dtStartDate);
            this.gbSelect.Controls.Add(this.label3);
            this.gbSelect.Controls.Add(this.label6);
            this.gbSelect.Location = new System.Drawing.Point(199, 12);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(654, 110);
            this.gbSelect.TabIndex = 7;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "查询";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "进货单明细列表";
            // 
            // dgPurchaseBill
            // 
            this.dgPurchaseBill.AllowUserToAddRows = false;
            this.dgPurchaseBill.AllowUserToDeleteRows = false;
            this.dgPurchaseBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPurchaseBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.阿西吧,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgPurchaseBill.Location = new System.Drawing.Point(13, 387);
            this.dgPurchaseBill.Name = "dgPurchaseBill";
            this.dgPurchaseBill.RowTemplate.Height = 23;
            this.dgPurchaseBill.Size = new System.Drawing.Size(840, 180);
            this.dgPurchaseBill.TabIndex = 9;
            this.dgPurchaseBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPurchaseBill_CellClick);
            this.dgPurchaseBill.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgPurchaseBill_CellFormatting);
            this.dgPurchaseBill.CurrentCellChanged += new System.EventHandler(this.dgPurchaseBill_CurrentCellChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PurchaseID";
            this.Column1.HeaderText = "订单编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PurchaseDetailID";
            this.Column2.HeaderText = "订单明细编号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // 阿西吧
            // 
            this.阿西吧.DataPropertyName = "ProductID";
            this.阿西吧.HeaderText = "产品编号";
            this.阿西吧.Name = "阿西吧";
            this.阿西吧.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PurchasePrice";
            this.Column4.HeaderText = "购入价格";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Quantity";
            this.Column5.HeaderText = "数量";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Account";
            this.Column6.HeaderText = "价格";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // txtStockDate
            // 
            this.txtStockDate.Enabled = false;
            this.txtStockDate.Location = new System.Drawing.Point(277, 168);
            this.txtStockDate.Name = "txtStockDate";
            this.txtStockDate.Size = new System.Drawing.Size(134, 21);
            this.txtStockDate.TabIndex = 10;
            // 
            // Frm_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 612);
            this.Controls.Add(this.txtStockDate);
            this.Controls.Add(this.dgPurchaseBill);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gbSelect);
            this.Controls.Add(this.cbSupplierID);
            this.Controls.Add(this.dtPurchaseDate);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtOnProcess);
            this.Controls.Add(this.txtPurchaseID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPurchaseID);
            this.Name = "Frm_Bill";
            this.Text = "Frm_Bill";
            this.Load += new System.EventHandler(this.Frm_Bill_Load);
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label12;
        protected System.Windows.Forms.ListBox lbPurchaseID;
        protected System.Windows.Forms.DataGridView dgPurchaseBill;
        protected System.Windows.Forms.TextBox txtPurchaseID;
        protected System.Windows.Forms.TextBox txtOnProcess;
        protected System.Windows.Forms.DateTimePicker dtPurchaseDate;
        protected System.Windows.Forms.ComboBox cbSupplierID;
        protected System.Windows.Forms.TextBox txtMemo;
        protected System.Windows.Forms.TextBox txtStockDate;
        protected System.Windows.Forms.GroupBox gbSelect;
        protected System.Windows.Forms.TextBox txtQueryValue;
        protected System.Windows.Forms.TextBox txtPrice;
        protected System.Windows.Forms.ComboBox cbQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 阿西吧;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}