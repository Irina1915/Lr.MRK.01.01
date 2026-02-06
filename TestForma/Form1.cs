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
        public MainForm()
        {
            InitializeComponent();
            List<User> allers = new List<User>();
            allers = AllLoginAndPassword.Load();

            foreach (User u in allers)
            {
                logins.Add(u.Login);
            }

            LoginСomboBox.DataSource = logins;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {


            List<User> Alls = AllLoginAndPassword.Load();
            string login = LoginСomboBox.Text;
            string password = PasswordTextBox.Text;

            if (AllLoginAndPassword.Authorize(login, password))
            {
                MessageBox.Show("Уроооо, ты смог зайти!!!");
            }
            else
            {
                MessageBox.Show("Оуууу ноу, не взламывай");
            }

        }

        private void LoginСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
