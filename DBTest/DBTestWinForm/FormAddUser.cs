using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTestWinForm
{
    public partial class FormAddUser: Form
    {
        private User users_;
        public User users
        {
            get { return users_; }
        }
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            //if(textBoxLogin.ToString() != "" &&
            //    textBoxPassword.ToString() != "" &&
            //    textBoxLastame.ToString() != "" &&
            //    textBoxName.ToString() != "" &&
            //    textBoxPhone.ToString() != "" &&
            //    textBoxEmail.ToString() != "")
 
            //{
            //    DialogResult = DialogResult.Yes;
            //    AllUser.Add(textBoxLogin.Text, textBoxPassword.ToString, textBoxLastame.ToString, textBoxName.ToString, textBoxPhone.ToString, textBoxEmail.ToString);
            //}
            //else
            //{
            //    MessageBox.Show("");
            //    DialogResult = DialogResult.No;
            //}
            //Close();
        }
    }
}
