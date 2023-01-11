using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Users;
using RegisterForm;

namespace prog
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void bExitMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {

        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            if (!User.CheckLogin(tBlog.Text) && tBpass.Text == tBpass2.Text)
            {
                User.ChangePassword(tBlog.Text, tBpass.Text);
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();


            }
            else if(User.CheckLogin(tBlog.Text))
            {
                lbWrongPass.Text = "Неверный логин";
            }
            else if (tBpass.Text != tBpass2.Text)
            {
                lbWrongPass.Text = "Пароли не совпадают";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbEnterLogin_Click(object sender, EventArgs e)
        {

        }

        private void tBpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBpass2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbWrongPass_Click(object sender, EventArgs e)
        {

        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
