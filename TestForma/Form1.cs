using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForma
{
    public partial class Form1: Form
    {
        private FileUsersStorage AllPasswordAndLogin = new FileUsersStorage();
        public Form1()
        {
            InitializeComponent();
        }


        private void Vhod_Click(object sender, EventArgs e)
        {
            List<User> check = AllPasswordAndLogin.Load();
            string login = comboBoxLogin.Text;
            string parol = textBoxParol.Text;
            User u1 = new User(login, parol);

            if (Contains(check, u1))
            {
                MessageBox.Show("ето ты");
            }
            else
            {
                MessageBox.Show("ахахах, не взломаешь");
            }

        }
        private bool Contains(List<User> check, User u1)
        {
            foreach (User u in check)
            {
                if (u1.Login == u.Login && u1.Parol == u.Parol)
                {
                    return true;
                }
            }
            return false;

        }

        private void comboBoxLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUser = comboBoxLogin.SelectedItem.ToString();
            List<User> userSelected = 
        }
    }
}
