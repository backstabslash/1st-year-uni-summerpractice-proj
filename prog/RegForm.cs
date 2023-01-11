using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Users;

namespace RegisterForm
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        
        private void bRegistr_Click(object sender, EventArgs e)
        {
            string login = tBEnterLog.Text;
            if(tBEnterPass.Text== tBRepeatPass.Text && tBEnterLog.Text.Length != 0 && tBEnterPass.Text.Length!=0 && tBRepeatPass.Text.Length != 0 && User.CheckLogin(login))
            {
                string password = tBEnterPass.Text;
                User user1 = new User(login, password,false);
                User.SaveInXmlFormat(login, password);
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }else if (!User.CheckLogin(login))
            {
                lbErrorReg.Text = "Такой логин уже занят";
            }
            else if(tBEnterLog.Text.Length == 0 )
            {
                lbErrorReg.Text = "Вы не ввели логин";
            }
            else if (tBEnterPass.Text.Length == 0)
            {
                lbErrorReg.Text = "Вы не ввели пароль";
            }
            else 
            {
                lbErrorReg.Text = "Пароли не совпадают";
            }

        }

        private void bExitMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bBackToAdmin_Click(object sender, EventArgs e)
        {

        }

        private void bBackToAdmin_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
