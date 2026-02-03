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
            List<User> allUsers = new List<User>();
            string path = "Login and Parol.txt";
            StreamReader reader = new StreamReader(path);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] lines = line.Split('-');
                allUsers.Add(new User(lines[0], lines[1]));
            }
            return allUsers;
        }
    }
}

