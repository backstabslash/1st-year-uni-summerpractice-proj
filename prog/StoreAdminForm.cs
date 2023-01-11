using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using prog;

namespace RegisterForm
{
    public partial class StoreAdminForm : Form
    {
        public StoreAdminForm()
        {
            InitializeComponent();
        }
        private void bExitMain_Click(object sender, EventArgs e)
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

        private void bAddProducts_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminAddproductsForm adminAddproductsForm = new AdminAddproductsForm();
            adminAddproductsForm.Show();
        }

        private void bIncome_Click(object sender, EventArgs e)
        {
            this.Close();
            Form adminProfitForm = new ProfitForm();
            adminProfitForm.Show();
        }

        private void bMakeAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            MakeAdminForm makeAdminForm = new MakeAdminForm();
            makeAdminForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы точно хотите выйти?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminProfitModify adminProfitModify = new AdminProfitModify ();
            adminProfitModify.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            AdminCategory adminCategory = new AdminCategory();
            adminCategory.Show();
        }

        private void bBackToAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminCheckLog checkLog = new AdminCheckLog();
            checkLog.Show();
        }
    }
}
