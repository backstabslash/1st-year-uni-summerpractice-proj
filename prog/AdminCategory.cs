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
    public partial class AdminCategory : Form
    {
        public AdminCategory()
        {
            InitializeComponent();
            cBDeleteProductType.Items.AddRange(File.ReadAllLines("Categories.txt"));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cBDeleteProductType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tBNewCategoryName_TextChanged(object sender, EventArgs e)
        {

        }

        private void bAddCategory_Click(object sender, EventArgs e)
        {

            if (tBNewCategoryName.TextLength > 0)
            {
                DialogResult result = MessageBox.Show(
                "Вы точно хотите добавить новую категорию? ",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    string NewCategory = tBNewCategoryName.Text;
                    Store store = new Store();
                    store.AddCategory(NewCategory);
                    string newCat = "Новая категория " + NewCategory;
                    Log.AddToLog("Добавление категориии :", " ", newCat);
                    this.Close();
                    AdminCategory adminCategory = new AdminCategory();
                    adminCategory.Show();
                    
                }
            }
            else
                lbNewprod.Text = "Введите название категории для добавления";
        }

        private void bDeleteCategories_Click(object sender, EventArgs e)
        {
            if (cBDeleteProductType.SelectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show(
                "Вы точно хотите удалить категорию? ",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    string oldCategory = cBDeleteProductType.Text;
                    Store store = new Store();
                    store.DeleteCategory(oldCategory);
                    string delCat = "Новая категория " + oldCategory;
                    Log.AddToLog("Удаление категориии", delCat, " ");
                    this.Close();
                    AdminCategory adminCategory = new AdminCategory();
                    adminCategory.Show();
                }
            }
            else
                lbNewprod2.Text = "Выберите категория для удаления товара";
        }

        private void AdminCategory_Load(object sender, EventArgs e)
        {

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
               MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                this.Show();
        }
    }
}
