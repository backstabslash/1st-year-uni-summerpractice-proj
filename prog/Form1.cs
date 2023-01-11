using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RegisterForm;

namespace prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string p = File.ReadAllText("Profit.txt");
            string s = File.ReadAllText("Spending.txt");
            lbIncomeInfo.Text = p;
            lbSpendingInfo.Text = s;
            lbProfitInfo.Text = Convert.ToString(Convert.ToDecimal(p) - Convert.ToDecimal(s));
        }
     
        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            StoreAdminForm storeAdminForm = new StoreAdminForm();
            storeAdminForm.Show();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы точно хотите выйти?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
