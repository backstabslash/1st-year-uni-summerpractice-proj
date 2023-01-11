using System;
using System.IO;
namespace prog
{
    partial class AdminAddproductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAddproductsForm));
            this.bBackToAdmin = new System.Windows.Forms.Button();
            this.bExitMain = new System.Windows.Forms.Button();
            this.lBAllproducts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNewprod = new System.Windows.Forms.Label();
            this.tBNewProductName = new System.Windows.Forms.TextBox();
            this.tBPriceUsd = new System.Windows.Forms.TextBox();
            this.cBProductType = new System.Windows.Forms.ComboBox();
            this.bAddProduct = new System.Windows.Forms.Button();
            this.cBChooseShowCategories = new System.Windows.Forms.ComboBox();
            this.tBAddQuantity = new System.Windows.Forms.TextBox();
            this.bAddQuantity = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bBackToAdmin
            // 
            this.bBackToAdmin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bBackToAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBackToAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBackToAdmin.Location = new System.Drawing.Point(907, 619);
            this.bBackToAdmin.Name = "bBackToAdmin";
            this.bBackToAdmin.Size = new System.Drawing.Size(75, 23);
            this.bBackToAdmin.TabIndex = 1;
            this.bBackToAdmin.Text = "Назад";
            this.bBackToAdmin.UseVisualStyleBackColor = false;
            this.bBackToAdmin.Click += new System.EventHandler(this.bBackToAdmin_Click);
            // 
            // bExitMain
            // 
            this.bExitMain.BackColor = System.Drawing.Color.Red;
            this.bExitMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExitMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExitMain.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bExitMain.ForeColor = System.Drawing.Color.Red;
            this.bExitMain.Location = new System.Drawing.Point(1056, 1);
            this.bExitMain.Name = "bExitMain";
            this.bExitMain.Size = new System.Drawing.Size(26, 24);
            this.bExitMain.TabIndex = 10;
            this.bExitMain.UseVisualStyleBackColor = false;
            this.bExitMain.Click += new System.EventHandler(this.bExitMain_Click);
            // 
            // lBAllproducts
            // 
            this.lBAllproducts.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lBAllproducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lBAllproducts.FormattingEnabled = true;
            this.lBAllproducts.ItemHeight = 20;
            this.lBAllproducts.Location = new System.Drawing.Point(92, 219);
            this.lBAllproducts.Name = "lBAllproducts";
            this.lBAllproducts.Size = new System.Drawing.Size(877, 164);
            this.lBAllproducts.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Категория для отображения";
            // 
            // lbNewprod
            // 
            this.lbNewprod.AutoSize = true;
            this.lbNewprod.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNewprod.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNewprod.Location = new System.Drawing.Point(734, 391);
            this.lbNewprod.Name = "lbNewprod";
            this.lbNewprod.Size = new System.Drawing.Size(138, 25);
            this.lbNewprod.TabIndex = 13;
            this.lbNewprod.Text = "Закупить товар";
            // 
            // tBNewProductName
            // 
            this.tBNewProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBNewProductName.Location = new System.Drawing.Point(92, 493);
            this.tBNewProductName.Name = "tBNewProductName";
            this.tBNewProductName.Size = new System.Drawing.Size(201, 29);
            this.tBNewProductName.TabIndex = 15;
            // 
            // tBPriceUsd
            // 
            this.tBPriceUsd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBPriceUsd.Location = new System.Drawing.Point(92, 562);
            this.tBPriceUsd.Name = "tBPriceUsd";
            this.tBPriceUsd.Size = new System.Drawing.Size(201, 29);
            this.tBPriceUsd.TabIndex = 16;
            this.tBPriceUsd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBAddQuantity_KeyPress);
            // 
            // cBProductType
            // 
            this.cBProductType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cBProductType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBProductType.FormattingEnabled = true;
            this.cBProductType.Location = new System.Drawing.Point(92, 420);
            this.cBProductType.Name = "cBProductType";
            this.cBProductType.Size = new System.Drawing.Size(201, 29);
            this.cBProductType.TabIndex = 18;
            // 
            // bAddProduct
            // 
            this.bAddProduct.BackColor = System.Drawing.SystemColors.Highlight;
            this.bAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAddProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAddProduct.Location = new System.Drawing.Point(92, 607);
            this.bAddProduct.Name = "bAddProduct";
            this.bAddProduct.Size = new System.Drawing.Size(144, 35);
            this.bAddProduct.TabIndex = 20;
            this.bAddProduct.Text = "Добавить продукт";
            this.bAddProduct.UseVisualStyleBackColor = false;
            this.bAddProduct.Click += new System.EventHandler(this.bAddProduct_Click);
            // 
            // cBChooseShowCategories
            // 
            this.cBChooseShowCategories.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cBChooseShowCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBChooseShowCategories.FormattingEnabled = true;
            this.cBChooseShowCategories.Location = new System.Drawing.Point(92, 184);
            this.cBChooseShowCategories.Name = "cBChooseShowCategories";
            this.cBChooseShowCategories.Size = new System.Drawing.Size(291, 29);
            this.cBChooseShowCategories.TabIndex = 26;
            this.cBChooseShowCategories.SelectedIndexChanged += new System.EventHandler(this.cBChooseShowCategories_SelectedIndexChanged);
            // 
            // tBAddQuantity
            // 
            this.tBAddQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBAddQuantity.Location = new System.Drawing.Point(734, 466);
            this.tBAddQuantity.Name = "tBAddQuantity";
            this.tBAddQuantity.Size = new System.Drawing.Size(190, 29);
            this.tBAddQuantity.TabIndex = 27;
            this.tBAddQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBAddQuantity_KeyPress);
            // 
            // bAddQuantity
            // 
            this.bAddQuantity.BackColor = System.Drawing.SystemColors.Highlight;
            this.bAddQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAddQuantity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAddQuantity.Location = new System.Drawing.Point(734, 507);
            this.bAddQuantity.Name = "bAddQuantity";
            this.bAddQuantity.Size = new System.Drawing.Size(100, 35);
            this.bAddQuantity.TabIndex = 28;
            this.bAddQuantity.Text = "Закупить";
            this.bAddQuantity.UseVisualStyleBackColor = false;
            this.bAddQuantity.Click += new System.EventHandler(this.bAddQuantity_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(92, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Добавить новый продукт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(92, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "Название продукта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(92, 538);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "Цена в USD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(734, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "Количество";
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMain.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMain.Location = new System.Drawing.Point(231, 111);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(622, 41);
            this.lbMain.TabIndex = 35;
            this.lbMain.Text = "Добавление продуктов и закупка товаров";
            // 
            // AdminAddproductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bAddQuantity);
            this.Controls.Add(this.tBAddQuantity);
            this.Controls.Add(this.cBChooseShowCategories);
            this.Controls.Add(this.bAddProduct);
            this.Controls.Add(this.cBProductType);
            this.Controls.Add(this.tBPriceUsd);
            this.Controls.Add(this.tBNewProductName);
            this.Controls.Add(this.lbNewprod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBAllproducts);
            this.Controls.Add(this.bExitMain);
            this.Controls.Add(this.bBackToAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAddproductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAddproductsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBackToAdmin;
        private System.Windows.Forms.Button bExitMain;
        private System.Windows.Forms.ListBox lBAllproducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNewprod;
        private System.Windows.Forms.TextBox tBNewProductName;
        private System.Windows.Forms.TextBox tBPriceUsd;
        private System.Windows.Forms.ComboBox cBProductType;
        private System.Windows.Forms.Button bAddProduct;
        private System.Windows.Forms.ComboBox cBChooseShowCategories;
        private System.Windows.Forms.TextBox tBAddQuantity;
        private System.Windows.Forms.Button bAddQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMain;
        public decimal profit = Convert.ToDecimal(File.ReadAllText("Profit.txt"));
    }
}