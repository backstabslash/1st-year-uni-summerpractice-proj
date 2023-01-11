
namespace prog
{
    partial class AdminProfitModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProfitModify));
            this.lbOldMultyply = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.tBmultiply = new System.Windows.Forms.TextBox();
            this.lbMultiply = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bMultuply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOldMultyply
            // 
            this.lbOldMultyply.AutoSize = true;
            this.lbOldMultyply.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbOldMultyply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOldMultyply.Location = new System.Drawing.Point(392, 291);
            this.lbOldMultyply.Name = "lbOldMultyply";
            this.lbOldMultyply.Size = new System.Drawing.Size(45, 21);
            this.lbOldMultyply.TabIndex = 11;
            this.lbOldMultyply.Text = "коэф";
            this.lbOldMultyply.Click += new System.EventHandler(this.lbOldMultyply_Click);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Red;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bExit.Location = new System.Drawing.Point(627, 0);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(25, 23);
            this.bExit.TabIndex = 13;
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.Location = new System.Drawing.Point(480, 557);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(75, 23);
            this.bBack.TabIndex = 14;
            this.bBack.Text = "Назад";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // tBmultiply
            // 
            this.tBmultiply.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBmultiply.Location = new System.Drawing.Point(233, 373);
            this.tBmultiply.Name = "tBmultiply";
            this.tBmultiply.Size = new System.Drawing.Size(186, 34);
            this.tBmultiply.TabIndex = 15;
            this.tBmultiply.TextChanged += new System.EventHandler(this.tBmultiply_TextChanged);
            this.tBmultiply.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBmultiply_KeyPress);
            // 
            // lbMultiply
            // 
            this.lbMultiply.AutoSize = true;
            this.lbMultiply.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMultiply.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMultiply.Location = new System.Drawing.Point(111, 176);
            this.lbMultiply.Name = "lbMultiply";
            this.lbMultiply.Size = new System.Drawing.Size(427, 32);
            this.lbMultiply.TabIndex = 16;
            this.lbMultiply.Text = "Измение коэффициента доходности";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(219, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Текущий коэфициент:";
            // 
            // bMultuply
            // 
            this.bMultuply.BackColor = System.Drawing.SystemColors.Highlight;
            this.bMultuply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMultuply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMultuply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bMultuply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bMultuply.Location = new System.Drawing.Point(257, 450);
            this.bMultuply.Name = "bMultuply";
            this.bMultuply.Size = new System.Drawing.Size(129, 35);
            this.bMultuply.TabIndex = 18;
            this.bMultuply.Text = "Подтвердить";
            this.bMultuply.UseVisualStyleBackColor = false;
            this.bMultuply.Click += new System.EventHandler(this.bMultuply_Click_1);
            // 
            // AdminProfitModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 660);
            this.Controls.Add(this.bMultuply);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMultiply);
            this.Controls.Add(this.tBmultiply);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.lbOldMultyply);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminProfitModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminProfitModify";
            this.Load += new System.EventHandler(this.AdminProfitModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOldMultyply;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.TextBox tBmultiply;
        private System.Windows.Forms.Label lbMultiply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bMultuply;
    }
}