using System.IO;
using System;

namespace RegisterForm
{
    partial class StoreUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreUserForm));
            this.bExitMain = new System.Windows.Forms.Button();
            this.bBasket = new System.Windows.Forms.Button();
            this.lBUserAllproducts = new System.Windows.Forms.ListBox();
            this.cBProductType = new System.Windows.Forms.ComboBox();
            this.tBBuyProduct = new System.Windows.Forms.TextBox();
            this.bBuyProduct = new System.Windows.Forms.Button();
            this.lbPriceQuantity = new System.Windows.Forms.Label();
            this.lbChooseCat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bExitMain
            // 
            this.bExitMain.BackColor = System.Drawing.Color.Red;
            this.bExitMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExitMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExitMain.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bExitMain.ForeColor = System.Drawing.Color.Red;
            this.bExitMain.Location = new System.Drawing.Point(1250, 3);
            this.bExitMain.Name = "bExitMain";
            this.bExitMain.Size = new System.Drawing.Size(26, 25);
            this.bExitMain.TabIndex = 10;
            this.bExitMain.UseVisualStyleBackColor = false;
            this.bExitMain.Click += new System.EventHandler(this.bExitMain_Click);
            // 
            // bBasket
            // 
            this.bBasket.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bBasket.BackgroundImage = global::prog.Properties.Resources.корзиночка;
            this.bBasket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBasket.Location = new System.Drawing.Point(903, 108);
            this.bBasket.Name = "bBasket";
            this.bBasket.Size = new System.Drawing.Size(60, 54);
            this.bBasket.TabIndex = 15;
            this.bBasket.UseVisualStyleBackColor = false;
            this.bBasket.Click += new System.EventHandler(this.bBasket_Click);
            // 
            // lBUserAllproducts
            // 
            this.lBUserAllproducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lBUserAllproducts.FormattingEnabled = true;
            this.lBUserAllproducts.ItemHeight = 21;
            this.lBUserAllproducts.Location = new System.Drawing.Point(99, 251);
            this.lBUserAllproducts.Name = "lBUserAllproducts";
            this.lBUserAllproducts.Size = new System.Drawing.Size(864, 235);
            this.lBUserAllproducts.TabIndex = 16;
            // 
            // cBProductType
            // 
            this.cBProductType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBProductType.FormattingEnabled = true;
            this.cBProductType.Location = new System.Drawing.Point(324, 207);
            this.cBProductType.Name = "cBProductType";
            this.cBProductType.Size = new System.Drawing.Size(182, 29);
            this.cBProductType.TabIndex = 17;
            this.cBProductType.SelectedIndexChanged += new System.EventHandler(this.cBProductType_SelectedIndexChanged);
            // 
            // tBBuyProduct
            // 
            this.tBBuyProduct.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBBuyProduct.Location = new System.Drawing.Point(397, 543);
            this.tBBuyProduct.Name = "tBBuyProduct";
            this.tBBuyProduct.Size = new System.Drawing.Size(255, 31);
            this.tBBuyProduct.TabIndex = 18;
            this.tBBuyProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantityOfProducts_KeyPress);
            // 
            // bBuyProduct
            // 
            this.bBuyProduct.BackColor = System.Drawing.SystemColors.Highlight;
            this.bBuyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBuyProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bBuyProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bBuyProduct.Location = new System.Drawing.Point(435, 597);
            this.bBuyProduct.Name = "bBuyProduct";
            this.bBuyProduct.Size = new System.Drawing.Size(179, 41);
            this.bBuyProduct.TabIndex = 19;
            this.bBuyProduct.Text = "Добавить в корзину";
            this.bBuyProduct.UseVisualStyleBackColor = false;
            this.bBuyProduct.Click += new System.EventHandler(this.bBuyProduct_Click);
            // 
            // lbPriceQuantity
            // 
            this.lbPriceQuantity.AutoSize = true;
            this.lbPriceQuantity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPriceQuantity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPriceQuantity.Location = new System.Drawing.Point(809, 558);
            this.lbPriceQuantity.Name = "lbPriceQuantity";
            this.lbPriceQuantity.Size = new System.Drawing.Size(0, 20);
            this.lbPriceQuantity.TabIndex = 20;
            // 
            // lbChooseCat
            // 
            this.lbChooseCat.AutoSize = true;
            this.lbChooseCat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbChooseCat.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbChooseCat.Location = new System.Drawing.Point(99, 207);
            this.lbChooseCat.Name = "lbChooseCat";
            this.lbChooseCat.Size = new System.Drawing.Size(204, 28);
            this.lbChooseCat.TabIndex = 21;
            this.lbChooseCat.Text = "Выберите категорию";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(383, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 45);
            this.label1.TabIndex = 22;
            this.label1.Text = "Покупка товаров";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(449, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Введите количество";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1053, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 27);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bLogOut
            // 
            this.bLogOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bLogOut.Location = new System.Drawing.Point(844, 612);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(138, 26);
            this.bLogOut.TabIndex = 34;
            this.bLogOut.Text = "Выйти из аккаунта";
            this.bLogOut.UseVisualStyleBackColor = false;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // StoreUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.bLogOut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbChooseCat);
            this.Controls.Add(this.lbPriceQuantity);
            this.Controls.Add(this.bBuyProduct);
            this.Controls.Add(this.tBBuyProduct);
            this.Controls.Add(this.cBProductType);
            this.Controls.Add(this.lBUserAllproducts);
            this.Controls.Add(this.bBasket);
            this.Controls.Add(this.bExitMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StoreUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bExitMain;
        private System.Windows.Forms.Button bBasket;
        private System.Windows.Forms.ListBox lBUserAllproducts;
        private System.Windows.Forms.ComboBox cBProductType;
        private System.Windows.Forms.TextBox tBBuyProduct;
        private System.Windows.Forms.Button bBuyProduct;
        private System.Windows.Forms.Label lbPriceQuantity;
        private System.Windows.Forms.Label lbChooseCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bLogOut;
        public decimal profit = Convert.ToDecimal(File.ReadAllText("Profit.txt"));
    }
}