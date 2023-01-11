
namespace RegisterForm
{
    partial class StoreAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreAdminForm));
            this.lbExchange = new System.Windows.Forms.Label();
            this.lbCabName = new System.Windows.Forms.Label();
            this.bMakeAdmin = new System.Windows.Forms.Button();
            this.bIncome = new System.Windows.Forms.Button();
            this.bAddProducts = new System.Windows.Forms.Button();
            this.bExitMain = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bModify = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bLogOut = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbExchange
            // 
            this.lbExchange.AutoSize = true;
            this.lbExchange.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbExchange.Location = new System.Drawing.Point(269, 25);
            this.lbExchange.Name = "lbExchange";
            this.lbExchange.Size = new System.Drawing.Size(0, 40);
            this.lbExchange.TabIndex = 0;
            // 
            // lbCabName
            // 
            this.lbCabName.AutoSize = true;
            this.lbCabName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCabName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCabName.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCabName.Location = new System.Drawing.Point(114, 114);
            this.lbCabName.Name = "lbCabName";
            this.lbCabName.Size = new System.Drawing.Size(340, 37);
            this.lbCabName.TabIndex = 3;
            this.lbCabName.Text = "Кабинет администратора";
            // 
            // bMakeAdmin
            // 
            this.bMakeAdmin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bMakeAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMakeAdmin.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bMakeAdmin.Location = new System.Drawing.Point(139, 355);
            this.bMakeAdmin.Name = "bMakeAdmin";
            this.bMakeAdmin.Size = new System.Drawing.Size(274, 37);
            this.bMakeAdmin.TabIndex = 6;
            this.bMakeAdmin.Text = "Управление учётными записями";
            this.bMakeAdmin.UseVisualStyleBackColor = false;
            this.bMakeAdmin.Click += new System.EventHandler(this.bMakeAdmin_Click);
            // 
            // bIncome
            // 
            this.bIncome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIncome.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bIncome.Location = new System.Drawing.Point(139, 310);
            this.bIncome.Name = "bIncome";
            this.bIncome.Size = new System.Drawing.Size(274, 39);
            this.bIncome.TabIndex = 7;
            this.bIncome.Text = "Показать прибыль склада";
            this.bIncome.UseVisualStyleBackColor = false;
            this.bIncome.Click += new System.EventHandler(this.bIncome_Click);
            // 
            // bAddProducts
            // 
            this.bAddProducts.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAddProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAddProducts.Location = new System.Drawing.Point(139, 269);
            this.bAddProducts.Name = "bAddProducts";
            this.bAddProducts.Size = new System.Drawing.Size(274, 35);
            this.bAddProducts.TabIndex = 8;
            this.bAddProducts.Text = "Добавить продукты";
            this.bAddProducts.UseVisualStyleBackColor = false;
            this.bAddProducts.Click += new System.EventHandler(this.bAddProducts_Click);
            // 
            // bExitMain
            // 
            this.bExitMain.BackColor = System.Drawing.Color.Red;
            this.bExitMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExitMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExitMain.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bExitMain.ForeColor = System.Drawing.Color.Red;
            this.bExitMain.Location = new System.Drawing.Point(1238, 0);
            this.bExitMain.Name = "bExitMain";
            this.bExitMain.Size = new System.Drawing.Size(26, 25);
            this.bExitMain.TabIndex = 10;
            this.bExitMain.UseVisualStyleBackColor = false;
            this.bExitMain.Click += new System.EventHandler(this.bExitMain_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(529, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bModify
            // 
            this.bModify.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bModify.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bModify.Location = new System.Drawing.Point(139, 226);
            this.bModify.Name = "bModify";
            this.bModify.Size = new System.Drawing.Size(274, 37);
            this.bModify.TabIndex = 12;
            this.bModify.Text = "Изменить коэфициент доходности";
            this.bModify.UseVisualStyleBackColor = false;
            this.bModify.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(139, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 39);
            this.button2.TabIndex = 13;
            this.button2.Text = "Добавление и удаление категорий";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // bLogOut
            // 
            this.bLogOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bLogOut.Location = new System.Drawing.Point(331, 468);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(138, 26);
            this.bLogOut.TabIndex = 33;
            this.bLogOut.Text = "Выйти из аккаунта";
            this.bLogOut.UseVisualStyleBackColor = false;
            this.bLogOut.Click += new System.EventHandler(this.bBackToAdmin_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(139, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(274, 36);
            this.button3.TabIndex = 34;
            this.button3.Text = "Журнал действий";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // StoreAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 560);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bLogOut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bModify);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bExitMain);
            this.Controls.Add(this.bAddProducts);
            this.Controls.Add(this.bIncome);
            this.Controls.Add(this.bMakeAdmin);
            this.Controls.Add(this.lbCabName);
            this.Controls.Add(this.lbExchange);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StoreAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbExchange;
        private System.Windows.Forms.Label lbCabName;
        private System.Windows.Forms.Button bMakeAdmin;
        private System.Windows.Forms.Button bIncome;
        private System.Windows.Forms.Button bAddProducts;
        private System.Windows.Forms.Button bExitMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bModify;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.Button button3;
    }
}