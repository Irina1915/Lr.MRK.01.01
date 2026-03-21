using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTestWinForm
{
    public class PgUsersLoader
    {
        BindingList<User> AllUser = new BindingList<User>();
        private const string connectSetting = "Host=192.168.1.48;Username=st50-3;Password=503;Database=Student";
        public BindingList<User> Load() 
        {
            try
            {
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT login,password,lastame,name,phone,email  FROM myuser";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User
                    {
                        Login = reader.GetString(0),
                        Password = reader.GetString(1),
                        Lastname = reader.GetString(2),
                        Name = reader.GetString(3),
                        Phone = reader.GetString(4),
                        Email = reader.GetString(5)
                    };
                    AllUser.Add(user);
                }
                return AllUser;
            }
            catch(NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return null;
            }
        } 
        
        public bool DeleteSelectedUser(string Login)
        {
            try
            {
                bool results = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "DELETE FROM myuser Where login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", Login);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    results = true;
                }

                for (int i = 0; i < AllUser.Count; i++)
                {
                    if (AllUser[i].Login == Login)
                    {
                        AllUser.RemoveAt(i);
                        i--;
                    }
                }
                return results;

            }
            catch (NpgsqlException exception) 
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }

        public bool ClearUsers()
        {

            bool result = false;
            var con = new NpgsqlConnection(connectSetting);
            var sql = "DELETE FROM myuser";
            con.Open();
            var cmd = new NpgsqlCommand(sql, con);
            int execute = cmd.ExecuteNonQuery();
            if(execute > 0)
            {
                result = true;
            }
            AllUser.Clear();
            return result;
        }

        public bool AddUsers()
        {
            bool result = false;
            var con = new NpgsqlConnection(connectSetting);
            var sql = "INSERT INTO myuser (login,password,lastame,name,phone,email) VALUES (login,password,lastame,name,phone,email)";
            con.Open();
            var cmd = new NpgsqlCommand(sql, con);
            int execute = cmd.ExecuteNonQuery();
            if (execute > 0)
            {
                result = true;
            }


            return result;
        }



    }
}
