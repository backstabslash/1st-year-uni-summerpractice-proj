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
    public partial class AdminProfitModify : Form
    {
        public AdminProfitModify()
        {
            InitializeComponent();
            bMultuply.Enabled = false;
            lbOldMultyply.Text = File.ReadAllText("Multiply.txt");
        }

        private void AdminProfitModify_Load(object sender, EventArgs e)
        {


        }

        private void tBmultiply_TextChanged(object sender, EventArgs e)
        {

            if (tBmultiply.TextLength != 0)
            {
                bMultuply.Enabled = true;
            }
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

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            StoreAdminForm storeAdminForm = new StoreAdminForm();
            storeAdminForm.Show();
        }

        private void lbOldMultyply_Click(object sender, EventArgs e)
        {

        }

        private void bMultuply_Click(object sender, EventArgs e)
        {

        }

        private void tBmultiply_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == ',') || (e.KeyChar == 8))
            {
                return;
            }
            e.Handled = true;
        }

        private void bMultuply_Click_1(object sender, EventArgs e)
        {
            if (tBmultiply.TextLength != 0)
            {
                bMultuply.Enabled = true;
                string oldKef = File.ReadAllText("Multiply.txt");
                File.WriteAllText("Multiply.txt", tBmultiply.Text);
                DialogResult result = MessageBox.Show(
                "Коэффициент успешно изменён",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                string newKef = File.ReadAllText("Multiply.txt");
                Log.AddToLog("Изменение коэффициента", oldKef, newKef);
                this.Close();
                AdminProfitModify adminProfitModify = new AdminProfitModify();
                adminProfitModify.Show();
            }
        }
    }
}
