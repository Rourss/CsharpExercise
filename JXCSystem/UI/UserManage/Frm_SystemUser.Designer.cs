namespace QiuXingMing.UI.UserManage
{
    partial class Frm_SystemUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.ListBox();
            this.btnPermission1 = new System.Windows.Forms.Button();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.btnRecovery1 = new System.Windows.Forms.Button();
            this.btnPermission2 = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.btnRecovery2 = new System.Windows.Forms.Button();
            this.btnPermission3 = new System.Windows.Forms.Button();
            this.btnClear3 = new System.Windows.Forms.Button();
            this.btnRecovery3 = new System.Windows.Forms.Button();
            this.btnPermission4 = new System.Windows.Forms.Button();
            this.btnClear4 = new System.Windows.Forms.Button();
            this.btnRecovery4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.btnPermission = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRecovery = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.cbCustomer = new System.Windows.Forms.CheckBox();
            this.cbSupplier = new System.Windows.Forms.CheckBox();
            this.cbEmployee = new System.Windows.Forms.CheckBox();
            this.cbProductInfo = new System.Windows.Forms.CheckBox();
            this.cbProduct = new System.Windows.Forms.CheckBox();
            this.gbStock = new System.Windows.Forms.GroupBox();
            this.cbInStockCheck = new System.Windows.Forms.CheckBox();
            this.cbExamPurchaseBill = new System.Windows.Forms.CheckBox();
            this.cbFillPurchaseBill = new System.Windows.Forms.CheckBox();
            this.gbSale = new System.Windows.Forms.GroupBox();
            this.cbSaleReturn = new System.Windows.Forms.CheckBox();
            this.cbSaleInfo = new System.Windows.Forms.CheckBox();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.cbSystemUser = new System.Windows.Forms.CheckBox();
            this.cbChangPWD = new System.Windows.Forms.CheckBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnConcel = new System.Windows.Forms.Button();
            this.gbInfo.SuspendLayout();
            this.gbStock.SuspendLayout();
            this.gbSale.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户列表";
            // 
            // lbUser
            // 
            this.lbUser.FormattingEnabled = true;
            this.lbUser.ItemHeight = 12;
            this.lbUser.Location = new System.Drawing.Point(12, 28);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(150, 532);
            this.lbUser.TabIndex = 1;
            this.lbUser.Click += new System.EventHandler(this.lbUser_Click);
            // 
            // btnPermission1
            // 
            this.btnPermission1.Location = new System.Drawing.Point(183, 127);
            this.btnPermission1.Name = "btnPermission1";
            this.btnPermission1.Size = new System.Drawing.Size(75, 23);
            this.btnPermission1.TabIndex = 2;
            this.btnPermission1.Text = "选择权限";
            this.btnPermission1.UseVisualStyleBackColor = true;
            this.btnPermission1.Click += new System.EventHandler(this.btnPermission1_Click);
            // 
            // btnClear1
            // 
            this.btnClear1.Location = new System.Drawing.Point(183, 161);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(75, 23);
            this.btnClear1.TabIndex = 2;
            this.btnClear1.Text = "清除权限";
            this.btnClear1.UseVisualStyleBackColor = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // btnRecovery1
            // 
            this.btnRecovery1.Enabled = false;
            this.btnRecovery1.Location = new System.Drawing.Point(183, 195);
            this.btnRecovery1.Name = "btnRecovery1";
            this.btnRecovery1.Size = new System.Drawing.Size(75, 23);
            this.btnRecovery1.TabIndex = 2;
            this.btnRecovery1.Text = "恢复权限";
            this.btnRecovery1.UseVisualStyleBackColor = true;
            this.btnRecovery1.Click += new System.EventHandler(this.btnRecovery1_Click);
            // 
            // btnPermission2
            // 
            this.btnPermission2.Location = new System.Drawing.Point(183, 247);
            this.btnPermission2.Name = "btnPermission2";
            this.btnPermission2.Size = new System.Drawing.Size(75, 23);
            this.btnPermission2.TabIndex = 2;
            this.btnPermission2.Text = "选择权限";
            this.btnPermission2.UseVisualStyleBackColor = true;
            this.btnPermission2.Click += new System.EventHandler(this.btnPermission2_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(183, 276);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(75, 23);
            this.btnClear2.TabIndex = 2;
            this.btnClear2.Text = "清除权限";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // btnRecovery2
            // 
            this.btnRecovery2.Enabled = false;
            this.btnRecovery2.Location = new System.Drawing.Point(183, 305);
            this.btnRecovery2.Name = "btnRecovery2";
            this.btnRecovery2.Size = new System.Drawing.Size(75, 23);
            this.btnRecovery2.TabIndex = 2;
            this.btnRecovery2.Text = "恢复权限";
            this.btnRecovery2.UseVisualStyleBackColor = true;
            this.btnRecovery2.Click += new System.EventHandler(this.btnRecovery2_Click);
            // 
            // btnPermission3
            // 
            this.btnPermission3.Location = new System.Drawing.Point(183, 364);
            this.btnPermission3.Name = "btnPermission3";
            this.btnPermission3.Size = new System.Drawing.Size(75, 23);
            this.btnPermission3.TabIndex = 2;
            this.btnPermission3.Text = "选择权限";
            this.btnPermission3.UseVisualStyleBackColor = true;
            this.btnPermission3.Click += new System.EventHandler(this.btnPermission3_Click);
            // 
            // btnClear3
            // 
            this.btnClear3.Location = new System.Drawing.Point(183, 393);
            this.btnClear3.Name = "btnClear3";
            this.btnClear3.Size = new System.Drawing.Size(75, 23);
            this.btnClear3.TabIndex = 2;
            this.btnClear3.Text = "清除权限";
            this.btnClear3.UseVisualStyleBackColor = true;
            this.btnClear3.Click += new System.EventHandler(this.btnClear3_Click);
            // 
            // btnRecovery3
            // 
            this.btnRecovery3.Enabled = false;
            this.btnRecovery3.Location = new System.Drawing.Point(183, 422);
            this.btnRecovery3.Name = "btnRecovery3";
            this.btnRecovery3.Size = new System.Drawing.Size(75, 23);
            this.btnRecovery3.TabIndex = 2;
            this.btnRecovery3.Text = "恢复权限";
            this.btnRecovery3.UseVisualStyleBackColor = true;
            this.btnRecovery3.Click += new System.EventHandler(this.btnRecovery3_Click);
            // 
            // btnPermission4
            // 
            this.btnPermission4.Location = new System.Drawing.Point(183, 479);
            this.btnPermission4.Name = "btnPermission4";
            this.btnPermission4.Size = new System.Drawing.Size(75, 23);
            this.btnPermission4.TabIndex = 2;
            this.btnPermission4.Text = "选择权限";
            this.btnPermission4.UseVisualStyleBackColor = true;
            this.btnPermission4.Click += new System.EventHandler(this.btnPermission4_Click);
            // 
            // btnClear4
            // 
            this.btnClear4.Location = new System.Drawing.Point(183, 508);
            this.btnClear4.Name = "btnClear4";
            this.btnClear4.Size = new System.Drawing.Size(75, 23);
            this.btnClear4.TabIndex = 2;
            this.btnClear4.Text = "清除权限";
            this.btnClear4.UseVisualStyleBackColor = true;
            this.btnClear4.Click += new System.EventHandler(this.btnClear4_Click);
            // 
            // btnRecovery4
            // 
            this.btnRecovery4.Enabled = false;
            this.btnRecovery4.Location = new System.Drawing.Point(183, 537);
            this.btnRecovery4.Name = "btnRecovery4";
            this.btnRecovery4.Size = new System.Drawing.Size(75, 23);
            this.btnRecovery4.TabIndex = 2;
            this.btnRecovery4.Text = "恢复权限";
            this.btnRecovery4.UseVisualStyleBackColor = true;
            this.btnRecovery4.Click += new System.EventHandler(this.btnRecovery4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "用户名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "姓  名:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "密  码:";
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point(340, 13);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 21);
            this.txtUserID.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(551, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 4;
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(340, 52);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.Size = new System.Drawing.Size(100, 21);
            this.txtPWD.TabIndex = 4;
            // 
            // btnPermission
            // 
            this.btnPermission.Location = new System.Drawing.Point(289, 87);
            this.btnPermission.Name = "btnPermission";
            this.btnPermission.Size = new System.Drawing.Size(151, 25);
            this.btnPermission.TabIndex = 5;
            this.btnPermission.Text = "选择全部权限";
            this.btnPermission.UseVisualStyleBackColor = true;
            this.btnPermission.Click += new System.EventHandler(this.btnPermission_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(500, 86);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 25);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "清除全部权限";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRecovery
            // 
            this.btnRecovery.Enabled = false;
            this.btnRecovery.Location = new System.Drawing.Point(701, 87);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(151, 25);
            this.btnRecovery.TabIndex = 5;
            this.btnRecovery.Text = "恢复全部权限";
            this.btnRecovery.UseVisualStyleBackColor = true;
            this.btnRecovery.Click += new System.EventHandler(this.btnRecovery_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.cbCustomer);
            this.gbInfo.Controls.Add(this.cbSupplier);
            this.gbInfo.Controls.Add(this.cbEmployee);
            this.gbInfo.Controls.Add(this.cbProductInfo);
            this.gbInfo.Controls.Add(this.cbProduct);
            this.gbInfo.Location = new System.Drawing.Point(289, 118);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(563, 100);
            this.gbInfo.TabIndex = 6;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "基础信息管理";
            // 
            // cbCustomer
            // 
            this.cbCustomer.AutoSize = true;
            this.cbCustomer.Location = new System.Drawing.Point(222, 26);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(96, 16);
            this.cbCustomer.TabIndex = 0;
            this.cbCustomer.Text = "客户信息管理";
            this.cbCustomer.UseVisualStyleBackColor = true;
            // 
            // cbSupplier
            // 
            this.cbSupplier.AutoSize = true;
            this.cbSupplier.Location = new System.Drawing.Point(387, 47);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(108, 16);
            this.cbSupplier.TabIndex = 0;
            this.cbSupplier.Text = "供应商信息管理";
            this.cbSupplier.UseVisualStyleBackColor = true;
            // 
            // cbEmployee
            // 
            this.cbEmployee.AutoSize = true;
            this.cbEmployee.Location = new System.Drawing.Point(20, 66);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(96, 16);
            this.cbEmployee.TabIndex = 0;
            this.cbEmployee.Text = "员工信息管理";
            this.cbEmployee.UseVisualStyleBackColor = true;
            // 
            // cbProductInfo
            // 
            this.cbProductInfo.AutoSize = true;
            this.cbProductInfo.Location = new System.Drawing.Point(222, 66);
            this.cbProductInfo.Name = "cbProductInfo";
            this.cbProductInfo.Size = new System.Drawing.Size(96, 16);
            this.cbProductInfo.TabIndex = 0;
            this.cbProductInfo.Text = "产品信息管理";
            this.cbProductInfo.UseVisualStyleBackColor = true;
            // 
            // cbProduct
            // 
            this.cbProduct.AutoSize = true;
            this.cbProduct.Location = new System.Drawing.Point(20, 26);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(96, 16);
            this.cbProduct.TabIndex = 0;
            this.cbProduct.Text = "产品分类管理";
            this.cbProduct.UseVisualStyleBackColor = true;
            // 
            // gbStock
            // 
            this.gbStock.Controls.Add(this.cbInStockCheck);
            this.gbStock.Controls.Add(this.cbExamPurchaseBill);
            this.gbStock.Controls.Add(this.cbFillPurchaseBill);
            this.gbStock.Location = new System.Drawing.Point(289, 247);
            this.gbStock.Name = "gbStock";
            this.gbStock.Size = new System.Drawing.Size(563, 81);
            this.gbStock.TabIndex = 7;
            this.gbStock.TabStop = false;
            this.gbStock.Text = "进货管理";
            // 
            // cbInStockCheck
            // 
            this.cbInStockCheck.AutoSize = true;
            this.cbInStockCheck.Location = new System.Drawing.Point(387, 40);
            this.cbInStockCheck.Name = "cbInStockCheck";
            this.cbInStockCheck.Size = new System.Drawing.Size(72, 16);
            this.cbInStockCheck.TabIndex = 0;
            this.cbInStockCheck.Text = "检验货物";
            this.cbInStockCheck.UseVisualStyleBackColor = true;
            // 
            // cbExamPurchaseBill
            // 
            this.cbExamPurchaseBill.AutoSize = true;
            this.cbExamPurchaseBill.Location = new System.Drawing.Point(222, 40);
            this.cbExamPurchaseBill.Name = "cbExamPurchaseBill";
            this.cbExamPurchaseBill.Size = new System.Drawing.Size(84, 16);
            this.cbExamPurchaseBill.TabIndex = 0;
            this.cbExamPurchaseBill.Text = "审核进货单";
            this.cbExamPurchaseBill.UseVisualStyleBackColor = true;
            // 
            // cbFillPurchaseBill
            // 
            this.cbFillPurchaseBill.AutoSize = true;
            this.cbFillPurchaseBill.Location = new System.Drawing.Point(20, 40);
            this.cbFillPurchaseBill.Name = "cbFillPurchaseBill";
            this.cbFillPurchaseBill.Size = new System.Drawing.Size(84, 16);
            this.cbFillPurchaseBill.TabIndex = 0;
            this.cbFillPurchaseBill.Text = "填写进货单";
            this.cbFillPurchaseBill.UseVisualStyleBackColor = true;
            // 
            // gbSale
            // 
            this.gbSale.Controls.Add(this.cbSaleReturn);
            this.gbSale.Controls.Add(this.cbSaleInfo);
            this.gbSale.Location = new System.Drawing.Point(289, 364);
            this.gbSale.Name = "gbSale";
            this.gbSale.Size = new System.Drawing.Size(563, 81);
            this.gbSale.TabIndex = 8;
            this.gbSale.TabStop = false;
            this.gbSale.Text = "销售管理";
            // 
            // cbSaleReturn
            // 
            this.cbSaleReturn.AutoSize = true;
            this.cbSaleReturn.Location = new System.Drawing.Point(222, 36);
            this.cbSaleReturn.Name = "cbSaleReturn";
            this.cbSaleReturn.Size = new System.Drawing.Size(72, 16);
            this.cbSaleReturn.TabIndex = 0;
            this.cbSaleReturn.Text = "销售退货";
            this.cbSaleReturn.UseVisualStyleBackColor = true;
            // 
            // cbSaleInfo
            // 
            this.cbSaleInfo.AutoSize = true;
            this.cbSaleInfo.Location = new System.Drawing.Point(20, 36);
            this.cbSaleInfo.Name = "cbSaleInfo";
            this.cbSaleInfo.Size = new System.Drawing.Size(96, 16);
            this.cbSaleInfo.TabIndex = 0;
            this.cbSaleInfo.Text = "前台销售管理";
            this.cbSaleInfo.UseVisualStyleBackColor = true;
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.cbSystemUser);
            this.gbUser.Controls.Add(this.cbChangPWD);
            this.gbUser.Location = new System.Drawing.Point(289, 479);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(563, 81);
            this.gbUser.TabIndex = 9;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "用户管理";
            // 
            // cbSystemUser
            // 
            this.cbSystemUser.AutoSize = true;
            this.cbSystemUser.Location = new System.Drawing.Point(222, 33);
            this.cbSystemUser.Name = "cbSystemUser";
            this.cbSystemUser.Size = new System.Drawing.Size(72, 16);
            this.cbSystemUser.TabIndex = 0;
            this.cbSystemUser.Text = "用户管理";
            this.cbSystemUser.UseVisualStyleBackColor = true;
            // 
            // cbChangPWD
            // 
            this.cbChangPWD.AutoSize = true;
            this.cbChangPWD.Location = new System.Drawing.Point(20, 33);
            this.cbChangPWD.Name = "cbChangPWD";
            this.cbChangPWD.Size = new System.Drawing.Size(72, 16);
            this.cbChangPWD.TabIndex = 0;
            this.cbChangPWD.Text = "修改密码";
            this.cbChangPWD.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 577);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(350, 25);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnConcel
            // 
            this.btnConcel.Location = new System.Drawing.Point(502, 577);
            this.btnConcel.Name = "btnConcel";
            this.btnConcel.Size = new System.Drawing.Size(350, 25);
            this.btnConcel.TabIndex = 10;
            this.btnConcel.Text = "取消";
            this.btnConcel.UseVisualStyleBackColor = true;
            this.btnConcel.Click += new System.EventHandler(this.btnConcel_Click);
            // 
            // Frm_SystemUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 612);
            this.Controls.Add(this.btnConcel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.gbSale);
            this.Controls.Add(this.gbStock);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnRecovery);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPermission);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRecovery4);
            this.Controls.Add(this.btnClear4);
            this.Controls.Add(this.btnPermission4);
            this.Controls.Add(this.btnRecovery3);
            this.Controls.Add(this.btnClear3);
            this.Controls.Add(this.btnPermission3);
            this.Controls.Add(this.btnRecovery2);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.btnPermission2);
            this.Controls.Add(this.btnRecovery1);
            this.Controls.Add(this.btnClear1);
            this.Controls.Add(this.btnPermission1);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.label1);
            this.Name = "Frm_SystemUser";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.Frm_SystemUser_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbStock.ResumeLayout(false);
            this.gbStock.PerformLayout();
            this.gbSale.ResumeLayout(false);
            this.gbSale.PerformLayout();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbUser;
        private System.Windows.Forms.Button btnPermission1;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Button btnRecovery1;
        private System.Windows.Forms.Button btnPermission2;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Button btnRecovery2;
        private System.Windows.Forms.Button btnPermission3;
        private System.Windows.Forms.Button btnClear3;
        private System.Windows.Forms.Button btnRecovery3;
        private System.Windows.Forms.Button btnPermission4;
        private System.Windows.Forms.Button btnClear4;
        private System.Windows.Forms.Button btnRecovery4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.Button btnPermission;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRecovery;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.CheckBox cbCustomer;
        private System.Windows.Forms.CheckBox cbSupplier;
        private System.Windows.Forms.CheckBox cbEmployee;
        private System.Windows.Forms.CheckBox cbProductInfo;
        private System.Windows.Forms.CheckBox cbProduct;
        private System.Windows.Forms.GroupBox gbStock;
        private System.Windows.Forms.CheckBox cbInStockCheck;
        private System.Windows.Forms.CheckBox cbExamPurchaseBill;
        private System.Windows.Forms.CheckBox cbFillPurchaseBill;
        private System.Windows.Forms.GroupBox gbSale;
        private System.Windows.Forms.CheckBox cbSaleReturn;
        private System.Windows.Forms.CheckBox cbSaleInfo;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.CheckBox cbSystemUser;
        private System.Windows.Forms.CheckBox cbChangPWD;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnConcel;
    }
}