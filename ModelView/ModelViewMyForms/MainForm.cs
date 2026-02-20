using ModelViewBiblioteka.Model;
using ModelViewBiblioteka.Model_Views;
using ModelViewBiblioteka.Presenter;
using ModelViewBiblioteka.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelViewMyForms
{
    public partial class MainForm : Form
    {
        private UserPresenter presenter_;
        UsersTableView usertable;
        public MainForm()
        {
            InitializeComponent();
            usertable = new UsersTableView();
            Controls.Add(usertable);
            usertable.Dock = DockStyle.Top;

            UserPresenter userPresenter = new UserPresenter(new MemoryUserModel(), usertable);
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить пользователя?", "Внимание!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<User> selectetUsers = usertable.GetSelectedUsers();
                presenter_.Remove(selectetUsers);
            }
        }
    }
}