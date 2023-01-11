
namespace prog
{
    partial class ProfitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfitForm));
            this.lbIncomeInfo = new System.Windows.Forms.Label();
            this.lbSpendingInfo = new System.Windows.Forms.Label();
            this.lbSpeding = new System.Windows.Forms.Label();
            this.lbIncome = new System.Windows.Forms.Label();
            this.bBack = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            this.lbProfit = new System.Windows.Forms.Label();
            this.lbProfitInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbIncomeInfo
            // 
            this.lbIncomeInfo.AutoSize = true;
            this.lbIncomeInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbIncomeInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIncomeInfo.Location = new System.Drawing.Point(328, 276);
            this.lbIncomeInfo.Name = "lbIncomeInfo";
            this.lbIncomeInfo.Size = new System.Drawing.Size(97, 28);
            this.lbIncomeInfo.TabIndex = 0;
            this.lbIncomeInfo.Text = "Прибыль";
            // 
            // lbSpendingInfo
            // 
            this.lbSpendingInfo.AutoSize = true;
            this.lbSpendingInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSpendingInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSpendingInfo.Location = new System.Drawing.Point(328, 343);
            this.lbSpendingInfo.Name = "lbSpendingInfo";
            this.lbSpendingInfo.Size = new System.Drawing.Size(88, 28);
            this.lbSpendingInfo.TabIndex = 1;
            this.lbSpendingInfo.Text = "Расходы";
            // 
            // lbSpeding
            // 
            this.lbSpeding.AutoSize = true;
            this.lbSpeding.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSpeding.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSpeding.Location = new System.Drawing.Point(224, 343);
            this.lbSpeding.Name = "lbSpeding";
            this.lbSpeding.Size = new System.Drawing.Size(92, 28);
            this.lbSpeding.TabIndex = 2;
            this.lbSpeding.Text = "Расходы:";
            // 
            // lbIncome
            // 
            this.lbIncome.AutoSize = true;
            this.lbIncome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbIncome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIncome.Location = new System.Drawing.Point(224, 276);
            this.lbIncome.Name = "lbIncome";
            this.lbIncome.Size = new System.Drawing.Size(101, 28);
            this.lbIncome.TabIndex = 3;
            this.lbIncome.Text = "Прибыль:";
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.Location = new System.Drawing.Point(464, 520);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(75, 23);
            this.bBack.TabIndex = 4;
            this.bBack.Text = "Назад";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Red;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bExit.Location = new System.Drawing.Point(609, -1);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(28, 23);
            this.bExit.TabIndex = 5;
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbText.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbText.Location = new System.Drawing.Point(188, 169);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(273, 45);
            this.lbText.TabIndex = 8;
            this.lbText.Text = "Прибыль склада";
            // 
            // lbProfit
            // 
            this.lbProfit.AutoSize = true;
            this.lbProfit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbProfit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProfit.Location = new System.Drawing.Point(224, 397);
            this.lbProfit.Name = "lbProfit";
            this.lbProfit.Size = new System.Drawing.Size(74, 28);
            this.lbProfit.TabIndex = 9;
            this.lbProfit.Text = "Доход:";
            // 
            // lbProfitInfo
            // 
            this.lbProfitInfo.AutoSize = true;
            this.lbProfitInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbProfitInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProfitInfo.Location = new System.Drawing.Point(328, 397);
            this.lbProfitInfo.Name = "lbProfitInfo";
            this.lbProfitInfo.Size = new System.Drawing.Size(70, 28);
            this.lbProfitInfo.TabIndex = 10;
            this.lbProfitInfo.Text = "Доход";
            // 
            // ProfitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 621);
            this.Controls.Add(this.lbProfitInfo);
            this.Controls.Add(this.lbProfit);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.lbIncome);
            this.Controls.Add(this.lbSpeding);
            this.Controls.Add(this.lbSpendingInfo);
            this.Controls.Add(this.lbIncomeInfo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIncomeInfo;
        private System.Windows.Forms.Label lbSpendingInfo;
        private System.Windows.Forms.Label lbSpeding;
        private System.Windows.Forms.Label lbIncome;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label lbProfit;
        private System.Windows.Forms.Label lbProfitInfo;
    }
}