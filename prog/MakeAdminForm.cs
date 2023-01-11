using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RegisterForm;
using Users;

namespace prog
{
    public partial class MakeAdminForm : Form
    {
        public MakeAdminForm()
        {
            InitializeComponent();
            int i = 0;
            foreach (User user1 in User.ShowUsers())
            {
                lbAllUsers.Items.Add("Логин: " + user1.Login    + "  Администратор :  " + user1.Isadmin);
            }
        }

        private void bBackToAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            StoreAdminForm storeAdminForm = new StoreAdminForm();
            storeAdminForm.Show();
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

        private void cLBAllUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bMakeAdmin_Click(object sender, EventArgs e)
        {
            User user = new User();
            List <User> users =User.ShowUsers();
            users[lbAllUsers.SelectedIndex].MakeAdmin(users[lbAllUsers.SelectedIndex].Login, users[lbAllUsers.SelectedIndex].Password);
            this.Close();
            MakeAdminForm makeAdminForm = new MakeAdminForm();
            makeAdminForm.Show();
        }

        private void bCanceldmin_Click(object sender, EventArgs e)
        {
            User user = new User();
            List<User> users = User.ShowUsers();
            users[lbAllUsers.SelectedIndex].CancelAdmin(users[lbAllUsers.SelectedIndex].Login, users[lbAllUsers.SelectedIndex].Password);
            this.Close();
            MakeAdminForm makeAdminForm = new MakeAdminForm();
            makeAdminForm.Show();
        }
    }
}
