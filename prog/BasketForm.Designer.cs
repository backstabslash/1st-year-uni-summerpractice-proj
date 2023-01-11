
namespace prog
{
    partial class BasketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasketForm));
            this.lBProductsInBasket = new System.Windows.Forms.ListBox();
            this.bExitMain = new System.Windows.Forms.Button();
            this.bBuyItems = new System.Windows.Forms.Button();
            this.bBackToAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBProductsInBasket
            // 
            this.lBProductsInBasket.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lBProductsInBasket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lBProductsInBasket.FormattingEnabled = true;
            this.lBProductsInBasket.ItemHeight = 21;
            this.lBProductsInBasket.Location = new System.Drawing.Point(108, 194);
            this.lBProductsInBasket.Name = "lBProductsInBasket";
            this.lBProductsInBasket.Size = new System.Drawing.Size(441, 214);
            this.lBProductsInBasket.TabIndex = 0;
            // 
            // bExitMain
            // 
            this.bExitMain.BackColor = System.Drawing.Color.Red;
            this.bExitMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExitMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExitMain.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bExitMain.ForeColor = System.Drawing.Color.Red;
            this.bExitMain.Location = new System.Drawing.Point(774, -1);
            this.bExitMain.Name = "bExitMain";
            this.bExitMain.Size = new System.Drawing.Size(26, 25);
            this.bExitMain.TabIndex = 10;
            this.bExitMain.UseVisualStyleBackColor = false;
            // 
            // bBuyItems
            // 
            this.bBuyItems.BackColor = System.Drawing.SystemColors.Highlight;
            this.bBuyItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBuyItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bBuyItems.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bBuyItems.Location = new System.Drawing.Point(241, 455);
            this.bBuyItems.Name = "bBuyItems";
            this.bBuyItems.Size = new System.Drawing.Size(170, 34);
            this.bBuyItems.TabIndex = 11;
            this.bBuyItems.Text = "Потвердить покупку";
            this.bBuyItems.UseVisualStyleBackColor = false;
            // 
            // bBackToAdmin
            // 
            this.bBackToAdmin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bBackToAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBackToAdmin.Location = new System.Drawing.Point(474, 550);
            this.bBackToAdmin.Name = "bBackToAdmin";
            this.bBackToAdmin.Size = new System.Drawing.Size(75, 23);
            this.bBackToAdmin.TabIndex = 12;
            this.bBackToAdmin.Text = "Назад";
            this.bBackToAdmin.UseVisualStyleBackColor = false;
            this.bBackToAdmin.Click += new System.EventHandler(this.bBackToAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(253, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "Корзина";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(587, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 24);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBackToAdmin);
            this.Controls.Add(this.bBuyItems);
            this.Controls.Add(this.bExitMain);
            this.Controls.Add(this.lBProductsInBasket);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BasketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "R";
            this.Load += new System.EventHandler(this.BasketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBProductsInBasket;
        private System.Windows.Forms.Button bExitMain;
        private System.Windows.Forms.Button bBuyItems;
        private System.Windows.Forms.Button bBackToAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}