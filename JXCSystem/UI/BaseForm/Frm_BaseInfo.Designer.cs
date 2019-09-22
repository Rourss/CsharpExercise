namespace QiuXingMing.UI.BaseForm
{
    partial class Frm_BaseInfo
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cbQuery = new System.Windows.Forms.ComboBox();
            this.txtQueryValue = new System.Windows.Forms.TextBox();
            this.gbInfo.SuspendLayout();
            this.gbSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(594, 326);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "新增";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(686, 326);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(777, 326);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.btnCancel);
            this.gbInfo.Controls.Add(this.btnSave);
            this.gbInfo.Location = new System.Drawing.Point(12, 355);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(840, 245);
            this.gbInfo.TabIndex = 2;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "groupBox1";
            this.gbInfo.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(765, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(674, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "存盘";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.gbSelect.TabIndex = 9;
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
            // 
            // cbQuery
            // 
            this.cbQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuery.FormattingEnabled = true;
            this.cbQuery.Location = new System.Drawing.Point(78, 26);
            this.cbQuery.Name = "cbQuery";
            this.cbQuery.Size = new System.Drawing.Size(135, 20);
            this.cbQuery.TabIndex = 3;
            // 
            // txtQueryValue
            // 
            this.txtQueryValue.Location = new System.Drawing.Point(303, 25);
            this.txtQueryValue.Name = "txtQueryValue";
            this.txtQueryValue.Size = new System.Drawing.Size(135, 21);
            this.txtQueryValue.TabIndex = 2;
            // 
            // Frm_BaseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 612);
            this.Controls.Add(this.gbSelect);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Name = "Frm_BaseInfo";
            this.Text = "Frm_BaseInfo";
            this.gbInfo.ResumeLayout(false);
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnInsert;
        protected System.Windows.Forms.Button btnUpdate;
        protected System.Windows.Forms.Button btnDelete;
        protected System.Windows.Forms.GroupBox gbInfo;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Button btnSave;
        protected System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txtQueryValue;
        protected System.Windows.Forms.Button btnSelect;
        public System.Windows.Forms.ComboBox cbQuery;
        protected System.Windows.Forms.Label lblValue;

    }
}