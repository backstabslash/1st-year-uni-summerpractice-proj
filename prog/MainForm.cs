using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;
using prog;

namespace RegisterForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            bEnter.Enabled = false;
        }
        private void tBlogin_TextChanged(object sender, EventArgs e)
        {
            if ((tBlogin.Text.Length == 0) || (tBPassword.Text.Length == 0))
            {
                bEnter.Enabled = false;
            }
            else
            {
                bEnter.Enabled = true;
            }
        }
        private void bEnter_Click(object sender, EventArgs e)
        {
            string login = tBlogin.Text;
            string password = tBPassword.Text;

            if(User.CheckLoginPassword(login, password) && User.CheckAdmin(login, password))
            {
               
                this.Hide();
                StoreAdminForm storeAdminForm = new StoreAdminForm();
                storeAdminForm.Show();

            }else if (User.CheckLoginPassword(login, password) )
            {
               
                this.Hide();
                StoreUserForm storeUserForm = new StoreUserForm();
                storeUserForm.Show();
            }
            else
            {
                lbWrongArgument.Text = "Неверный логин или пароль";
            }

            
        }

        private void bNoAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegForm regForm = new RegForm();
            regForm.Show();
        }

        private void bExitMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bForgetPass_Click(object sender, EventArgs e)
        {
            
        }

        private void lbChangePass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePass changePass = new ChangePass();
            changePass.Show();
        }
    }
}
