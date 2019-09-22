namespace QiuXingMing.UI.PurchaseManage
{
    partial class Frm_ExamPurchaseBill
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
            this.btnSignature = new System.Windows.Forms.Button();
            this.btnNoSignature = new System.Windows.Forms.Button();
            this.btnRepeal = new System.Windows.Forms.Button();
            this.btnRecovery = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtClerkName = new System.Windows.Forms.TextBox();
            this.txtExaminerName = new System.Windows.Forms.TextBox();
            this.txtCustodianName = new System.Windows.Forms.TextBox();
            this.gbSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPurchaseID
            // 
            this.lbPurchaseID.Click += new System.EventHandler(this.lbPurchaseID_Click);
            // 
            // btnSignature
            // 
            this.btnSignature.Location = new System.Drawing.Point(13, 292);
            this.btnSignature.Name = "btnSignature";
            this.btnSignature.Size = new System.Drawing.Size(100, 25);
            this.btnSignature.TabIndex = 11;
            this.btnSignature.Text = "审核签名";
            this.btnSignature.UseVisualStyleBackColor = true;
            this.btnSignature.Click += new System.EventHandler(this.btnSignature_Click);
            // 
            // btnNoSignature
            // 
            this.btnNoSignature.Location = new System.Drawing.Point(199, 292);
            this.btnNoSignature.Name = "btnNoSignature";
            this.btnNoSignature.Size = new System.Drawing.Size(100, 25);
            this.btnNoSignature.TabIndex = 11;
            this.btnNoSignature.Text = "取消审核签名";
            this.btnNoSignature.UseVisualStyleBackColor = true;
            this.btnNoSignature.Click += new System.EventHandler(this.btnNoSignature_Click);
            // 
            // btnRepeal
            // 
            this.btnRepeal.Location = new System.Drawing.Point(646, 292);
            this.btnRepeal.Name = "btnRepeal";
            this.btnRepeal.Size = new System.Drawing.Size(100, 25);
            this.btnRepeal.TabIndex = 11;
            this.btnRepeal.Text = "撤销";
            this.btnRepeal.UseVisualStyleBackColor = true;
            this.btnRepeal.Click += new System.EventHandler(this.btnRepeal_Click);
            // 
            // btnRecovery
            // 
            this.btnRecovery.Location = new System.Drawing.Point(752, 292);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(100, 25);
            this.btnRecovery.TabIndex = 11;
            this.btnRecovery.Text = "恢复";
            this.btnRecovery.UseVisualStyleBackColor = true;
            this.btnRecovery.Click += new System.EventHandler(this.btnRecovery_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 582);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "业务员";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(349, 582);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 12;
            this.label14.Text = "审核员";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(705, 582);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 12;
            this.label15.Text = "保管员";
            // 
            // txtClerkName
            // 
            this.txtClerkName.Enabled = false;
            this.txtClerkName.Location = new System.Drawing.Point(58, 579);
            this.txtClerkName.Name = "txtClerkName";
            this.txtClerkName.Size = new System.Drawing.Size(100, 21);
            this.txtClerkName.TabIndex = 13;
            // 
            // txtExaminerName
            // 
            this.txtExaminerName.Enabled = false;
            this.txtExaminerName.Location = new System.Drawing.Point(396, 579);
            this.txtExaminerName.Name = "txtExaminerName";
            this.txtExaminerName.Size = new System.Drawing.Size(100, 21);
            this.txtExaminerName.TabIndex = 13;
            // 
            // txtCustodianName
            // 
            this.txtCustodianName.Enabled = false;
            this.txtCustodianName.Location = new System.Drawing.Point(752, 579);
            this.txtCustodianName.Name = "txtCustodianName";
            this.txtCustodianName.Size = new System.Drawing.Size(100, 21);
            this.txtCustodianName.TabIndex = 13;
            // 
            // Frm_ExamPurchaseBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 612);
            this.Controls.Add(this.txtCustodianName);
            this.Controls.Add(this.txtExaminerName);
            this.Controls.Add(this.txtClerkName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnRecovery);
            this.Controls.Add(this.btnRepeal);
            this.Controls.Add(this.btnNoSignature);
            this.Controls.Add(this.btnSignature);
            this.Name = "Frm_ExamPurchaseBill";
            this.Text = "审核进货单窗口";
            this.Controls.SetChildIndex(this.txtPrice, 0);
            this.Controls.SetChildIndex(this.gbSelect, 0);
            this.Controls.SetChildIndex(this.txtPurchaseID, 0);
            this.Controls.SetChildIndex(this.txtOnProcess, 0);
            this.Controls.SetChildIndex(this.txtMemo, 0);
            this.Controls.SetChildIndex(this.dtPurchaseDate, 0);
            this.Controls.SetChildIndex(this.cbSupplierID, 0);
            this.Controls.SetChildIndex(this.txtStockDate, 0);
            this.Controls.SetChildIndex(this.lbPurchaseID, 0);
            this.Controls.SetChildIndex(this.btnSignature, 0);
            this.Controls.SetChildIndex(this.btnNoSignature, 0);
            this.Controls.SetChildIndex(this.btnRepeal, 0);
            this.Controls.SetChildIndex(this.btnRecovery, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.txtClerkName, 0);
            this.Controls.SetChildIndex(this.txtExaminerName, 0);
            this.Controls.SetChildIndex(this.txtCustodianName, 0);
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignature;
        private System.Windows.Forms.Button btnNoSignature;
        private System.Windows.Forms.Button btnRepeal;
        private System.Windows.Forms.Button btnRecovery;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtClerkName;
        private System.Windows.Forms.TextBox txtExaminerName;
        private System.Windows.Forms.TextBox txtCustodianName;
    }
}