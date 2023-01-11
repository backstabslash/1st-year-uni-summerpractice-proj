
namespace RegisterForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        private System.Windows.Forms.Label lbAutorize;
        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.Label lbpassword;
        static public System.Windows.Forms.TextBox tBlogin;
        private System.Windows.Forms.TextBox tBPassword;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.Button bNoAcc;
        private System.Windows.Forms.Button bExitMain;
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbAutorize = new System.Windows.Forms.Label();
            this.lblogin = new System.Windows.Forms.Label();
            this.lbpassword = new System.Windows.Forms.Label();
            tBlogin = new System.Windows.Forms.TextBox();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.bEnter = new System.Windows.Forms.Button();
            this.bNoAcc = new System.Windows.Forms.Button();
            this.bExitMain = new System.Windows.Forms.Button();
            this.lbWrongArgument = new System.Windows.Forms.Label();
            this.lbChangePass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAutorize
            // 
            this.lbAutorize.AutoSize = true;
            this.lbAutorize.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAutorize.Location = new System.Drawing.Point(220, 169);
            this.lbAutorize.Name = "lbAutorize";
            this.lbAutorize.Size = new System.Drawing.Size(217, 45);
            this.lbAutorize.TabIndex = 0;
            this.lbAutorize.Text = "Авторизация";
            this.lbAutorize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblogin.ForeColor = System.Drawing.Color.Silver;
            this.lblogin.Location = new System.Drawing.Point(94, 285);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(69, 28);
            this.lblogin.TabIndex = 1;
            this.lblogin.Text = "Логин";
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbpassword.ForeColor = System.Drawing.Color.Silver;
            this.lbpassword.Location = new System.Drawing.Point(94, 348);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(81, 28);
            this.lbpassword.TabIndex = 2;
            this.lbpassword.Text = "Пароль";
            // 
            // tBlogin
            // 
            tBlogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tBlogin.Location = new System.Drawing.Point(182, 281);
            tBlogin.Name = "tBlogin";
            tBlogin.Size = new System.Drawing.Size(296, 34);
            tBlogin.TabIndex = 3;
            tBlogin.TextChanged += new System.EventHandler(this.tBlogin_TextChanged);
            // 
            // tBPassword
            // 
            this.tBPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBPassword.Location = new System.Drawing.Point(182, 344);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.PasswordChar = '*';
            this.tBPassword.Size = new System.Drawing.Size(296, 34);
            this.tBPassword.TabIndex = 4;
            this.tBPassword.TextChanged += new System.EventHandler(this.tBlogin_TextChanged);
            // 
            // bEnter
            // 
            this.bEnter.BackColor = System.Drawing.SystemColors.Highlight;
            this.bEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnter.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bEnter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bEnter.Location = new System.Drawing.Point(271, 468);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(116, 35);
            this.bEnter.TabIndex = 5;
            this.bEnter.Text = "Войти";
            this.bEnter.UseVisualStyleBackColor = false;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // bNoAcc
            // 
            this.bNoAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNoAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNoAcc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bNoAcc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bNoAcc.Location = new System.Drawing.Point(220, 521);
            this.bNoAcc.Name = "bNoAcc";
            this.bNoAcc.Size = new System.Drawing.Size(218, 42);
            this.bNoAcc.TabIndex = 6;
            this.bNoAcc.Text = "Ещё нет аккаунта?";
            this.bNoAcc.UseVisualStyleBackColor = true;
            this.bNoAcc.Click += new System.EventHandler(this.bNoAcc_Click);
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
            this.bExitMain.TabIndex = 7;
            this.bExitMain.UseVisualStyleBackColor = false;
            this.bExitMain.Click += new System.EventHandler(this.bExitMain_Click);
            // 
            // lbWrongArgument
            // 
            this.lbWrongArgument.AutoSize = true;
            this.lbWrongArgument.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWrongArgument.Location = new System.Drawing.Point(220, 436);
            this.lbWrongArgument.Name = "lbWrongArgument";
            this.lbWrongArgument.Size = new System.Drawing.Size(0, 20);
            this.lbWrongArgument.TabIndex = 8;
            // 
            // lbChangePass
            // 
            this.lbChangePass.AutoSize = true;
            this.lbChangePass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbChangePass.Location = new System.Drawing.Point(182, 381);
            this.lbChangePass.Name = "lbChangePass";
            this.lbChangePass.Size = new System.Drawing.Size(112, 19);
            this.lbChangePass.TabIndex = 9;
            this.lbChangePass.Text = "Забыли пароль?";
            this.lbChangePass.Click += new System.EventHandler(this.lbChangePass_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 660);
            this.Controls.Add(this.lbChangePass);
            this.Controls.Add(this.lbWrongArgument);
            this.Controls.Add(this.bExitMain);
            this.Controls.Add(this.bNoAcc);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.lblogin);
            this.Controls.Add(this.lbAutorize);
            this.Controls.Add(tBlogin);
            this.Controls.Add(this.tBPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lbWrongArgument;
        private System.Windows.Forms.Label lbChangePass;

        public string SetWrongArg{ 
            set{
            lbWrongArgument.Text =value;
            }
            }


    }
}

