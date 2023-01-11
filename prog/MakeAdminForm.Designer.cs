
namespace prog
{
    partial class MakeAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeAdminForm));
            this.bBackToAdmin = new System.Windows.Forms.Button();
            this.bExitMain = new System.Windows.Forms.Button();
            this.bMakeAdmin = new System.Windows.Forms.Button();
            this.lbAllUsers = new System.Windows.Forms.ListBox();
            this.bCanceldmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bBackToAdmin
            // 
            this.bBackToAdmin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bBackToAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBackToAdmin.Location = new System.Drawing.Point(901, 507);
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
            this.bExitMain.Location = new System.Drawing.Point(1053, -2);
            this.bExitMain.Name = "bExitMain";
            this.bExitMain.Size = new System.Drawing.Size(23, 23);
            this.bExitMain.TabIndex = 10;
            this.bExitMain.UseVisualStyleBackColor = false;
            this.bExitMain.Click += new System.EventHandler(this.bExitMain_Click);
            // 
            // bMakeAdmin
            // 
            this.bMakeAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.bMakeAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMakeAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bMakeAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bMakeAdmin.Location = new System.Drawing.Point(281, 410);
            this.bMakeAdmin.Name = "bMakeAdmin";
            this.bMakeAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bMakeAdmin.Size = new System.Drawing.Size(192, 57);
            this.bMakeAdmin.TabIndex = 12;
            this.bMakeAdmin.Text = "Выдать права администратора";
            this.bMakeAdmin.UseVisualStyleBackColor = false;
            this.bMakeAdmin.Click += new System.EventHandler(this.bMakeAdmin_Click);
            // 
            // lbAllUsers
            // 
            this.lbAllUsers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbAllUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAllUsers.FormattingEnabled = true;
            this.lbAllUsers.ItemHeight = 21;
            this.lbAllUsers.Location = new System.Drawing.Point(114, 148);
            this.lbAllUsers.Name = "lbAllUsers";
            this.lbAllUsers.Size = new System.Drawing.Size(836, 214);
            this.lbAllUsers.TabIndex = 13;
            // 
            // bCanceldmin
            // 
            this.bCanceldmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.bCanceldmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCanceldmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCanceldmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bCanceldmin.Location = new System.Drawing.Point(603, 410);
            this.bCanceldmin.Name = "bCanceldmin";
            this.bCanceldmin.Size = new System.Drawing.Size(198, 57);
            this.bCanceldmin.TabIndex = 14;
            this.bCanceldmin.Text = "Лишить прав администратора";
            this.bCanceldmin.UseVisualStyleBackColor = false;
            this.bCanceldmin.Click += new System.EventHandler(this.bCanceldmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(305, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "Управление учётными записями";
            // 
            // MakeAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCanceldmin);
            this.Controls.Add(this.lbAllUsers);
            this.Controls.Add(this.bMakeAdmin);
            this.Controls.Add(this.bExitMain);
            this.Controls.Add(this.bBackToAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MakeAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeAdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBackToAdmin;
        private System.Windows.Forms.Button bExitMain;
        private System.Windows.Forms.Button bMakeAdmin;
        private System.Windows.Forms.ListBox lbAllUsers;
        private System.Windows.Forms.Button bCanceldmin;
        private System.Windows.Forms.Label label1;
    }
}