using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Bd
{
    public partial class Main: Form
    {
        public Main()
        {
            InitializeComponent();

            var cs = "Host=192.168.1.48;Username=st50-3;Password=503;Database=Student";

            var con = new NpgsqlConnection(cs);
            con.Open();

            var sql = "SELECT login FROM myuser";

            var cmd = new NpgsqlCommand(sql, con);

            var reader = cmd.ExecuteReader();

            List<string> logins = new List<string>();
            while(reader.Read())
            {
                string log = reader.GetString(0);
                string password = reader.GetString(0);
                logins.Add(log +": " + password);
            }

            MessageBox.Show($"{logins}");

        }
    }
}
