namespace QiuXingMing.UI.PurchaseManage
{
    partial class Frm_ChooseProduct
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
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cbQuery = new System.Windows.Forms.ComboBox();
            this.txtQueryValue = new System.Windows.Forms.TextBox();
            this.dgProductInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.阿西吧 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.label1);
            this.gbSelect.Controls.Add(this.lblValue);
            this.gbSelect.Controls.Add(this.btnSelect);
            this.gbSelect.Controls.Add(this.cbQuery);
            this.gbSelect.Controls.Add(this.txtQueryValue);
            this.gbSelect.Location = new System.Drawing.Point(12, 12);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(840, 71);
            this.gbSelect.TabIndex = 8;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "查询";
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
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(244, 29);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(53, 12);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "查 询 值";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(469, 24);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cbQuery
            // 
            this.cbQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuery.FormattingEnabled = true;
            this.cbQuery.Items.AddRange(new object[] {
            "显示所有",
            "按产品名称查询",
            "按产品类别查询"});
            this.cbQuery.Location = new System.Drawing.Point(78, 26);
            this.cbQuery.Name = "cbQuery";
            this.cbQuery.Size = new System.Drawing.Size(135, 20);
            this.cbQuery.TabIndex = 3;
            this.cbQuery.SelectedIndexChanged += new System.EventHandler(this.cbQuery_SelectedIndexChanged);
            // 
            // txtQueryValue
            // 
            this.txtQueryValue.Location = new System.Drawing.Point(303, 25);
            this.txtQueryValue.Name = "txtQueryValue";
            this.txtQueryValue.Size = new System.Drawing.Size(135, 21);
            this.txtQueryValue.TabIndex = 2;
            // 
            // dgProductInfo
            // 
            this.dgProductInfo.AllowUserToAddRows = false;
            this.dgProductInfo.AllowUserToDeleteRows = false;
            this.dgProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.阿西吧,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgProductInfo.Location = new System.Drawing.Point(12, 89);
            this.dgProductInfo.Name = "dgProductInfo";
            this.dgProductInfo.ReadOnly = true;
            this.dgProductInfo.RowTemplate.Height = 23;
            this.dgProductInfo.Size = new System.Drawing.Size(840, 511);
            this.dgProductInfo.TabIndex = 9;
            this.dgProductInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductInfo_CellClick);
            this.dgProductInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductInfo_CellDoubleClick);
            this.dgProductInfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgProductInfo_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ProductID";
            this.Column1.HeaderText = "产品编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ProductName";
            this.Column2.HeaderText = "产品名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SpellingCode";
            this.Column3.HeaderText = "拼音码";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "BarCode";
            this.Column4.HeaderText = "条形码";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Special";
            this.Column5.HeaderText = "规格";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Unit";
            this.Column6.HeaderText = "计量单位";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Origin";
            this.Column7.HeaderText = "产地";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // 阿西吧
            // 
            this.阿西吧.DataPropertyName = "CategoryID";
            this.阿西吧.HeaderText = "产品类别";
            this.阿西吧.Name = "阿西吧";
            this.阿西吧.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "PurchasePrice";
            this.Column9.HeaderText = "购入价格";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "SalePrice";
            this.Column10.HeaderText = "销售价格";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Quantity";
            this.Column11.HeaderText = "数量";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Frm_ChooseProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 612);
            this.Controls.Add(this.dgProductInfo);
            this.Controls.Add(this.gbSelect);
            this.Name = "Frm_ChooseProduct";
            this.Text = "选择产品窗口";
            this.Load += new System.EventHandler(this.Frm_ChooseProduct_Load);
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnSelect;
        protected System.Windows.Forms.ComboBox cbQuery;
        protected System.Windows.Forms.TextBox txtQueryValue;
        private System.Windows.Forms.DataGridView dgProductInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn 阿西吧;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;

    }
}