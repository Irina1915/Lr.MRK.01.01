using ModelViewBiblioteka.Model_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewBiblioteka.View
{
    public interface IUserView
    {
        void ShowUser(List<User> allUsers_);
        List<User> GetSelectedUsers();
    }
}
