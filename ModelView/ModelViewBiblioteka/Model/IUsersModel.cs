using ModelViewBiblioteka.Model_Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewBiblioteka.Model
{
    public interface IUsersModel
    {
        List<User> LoadUser();
        bool Registration(User user);
        void RemoveUsers(List<User> users);
    }
}
