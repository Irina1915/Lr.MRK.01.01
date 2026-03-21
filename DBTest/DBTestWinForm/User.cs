using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTestWinForm
{
    public class User
    {
        [DisplayName("Логин")]
        public string Login { get; set; }
        [DisplayName("Пароль")]
        public string Password { get; set; }
        [DisplayName("Фамилия")]
        public string Lastname { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Номер телефона")]
        public string Phone { get; set; }
        [DisplayName("Почта")]
        public string Email { get; set; }
    }
}
