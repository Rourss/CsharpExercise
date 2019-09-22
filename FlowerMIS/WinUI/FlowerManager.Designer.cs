namespace FlowerMIS.WinUI
{
    partial class FlowerManager
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbFlower1 = new System.Windows.Forms.GroupBox();
            this.cbFlowerType1 = new System.Windows.Forms.ComboBox();
            this.dgFlower = new System.Windows.Forms.DataGridView();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtFlowerName1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFlower2 = new System.Windows.Forms.GroupBox();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.rbDeleteFlower = new System.Windows.Forms.RadioButton();
            this.rbUpdateFlower = new System.Windows.Forms.RadioButton();
            this.rbInsertFlower = new System.Windows.Forms.RadioButton();
            this.pbFlowerPhoto = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFlowerID = new System.Windows.Forms.TextBox();
            this.txtFlowerName2 = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbStock = new System.Windows.Forms.CheckBox();
            this.cbNotStock = new System.Windows.Forms.CheckBox();
            this.cbFlowerType2 = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbFlower1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFlower)).BeginInit();
            this.gbFlower2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlowerPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFlower1
            // 
            this.gbFlower1.Controls.Add(this.cbFlowerType1);
            this.gbFlower1.Controls.Add(this.dgFlower);
            this.gbFlower1.Controls.Add(this.btnCancel1);
            this.gbFlower1.Controls.Add(this.btnQuery);
            this.gbFlower1.Controls.Add(this.txtFlowerName1);
            this.gbFlower1.Controls.Add(this.label2);
            this.gbFlower1.Controls.Add(this.label1);
            this.gbFlower1.Location = new System.Drawing.Point(13, 13);
            this.gbFlower1.Name = "gbFlower1";
            this.gbFlower1.Size = new System.Drawing.Size(946, 284);
            this.gbFlower1.TabIndex = 0;
            this.gbFlower1.TabStop = false;
            this.gbFlower1.Text = "花卉查询";
            // 
            // cbFlowerType1
            // 
            this.cbFlowerType1.FormattingEnabled = true;
            this.cbFlowerType1.Items.AddRange(new object[] {
            "鲜花",
            "绿色植物",
            "多肉植物",
            "其他"});
            this.cbFlowerType1.Location = new System.Drawing.Point(408, 28);
            this.cbFlowerType1.Name = "cbFlowerType1";
            this.cbFlowerType1.Size = new System.Drawing.Size(121, 20);
            this.cbFlowerType1.TabIndex = 7;
            this.cbFlowerType1.SelectedIndexChanged += new System.EventHandler(this.cbFlowerType1_SelectedIndexChanged);
            // 
            // dgFlower
            // 
            this.dgFlower.AllowUserToAddRows = false;
            this.dgFlower.AllowUserToDeleteRows = false;
            this.dgFlower.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFlower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFlower.Location = new System.Drawing.Point(6, 75);
            this.dgFlower.Name = "dgFlower";
            this.dgFlower.ReadOnly = true;
            this.dgFlower.RowTemplate.Height = 23;
            this.dgFlower.Size = new System.Drawing.Size(934, 203);
            this.dgFlower.TabIndex = 6;
            this.dgFlower.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFlower_CellClick);
            // 
            // btnCancel1
            // 
            this.btnCancel1.Location = new System.Drawing.Point(830, 31);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(75, 23);
            this.btnCancel1.TabIndex = 5;
            this.btnCancel1.Text = "取消";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(719, 31);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtFlowerName1
            // 
            this.txtFlowerName1.Location = new System.Drawing.Point(93, 28);
            this.txtFlowerName1.Name = "txtFlowerName1";
            this.txtFlowerName1.Size = new System.Drawing.Size(100, 21);
            this.txtFlowerName1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "花卉类别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "花卉名称：";
            // 
            // gbFlower2
            // 
            this.gbFlower2.Controls.Add(this.btnCancel2);
            this.gbFlower2.Controls.Add(this.btnConfirm);
            this.gbFlower2.Controls.Add(this.rbDeleteFlower);
            this.gbFlower2.Controls.Add(this.rbUpdateFlower);
            this.gbFlower2.Controls.Add(this.rbInsertFlower);
            this.gbFlower2.Controls.Add(this.pbFlowerPhoto);
            this.gbFlower2.Controls.Add(this.label7);
            this.gbFlower2.Controls.Add(this.label6);
            this.gbFlower2.Controls.Add(this.label5);
            this.gbFlower2.Controls.Add(this.label4);
            this.gbFlower2.Controls.Add(this.label3);
            this.gbFlower2.Controls.Add(this.txtFlowerID);
            this.gbFlower2.Controls.Add(this.txtFlowerName2);
            this.gbFlower2.Controls.Add(this.txtPrice);
            this.gbFlower2.Controls.Add(this.cbStock);
            this.gbFlower2.Controls.Add(this.cbNotStock);
            this.gbFlower2.Controls.Add(this.cbFlowerType2);
            this.gbFlower2.Location = new System.Drawing.Point(13, 303);
            this.gbFlower2.Name = "gbFlower2";
            this.gbFlower2.Size = new System.Drawing.Size(946, 348);
            this.gbFlower2.TabIndex = 1;
            this.gbFlower2.TabStop = false;
            this.gbFlower2.Text = "花卉操作";
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(830, 285);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 23);
            this.btnCancel2.TabIndex = 10;
            this.btnCancel2.Text = "取消";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(719, 285);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // rbDeleteFlower
            // 
            this.rbDeleteFlower.AutoSize = true;
            this.rbDeleteFlower.Location = new System.Drawing.Point(339, 272);
            this.rbDeleteFlower.Name = "rbDeleteFlower";
            this.rbDeleteFlower.Size = new System.Drawing.Size(47, 16);
            this.rbDeleteFlower.TabIndex = 8;
            this.rbDeleteFlower.Text = "删除";
            this.rbDeleteFlower.UseVisualStyleBackColor = true;
            // 
            // rbUpdateFlower
            // 
            this.rbUpdateFlower.AutoSize = true;
            this.rbUpdateFlower.Location = new System.Drawing.Point(206, 272);
            this.rbUpdateFlower.Name = "rbUpdateFlower";
            this.rbUpdateFlower.Size = new System.Drawing.Size(47, 16);
            this.rbUpdateFlower.TabIndex = 8;
            this.rbUpdateFlower.Text = "修改";
            this.rbUpdateFlower.UseVisualStyleBackColor = true;
            this.rbUpdateFlower.Click += new System.EventHandler(this.rbUpdateFlower_Click);
            // 
            // rbInsertFlower
            // 
            this.rbInsertFlower.AutoSize = true;
            this.rbInsertFlower.Checked = true;
            this.rbInsertFlower.Location = new System.Drawing.Point(93, 273);
            this.rbInsertFlower.Name = "rbInsertFlower";
            this.rbInsertFlower.Size = new System.Drawing.Size(47, 16);
            this.rbInsertFlower.TabIndex = 8;
            this.rbInsertFlower.TabStop = true;
            this.rbInsertFlower.Text = "新增";
            this.rbInsertFlower.UseVisualStyleBackColor = true;
            this.rbInsertFlower.Click += new System.EventHandler(this.rbInsertFlower_Click);
            // 
            // pbFlowerPhoto
            // 
            this.pbFlowerPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFlowerPhoto.Location = new System.Drawing.Point(659, 18);
            this.pbFlowerPhoto.Name = "pbFlowerPhoto";
            this.pbFlowerPhoto.Size = new System.Drawing.Size(281, 230);
            this.pbFlowerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlowerPhoto.TabIndex = 7;
            this.pbFlowerPhoto.TabStop = false;
            this.toolTip1.SetToolTip(this.pbFlowerPhoto, "请单击这里增加或修改照片");
            this.pbFlowerPhoto.Click += new System.EventHandler(this.pbFlowerPhoto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "状态：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "价格：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "花卉类别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "花卉名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "花卉编号：";
            // 
            // txtFlowerID
            // 
            this.txtFlowerID.Location = new System.Drawing.Point(93, 37);
            this.txtFlowerID.Name = "txtFlowerID";
            this.txtFlowerID.Size = new System.Drawing.Size(100, 21);
            this.txtFlowerID.TabIndex = 2;
            // 
            // txtFlowerName2
            // 
            this.txtFlowerName2.Location = new System.Drawing.Point(93, 124);
            this.txtFlowerName2.Name = "txtFlowerName2";
            this.txtFlowerName2.Size = new System.Drawing.Size(100, 21);
            this.txtFlowerName2.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(93, 195);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 1;
            // 
            // cbStock
            // 
            this.cbStock.AutoSize = true;
            this.cbStock.Location = new System.Drawing.Point(408, 126);
            this.cbStock.Name = "cbStock";
            this.cbStock.Size = new System.Drawing.Size(48, 16);
            this.cbStock.TabIndex = 11;
            this.cbStock.Text = "有货";
            this.cbStock.UseVisualStyleBackColor = true;
            this.cbStock.Click += new System.EventHandler(this.cbStock_Click);
            // 
            // cbNotStock
            // 
            this.cbNotStock.AutoSize = true;
            this.cbNotStock.Location = new System.Drawing.Point(481, 126);
            this.cbNotStock.Name = "cbNotStock";
            this.cbNotStock.Size = new System.Drawing.Size(48, 16);
            this.cbNotStock.TabIndex = 12;
            this.cbNotStock.Text = "无货";
            this.cbNotStock.UseVisualStyleBackColor = true;
            this.cbNotStock.Click += new System.EventHandler(this.cbNotStock_Click);
            // 
            // cbFlowerType2
            // 
            this.cbFlowerType2.FormattingEnabled = true;
            this.cbFlowerType2.Items.AddRange(new object[] {
            "鲜花",
            "绿色植物",
            "多肉植物",
            "其他"});
            this.cbFlowerType2.Location = new System.Drawing.Point(408, 37);
            this.cbFlowerType2.Name = "cbFlowerType2";
            this.cbFlowerType2.Size = new System.Drawing.Size(121, 20);
            this.cbFlowerType2.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FlowerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 663);
            this.Controls.Add(this.gbFlower2);
            this.Controls.Add(this.gbFlower1);
            this.Name = "FlowerManager";
            this.Text = "花卉管理";
            this.Load += new System.EventHandler(this.FlowerManager_Load);
            this.gbFlower1.ResumeLayout(false);
            this.gbFlower1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFlower)).EndInit();
            this.gbFlower2.ResumeLayout(false);
            this.gbFlower2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlowerPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFlower1;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtFlowerName1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFlower2;
        private System.Windows.Forms.DataGridView dgFlower;
        private System.Windows.Forms.ComboBox cbFlowerType1;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RadioButton rbDeleteFlower;
        private System.Windows.Forms.RadioButton rbUpdateFlower;
        private System.Windows.Forms.RadioButton rbInsertFlower;
        private System.Windows.Forms.PictureBox pbFlowerPhoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFlowerName2;
        private System.Windows.Forms.TextBox txtFlowerID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbFlowerType2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox cbNotStock;
        private System.Windows.Forms.CheckBox cbStock;
    }
}

