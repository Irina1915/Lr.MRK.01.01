using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TestForma
{
    public class User
    {
        private string login_;
        private string parol_;
        
        public User( string log, string par)
        {
            login_ = log;
            parol_ = par;
        }

        public string Login
        {
            get { return login_; }
        }

        public string Parol
        {
            get { return parol_; }
        }

    }
}
