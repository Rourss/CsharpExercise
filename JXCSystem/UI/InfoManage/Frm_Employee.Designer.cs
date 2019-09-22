namespace QiuXingMing.UI.InfoManage
{
    partial class Frm_Employee
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
            this.dgEmployeeInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtBrief = new System.Windows.Forms.TextBox();
            this.gbInfo.SuspendLayout();
            this.gbSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.txtBrief);
            this.gbInfo.Controls.Add(this.dtBirthday);
            this.gbInfo.Controls.Add(this.cbSex);
            this.gbInfo.Controls.Add(this.txtEmployeeName);
            this.gbInfo.Controls.Add(this.txtEmployeeID);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.SetChildIndex(this.label1, 0);
            this.gbInfo.Controls.SetChildIndex(this.label2, 0);
            this.gbInfo.Controls.SetChildIndex(this.label3, 0);
            this.gbInfo.Controls.SetChildIndex(this.label5, 0);
            this.gbInfo.Controls.SetChildIndex(this.label4, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtEmployeeID, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtEmployeeName, 0);
            this.gbInfo.Controls.SetChildIndex(this.btnSave, 0);
            this.gbInfo.Controls.SetChildIndex(this.btnCancel, 0);
            this.gbInfo.Controls.SetChildIndex(this.cbSex, 0);
            this.gbInfo.Controls.SetChildIndex(this.dtBirthday, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtBrief, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cbQuery
            // 
            this.cbQuery.Items.AddRange(new object[] {
            "显示所有员工",
            "按员工编号查询",
            "按员工名称查询"});
            this.cbQuery.SelectedIndexChanged += new System.EventHandler(this.cbQuery_SelectedIndexChanged);
            // 
            // dgEmployeeInfo
            // 
            this.dgEmployeeInfo.AllowUserToAddRows = false;
            this.dgEmployeeInfo.AllowUserToDeleteRows = false;
            this.dgEmployeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployeeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.性别,
            this.Birthday,
            this.Column5});
            this.dgEmployeeInfo.Location = new System.Drawing.Point(12, 89);
            this.dgEmployeeInfo.Name = "dgEmployeeInfo";
            this.dgEmployeeInfo.ReadOnly = true;
            this.dgEmployeeInfo.RowTemplate.Height = 23;
            this.dgEmployeeInfo.Size = new System.Drawing.Size(840, 228);
            this.dgEmployeeInfo.TabIndex = 3;
            this.dgEmployeeInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployeeInfo_CellClick);
            this.dgEmployeeInfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgEmployeeInfo_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EmployeeID";
            this.Column1.HeaderText = "员工编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "EmployeeName";
            this.Column2.HeaderText = "员工姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // 性别
            // 
            this.性别.DataPropertyName = "Sex";
            this.性别.HeaderText = "性别";
            this.性别.Name = "性别";
            this.性别.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "出生日期";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Brief";
            this.Column5.HeaderText = "简历";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "出生日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "员工编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "员工姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "简历：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "性    别：";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(105, 30);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(144, 21);
            this.txtEmployeeID.TabIndex = 2;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(105, 88);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(144, 21);
            this.txtEmployeeName.TabIndex = 2;
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbSex.Location = new System.Drawing.Point(105, 145);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(144, 20);
            this.cbSex.TabIndex = 3;
            // 
            // dtBirthday
            // 
            this.dtBirthday.Location = new System.Drawing.Point(105, 196);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(144, 21);
            this.dtBirthday.TabIndex = 4;
            // 
            // txtBrief
            // 
            this.txtBrief.Location = new System.Drawing.Point(349, 30);
            this.txtBrief.Multiline = true;
            this.txtBrief.Name = "txtBrief";
            this.txtBrief.Size = new System.Drawing.Size(308, 187);
            this.txtBrief.TabIndex = 5;
            // 
            // Frm_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 612);
            this.Controls.Add(this.dgEmployeeInfo);
            this.Name = "Frm_Employee";
            this.Text = "员工信息管理";
            this.Load += new System.EventHandler(this.Frm_Employee_Load);
            this.Controls.SetChildIndex(this.gbSelect, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.gbInfo, 0);
            this.Controls.SetChildIndex(this.dgEmployeeInfo, 0);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmployeeInfo;
        private System.Windows.Forms.TextBox txtBrief;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}