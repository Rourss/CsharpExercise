namespace QiuXingMing.UI.PurchaseManage
{
    partial class Frm_InStockCheck
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
            this.btnRecovery = new System.Windows.Forms.Button();
            this.btnRepeal = new System.Windows.Forms.Button();
            this.txtCustodianName = new System.Windows.Forms.TextBox();
            this.txtExaminerName = new System.Windows.Forms.TextBox();
            this.txtClerkName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCustodianS = new System.Windows.Forms.Button();
            this.gbSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPurchaseID
            // 
            this.lbPurchaseID.Click += new System.EventHandler(this.lbPurchaseID_Click);
            // 
            // btnRecovery
            // 
            this.btnRecovery.Location = new System.Drawing.Point(753, 302);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(100, 25);
            this.btnRecovery.TabIndex = 12;
            this.btnRecovery.Text = "恢复";
            this.btnRecovery.UseVisualStyleBackColor = true;
            this.btnRecovery.Click += new System.EventHandler(this.btnRecovery_Click);
            // 
            // btnRepeal
            // 
            this.btnRepeal.Location = new System.Drawing.Point(647, 302);
            this.btnRepeal.Name = "btnRepeal";
            this.btnRepeal.Size = new System.Drawing.Size(100, 25);
            this.btnRepeal.TabIndex = 13;
            this.btnRepeal.Text = "撤销";
            this.btnRepeal.UseVisualStyleBackColor = true;
            this.btnRepeal.Click += new System.EventHandler(this.btnRepeal_Click);
            // 
            // txtCustodianName
            // 
            this.txtCustodianName.Enabled = false;
            this.txtCustodianName.Location = new System.Drawing.Point(753, 579);
            this.txtCustodianName.Name = "txtCustodianName";
            this.txtCustodianName.Size = new System.Drawing.Size(100, 21);
            this.txtCustodianName.TabIndex = 17;
            // 
            // txtExaminerName
            // 
            this.txtExaminerName.Enabled = false;
            this.txtExaminerName.Location = new System.Drawing.Point(396, 579);
            this.txtExaminerName.Name = "txtExaminerName";
            this.txtExaminerName.Size = new System.Drawing.Size(100, 21);
            this.txtExaminerName.TabIndex = 18;
            // 
            // txtClerkName
            // 
            this.txtClerkName.Enabled = false;
            this.txtClerkName.Location = new System.Drawing.Point(59, 579);
            this.txtClerkName.Name = "txtClerkName";
            this.txtClerkName.Size = new System.Drawing.Size(100, 21);
            this.txtClerkName.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(706, 582);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 14;
            this.label15.Text = "保管员";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(349, 582);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 15;
            this.label14.Text = "审核员";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 582);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "业务员";
            // 
            // btnCustodianS
            // 
            this.btnCustodianS.Location = new System.Drawing.Point(13, 303);
            this.btnCustodianS.Name = "btnCustodianS";
            this.btnCustodianS.Size = new System.Drawing.Size(179, 23);
            this.btnCustodianS.TabIndex = 20;
            this.btnCustodianS.Text = "货品检验通过签名";
            this.btnCustodianS.UseVisualStyleBackColor = true;
            this.btnCustodianS.Click += new System.EventHandler(this.btnCustodianS_Click);
            // 
            // Frm_InStockCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 612);
            this.Controls.Add(this.btnCustodianS);
            this.Controls.Add(this.txtCustodianName);
            this.Controls.Add(this.txtExaminerName);
            this.Controls.Add(this.txtClerkName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnRecovery);
            this.Controls.Add(this.btnRepeal);
            this.Name = "Frm_InStockCheck";
            this.Text = "货物入库检验";
            this.Controls.SetChildIndex(this.txtPurchaseID, 0);
            this.Controls.SetChildIndex(this.txtOnProcess, 0);
            this.Controls.SetChildIndex(this.txtPrice, 0);
            this.Controls.SetChildIndex(this.txtMemo, 0);
            this.Controls.SetChildIndex(this.dtPurchaseDate, 0);
            this.Controls.SetChildIndex(this.cbSupplierID, 0);
            this.Controls.SetChildIndex(this.gbSelect, 0);
            this.Controls.SetChildIndex(this.txtStockDate, 0);
            this.Controls.SetChildIndex(this.lbPurchaseID, 0);
            this.Controls.SetChildIndex(this.btnRepeal, 0);
            this.Controls.SetChildIndex(this.btnRecovery, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.txtClerkName, 0);
            this.Controls.SetChildIndex(this.txtExaminerName, 0);
            this.Controls.SetChildIndex(this.txtCustodianName, 0);
            this.Controls.SetChildIndex(this.btnCustodianS, 0);
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecovery;
        private System.Windows.Forms.Button btnRepeal;
        private System.Windows.Forms.TextBox txtCustodianName;
        private System.Windows.Forms.TextBox txtExaminerName;
        private System.Windows.Forms.TextBox txtClerkName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCustodianS;
    }
}