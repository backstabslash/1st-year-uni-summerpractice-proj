
namespace prog
{
    partial class ChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.bExitMain = new System.Windows.Forms.Button();
            this.lbEnterLogin = new System.Windows.Forms.Label();
            this.tBlog = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.bEnter = new System.Windows.Forms.Button();
            this.lbPass = new System.Windows.Forms.Label();
            this.tBpass = new System.Windows.Forms.TextBox();
            this.lbPass2 = new System.Windows.Forms.Label();
            this.tBpass2 = new System.Windows.Forms.TextBox();
            this.lbWrongPass = new System.Windows.Forms.Label();
            this.bBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bExitMain
            // 
            this.bExitMain.BackColor = System.Drawing.Color.Red;
            this.bExitMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExitMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExitMain.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bExitMain.ForeColor = System.Drawing.Color.Black;
            this.bExitMain.Location = new System.Drawing.Point(626, -2);
            this.bExitMain.Name = "bExitMain";
            this.bExitMain.Size = new System.Drawing.Size(26, 25);
            this.bExitMain.TabIndex = 8;
            this.bExitMain.UseVisualStyleBackColor = false;
            this.bExitMain.Click += new System.EventHandler(this.bExitMain_Click);
            // 
            // lbEnterLogin
            // 
            this.lbEnterLogin.AutoSize = true;
            this.lbEnterLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbEnterLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEnterLogin.ForeColor = System.Drawing.Color.Black;
            this.lbEnterLogin.Location = new System.Drawing.Point(202, 151);
            this.lbEnterLogin.Name = "lbEnterLogin";
            this.lbEnterLogin.Size = new System.Drawing.Size(235, 45);
            this.lbEnterLogin.TabIndex = 9;
            this.lbEnterLogin.Text = "Смена пароля";
            this.lbEnterLogin.Click += new System.EventHandler(this.lbEnterLogin_Click);
            // 
            // tBlog
            // 
            this.tBlog.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBlog.Location = new System.Drawing.Point(269, 279);
            this.tBlog.Name = "tBlog";
            this.tBlog.Size = new System.Drawing.Size(252, 32);
            this.tBlog.TabIndex = 10;
            this.tBlog.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLogin.ForeColor = System.Drawing.Color.Silver;
            this.lbLogin.Location = new System.Drawing.Point(89, 279);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(65, 25);
            this.lbLogin.TabIndex = 11;
            this.lbLogin.Text = "Логин";
            this.lbLogin.Click += new System.EventHandler(this.lbLogin_Click);
            // 
            // bEnter
            // 
            this.bEnter.BackColor = System.Drawing.SystemColors.Highlight;
            this.bEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bEnter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bEnter.Location = new System.Drawing.Point(259, 512);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(120, 35);
            this.bEnter.TabIndex = 12;
            this.bEnter.Text = "Подтвердить";
            this.bEnter.UseVisualStyleBackColor = false;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPass.ForeColor = System.Drawing.Color.Silver;
            this.lbPass.Location = new System.Drawing.Point(89, 331);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(138, 25);
            this.lbPass.TabIndex = 13;
            this.lbPass.Text = "Новый пароль";
            // 
            // tBpass
            // 
            this.tBpass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBpass.Location = new System.Drawing.Point(269, 324);
            this.tBpass.Name = "tBpass";
            this.tBpass.Size = new System.Drawing.Size(252, 32);
            this.tBpass.TabIndex = 14;
            this.tBpass.TextChanged += new System.EventHandler(this.tBpass_TextChanged);
            // 
            // lbPass2
            // 
            this.lbPass2.AutoSize = true;
            this.lbPass2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPass2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPass2.ForeColor = System.Drawing.Color.Silver;
            this.lbPass2.Location = new System.Drawing.Point(89, 391);
            this.lbPass2.Name = "lbPass2";
            this.lbPass2.Size = new System.Drawing.Size(174, 25);
            this.lbPass2.TabIndex = 15;
            this.lbPass2.Text = "Повторите пароль";
            // 
            // tBpass2
            // 
            this.tBpass2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBpass2.Location = new System.Drawing.Point(269, 388);
            this.tBpass2.Name = "tBpass2";
            this.tBpass2.Size = new System.Drawing.Size(252, 32);
            this.tBpass2.TabIndex = 16;
            this.tBpass2.TextChanged += new System.EventHandler(this.tBpass2_TextChanged);
            // 
            // lbWrongPass
            // 
            this.lbWrongPass.AutoSize = true;
            this.lbWrongPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbWrongPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWrongPass.Location = new System.Drawing.Point(295, 452);
            this.lbWrongPass.Name = "lbWrongPass";
            this.lbWrongPass.Size = new System.Drawing.Size(0, 19);
            this.lbWrongPass.TabIndex = 17;
            this.lbWrongPass.Click += new System.EventHandler(this.lbWrongPass_Click);
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.Location = new System.Drawing.Point(480, 555);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(75, 23);
            this.bBack.TabIndex = 18;
            this.bBack.Text = "Назад";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 660);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.lbWrongPass);
            this.Controls.Add(this.tBpass2);
            this.Controls.Add(this.lbPass2);
            this.Controls.Add(this.tBpass);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.tBlog);
            this.Controls.Add(this.lbEnterLogin);
            this.Controls.Add(this.bExitMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bExitMain;
        private System.Windows.Forms.Label lbEnterLogin;
        private System.Windows.Forms.TextBox tBlog;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox tBpass;
        private System.Windows.Forms.Label lbPass2;
        private System.Windows.Forms.TextBox tBpass2;
        private System.Windows.Forms.Label lbWrongPass;
        private System.Windows.Forms.Button bBack;
    }
}