using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RegisterForm;
using System.IO;
using System.Xml;

namespace prog
{
    public partial class AdminCheckLog : Form
    {
        public AdminCheckLog()
        {
            InitializeComponent();
            XMLToListBox(listBox1);
        }
        private void XMLToListBox(ListBox myListBox)
        {    
            myListBox.Items.Clear();
            FileStream fStream = new FileStream("Log.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fStream);
            for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count;)
            {
                myListBox.Items.Add(
                   xmlDoc.DocumentElement.ChildNodes[i].InnerText + " ");
                i++;
            } 
            fStream.Dispose();  
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

        private void bBackToAdmin_Click(object sender, EventArgs e)
        {

            this.Close();
            StoreAdminForm storeAdminForm = new StoreAdminForm();
            storeAdminForm.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
