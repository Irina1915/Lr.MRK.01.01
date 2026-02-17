using ModelViewBiblioteka.Model_Views;
using ModelViewBiblioteka.View;
using ModelViewBiblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelViewMyForms
{
    public class UsersTableView : DataGridView, IUserView
    {
        // Явная реализация интерфейса (то, что предложила VS)
        void IUserView.ShowUser(List<User> allUsers_)
        {
            DataSource = allUsers_;
        } 
        public List<User> GetSelectedUsers()
        {
            List<User> result = new List<User>();
            foreach(var row in SelectedRows)
            {
                result.Add(row as User);
            }

            return result;
        }

        public void ShowUsers(List<User> users)
        {
            DataSource = users;
        }
    }
}
