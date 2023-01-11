
namespace RegisterForm
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.lbRegistr = new System.Windows.Forms.Label();
            this.lbNewLogin = new System.Windows.Forms.Label();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.lbRepeatPass = new System.Windows.Forms.Label();
            this.tBEnterLog = new System.Windows.Forms.TextBox();
            this.tBEnterPass = new System.Windows.Forms.TextBox();
            this.tBRepeatPass = new System.Windows.Forms.TextBox();
            this.lbErrorReg = new System.Windows.Forms.Label();
            this.bRegistr = new System.Windows.Forms.Button();
            this.bExitMain = new System.Windows.Forms.Button();
            this.bBackToAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRegistr
            // 
            this.lbRegistr.AutoSize = true;
            this.lbRegistr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbRegistr.Font = new System.Drawing.Font("Segoe UI Semibold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRegistr.Location = new System.Drawing.Point(216, 147);
            this.lbRegistr.Name = "lbRegistr";
            this.lbRegistr.Size = new System.Drawing.Size(215, 45);
            this.lbRegistr.TabIndex = 0;
            this.lbRegistr.Text = "Регистрация";
            // 
            // lbNewLogin
            // 
            this.lbNewLogin.AutoSize = true;
            this.lbNewLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNewLogin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNewLogin.ForeColor = System.Drawing.Color.Silver;
            this.lbNewLogin.Location = new System.Drawing.Point(97, 239);
            this.lbNewLogin.Name = "lbNewLogin";
            this.lbNewLogin.Size = new System.Drawing.Size(165, 25);
            this.lbNewLogin.TabIndex = 1;
            this.lbNewLogin.Text = "Придумайте логин";
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNewPass.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNewPass.ForeColor = System.Drawing.Color.Silver;
            this.lbNewPass.Location = new System.Drawing.Point(97, 291);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(177, 25);
            this.lbNewPass.TabIndex = 2;
            this.lbNewPass.Text = "Придумайте пароль";
            // 
            // lbRepeatPass
            // 
            this.lbRepeatPass.AutoSize = true;
            this.lbRepeatPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbRepeatPass.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRepeatPass.ForeColor = System.Drawing.Color.Silver;
            this.lbRepeatPass.Location = new System.Drawing.Point(97, 355);
            this.lbRepeatPass.Name = "lbRepeatPass";
            this.lbRepeatPass.Size = new System.Drawing.Size(165, 25);
            this.lbRepeatPass.TabIndex = 3;
            this.lbRepeatPass.Text = "Повторите пароль";
            // 
            // tBEnterLog
            // 
            this.tBEnterLog.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBEnterLog.Location = new System.Drawing.Point(286, 239);
            this.tBEnterLog.Name = "tBEnterLog";
            this.tBEnterLog.Size = new System.Drawing.Size(247, 31);
            this.tBEnterLog.TabIndex = 4;
            // 
            // tBEnterPass
            // 
            this.tBEnterPass.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBEnterPass.Location = new System.Drawing.Point(286, 285);
            this.tBEnterPass.Name = "tBEnterPass";
            this.tBEnterPass.PasswordChar = '*';
            this.tBEnterPass.Size = new System.Drawing.Size(247, 31);
            this.tBEnterPass.TabIndex = 5;
            // 
            // tBRepeatPass
            // 
            this.tBRepeatPass.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBRepeatPass.Location = new System.Drawing.Point(286, 349);
            this.tBRepeatPass.Name = "tBRepeatPass";
            this.tBRepeatPass.PasswordChar = '*';
            this.tBRepeatPass.Size = new System.Drawing.Size(247, 31);
            this.tBRepeatPass.TabIndex = 6;
            // 
            // lbErrorReg
            // 
            this.lbErrorReg.AutoSize = true;
            this.lbErrorReg.BackColor = System.Drawing.Color.Transparent;
            this.lbErrorReg.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbErrorReg.Location = new System.Drawing.Point(245, 405);
            this.lbErrorReg.Name = "lbErrorReg";
            this.lbErrorReg.Size = new System.Drawing.Size(0, 20);
            this.lbErrorReg.TabIndex = 7;
            // 
            // bRegistr
            // 
            this.bRegistr.BackColor = System.Drawing.SystemColors.Highlight;
            this.bRegistr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRegistr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRegistr.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bRegistr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bRegistr.Location = new System.Drawing.Point(220, 450);
            this.bRegistr.Name = "bRegistr";
            this.bRegistr.Size = new System.Drawing.Size(211, 46);
            this.bRegistr.TabIndex = 8;
            this.bRegistr.Text = "Зарегистрироваться";
            this.bRegistr.UseVisualStyleBackColor = false;
            this.bRegistr.Click += new System.EventHandler(this.bRegistr_Click);
            // 
            // bExitMain
            // 
            this.bExitMain.BackColor = System.Drawing.Color.Red;
            this.bExitMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExitMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExitMain.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bExitMain.ForeColor = System.Drawing.Color.Red;
            this.bExitMain.Location = new System.Drawing.Point(625, -2);
            this.bExitMain.Name = "bExitMain";
            this.bExitMain.Size = new System.Drawing.Size(26, 25);
            this.bExitMain.TabIndex = 9;
            this.bExitMain.UseVisualStyleBackColor = false;
            this.bExitMain.Click += new System.EventHandler(this.bExitMain_Click);
            // 
            // bBackToAdmin
            // 
            this.bBackToAdmin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bBackToAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBackToAdmin.Location = new System.Drawing.Point(476, 552);
            this.bBackToAdmin.Name = "bBackToAdmin";
            this.bBackToAdmin.Size = new System.Drawing.Size(75, 23);
            this.bBackToAdmin.TabIndex = 13;
            this.bBackToAdmin.Text = "Назад";
            this.bBackToAdmin.UseVisualStyleBackColor = false;
            this.bBackToAdmin.Click += new System.EventHandler(this.bBackToAdmin_Click_1);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 660);
            this.Controls.Add(this.bBackToAdmin);
            this.Controls.Add(this.bExitMain);
            this.Controls.Add(this.bRegistr);
            this.Controls.Add(this.lbErrorReg);
            this.Controls.Add(this.tBRepeatPass);
            this.Controls.Add(this.tBEnterPass);
            this.Controls.Add(this.tBEnterLog);
            this.Controls.Add(this.lbRepeatPass);
            this.Controls.Add(this.lbNewPass);
            this.Controls.Add(this.lbNewLogin);
            this.Controls.Add(this.lbRegistr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRegistr;
        private System.Windows.Forms.Label lbNewLogin;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.Label lbRepeatPass;
        private System.Windows.Forms.TextBox tBEnterLog;
        private System.Windows.Forms.TextBox tBEnterPass;
        private System.Windows.Forms.TextBox tBRepeatPass;
        private System.Windows.Forms.Label lbErrorReg;
        private System.Windows.Forms.Button bRegistr;
        private System.Windows.Forms.Button bExitMain;
        private System.Windows.Forms.Button bBackToAdmin;
    }
}