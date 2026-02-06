using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForma
{
    public class FileUsersStorage : IUsersInterface
    {
        public List<User> Load()
        {
            List<User> allers = new List<User>();
            string patch = "LoginAndPassword.txt";
            StreamReader reader = new StreamReader(patch);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] lines = line.Split('-');
                allers.Add(new User(lines[0], lines[1]));
            }
            return allers;
        }
        public bool Authorize(string login, string password)
        {
            List<User> Alls = Load();
            User user = new User(login, password);
            return Contains(Alls, user);
        }
        private bool Contains(List<User> users, User user)
        {
            foreach (User u in users)
            {
                if (user.Login == u.Login && u.Parol == user.Parol)
                {
                    return true;
                }
            }

            return false;
        }

    }

}

