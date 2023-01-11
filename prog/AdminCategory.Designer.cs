
namespace prog
{
    partial class AdminCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCategory));
            this.label4 = new System.Windows.Forms.Label();
            this.bAddCategory = new System.Windows.Forms.Button();
            this.tBNewCategoryName = new System.Windows.Forms.TextBox();
            this.bBackToAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBDeleteProductType = new System.Windows.Forms.ComboBox();
            this.bDeleteCategories = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNewprod = new System.Windows.Forms.Label();
            this.lbNewprod2 = new System.Windows.Forms.Label();
            this.bExitMain = new System.Windows.Forms.Button();
            this.lbMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(197, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Введите название новой категории";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bAddCategory
            // 
            this.bAddCategory.BackColor = System.Drawing.SystemColors.Highlight;
            this.bAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAddCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAddCategory.Location = new System.Drawing.Point(248, 333);
            this.bAddCategory.Name = "bAddCategory";
            this.bAddCategory.Size = new System.Drawing.Size(155, 38);
            this.bAddCategory.TabIndex = 34;
            this.bAddCategory.Text = "Добавить категорию";
            this.bAddCategory.UseVisualStyleBackColor = false;
            this.bAddCategory.Click += new System.EventHandler(this.bAddCategory_Click);
            // 
            // tBNewCategoryName
            // 
            this.tBNewCategoryName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBNewCategoryName.Location = new System.Drawing.Point(197, 274);
            this.tBNewCategoryName.Name = "tBNewCategoryName";
            this.tBNewCategoryName.Size = new System.Drawing.Size(261, 29);
            this.tBNewCategoryName.TabIndex = 33;
            this.tBNewCategoryName.TextChanged += new System.EventHandler(this.tBNewCategoryName_TextChanged);
            // 
            // bBackToAdmin
            // 
            this.bBackToAdmin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bBackToAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBackToAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBackToAdmin.Location = new System.Drawing.Point(482, 556);
            this.bBackToAdmin.Name = "bBackToAdmin";
            this.bBackToAdmin.Size = new System.Drawing.Size(75, 23);
            this.bBackToAdmin.TabIndex = 32;
            this.bBackToAdmin.Text = "Назад";
            this.bBackToAdmin.UseVisualStyleBackColor = false;
            this.bBackToAdmin.Click += new System.EventHandler(this.bBackToAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(218, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 28);
            this.label1.TabIndex = 39;
            this.label1.Text = "Добавление категорий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(234, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Категория для удаления";
            // 
            // cBDeleteProductType
            // 
            this.cBDeleteProductType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBDeleteProductType.FormattingEnabled = true;
            this.cBDeleteProductType.Location = new System.Drawing.Point(198, 466);
            this.cBDeleteProductType.Name = "cBDeleteProductType";
            this.cBDeleteProductType.Size = new System.Drawing.Size(261, 29);
            this.cBDeleteProductType.TabIndex = 41;
            this.cBDeleteProductType.SelectedIndexChanged += new System.EventHandler(this.cBDeleteProductType_SelectedIndexChanged);
            // 
            // bDeleteCategories
            // 
            this.bDeleteCategories.BackColor = System.Drawing.SystemColors.Highlight;
            this.bDeleteCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDeleteCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeleteCategories.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bDeleteCategories.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bDeleteCategories.Location = new System.Drawing.Point(249, 523);
            this.bDeleteCategories.Name = "bDeleteCategories";
            this.bDeleteCategories.Size = new System.Drawing.Size(153, 38);
            this.bDeleteCategories.TabIndex = 40;
            this.bDeleteCategories.Text = "Удалить категорию";
            this.bDeleteCategories.UseVisualStyleBackColor = false;
            this.bDeleteCategories.Click += new System.EventHandler(this.bDeleteCategories_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(230, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 28);
            this.label3.TabIndex = 43;
            this.label3.Text = "Удаление категорий";
            // 
            // lbNewprod
            // 
            this.lbNewprod.AutoSize = true;
            this.lbNewprod.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNewprod.Location = new System.Drawing.Point(312, 315);
            this.lbNewprod.Name = "lbNewprod";
            this.lbNewprod.Size = new System.Drawing.Size(0, 15);
            this.lbNewprod.TabIndex = 44;
            // 
            // lbNewprod2
            // 
            this.lbNewprod2.AutoSize = true;
            this.lbNewprod2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNewprod2.Location = new System.Drawing.Point(311, 505);
            this.lbNewprod2.Name = "lbNewprod2";
            this.lbNewprod2.Size = new System.Drawing.Size(0, 15);
            this.lbNewprod2.TabIndex = 45;
            // 
            // bExitMain
            // 
            this.bExitMain.BackColor = System.Drawing.Color.Red;
            this.bExitMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExitMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExitMain.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bExitMain.ForeColor = System.Drawing.Color.Red;
            this.bExitMain.Location = new System.Drawing.Point(624, -1);
            this.bExitMain.Name = "bExitMain";
            this.bExitMain.Size = new System.Drawing.Size(26, 24);
            this.bExitMain.TabIndex = 46;
            this.bExitMain.UseVisualStyleBackColor = false;
            this.bExitMain.Click += new System.EventHandler(this.bExitMain_Click);
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMain.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMain.Location = new System.Drawing.Point(197, 142);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(274, 45);
            this.lbMain.TabIndex = 47;
            this.lbMain.Text = "Меню категорий";
            // 
            // AdminCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 660);
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.bExitMain);
            this.Controls.Add(this.lbNewprod2);
            this.Controls.Add(this.lbNewprod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBDeleteProductType);
            this.Controls.Add(this.bDeleteCategories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bAddCategory);
            this.Controls.Add(this.tBNewCategoryName);
            this.Controls.Add(this.bBackToAdmin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminCategory";
            this.Load += new System.EventHandler(this.AdminCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bAddCategory;
        private System.Windows.Forms.TextBox tBNewCategoryName;
        private System.Windows.Forms.Button bBackToAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBDeleteProductType;
        private System.Windows.Forms.Button bDeleteCategories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNewprod;
        private System.Windows.Forms.Label lbNewprod2;
        private System.Windows.Forms.Button bExitMain;
        private System.Windows.Forms.Label lbMain;
    }
}