using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBd
{
    public class PgUsersLoader
    {
        public List<User> LoadUsers()
        {
            List<User> allUsers = new List<User>();
            var cs = "Host=192.168.1.48;Username=st50-3;Password=503;Database=Student";
            var con = new NpgsqlConnection(cs);

            con.Open();
            var sql = "SELECT login,password,lastame,name,phone,email  FROM myuser";
            var cmd = new NpgsqlCommand(sql, con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                allUsers.Add(new User
                {
                    Login = reader.GetString(0),
                    Password = reader.GetString(1),
                    Lastname = reader.GetString(2),
                    Name = reader.GetString(3),
                    Phone = reader.GetString(4),
                    Email = reader.GetString(5)

                });
            }
            con.Close();

            return allUsers;


            // Построить запрос DELETE
            var sql_del = @"DELETE FROM students WHERE id = @id";

            try
            {
                // Создать источник данных
                var cs_del = "Host=192.168.1.48;Username=st50-3;Password=503;Database=Student";
                // Создать объект Command
                var cmd_del = new NpgsqlCommand(sql, con);
                // Привязать параметры
                cmd.Parameters.AddWithValue("@id", 1);
                // Выполнить запрос DELETE
                cmd.ExecuteNonQueryAsync();
                Console.WriteLine("The row has been deleted successfully.");
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

    }
}
