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
        private FileUsersStorage AllLoginAndPassword = new FileUsersStorage();
        private List<string> logins = new List<string>();
        public Form1()
        {
            InitializeComponent();
            List<User> allers = new List<User>();
            allers = AllLoginAndPassword.Load();

            foreach (User u in allers)
            {
                logins.Add(u.Login);
            }

            comboBoxLogin.DataSource = logins;
        }


        private void EnterButton_Click(object sender, EventArgs e)
        {


            List<User> Alls = AllLoginAndPassword.Load();
            string login = comboBoxLogin.Text;
            string password = textBoxParol.Text;

            if (AllLoginAndPassword.Authorize(login, password))
            {
                MessageBox.Show("Молодец ");
            }
            else
            {
                MessageBox.Show("не взломаешь");
            }

        }

    }
}
