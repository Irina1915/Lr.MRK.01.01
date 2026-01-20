using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextUsing
{
    public partial class Form1: Form
    {
        int secretNum_;
        public Form1()
        {

            InitializeComponent();

            Random rnd = new Random();
            secretNum_ = rnd.Next(1, 101);
        }

        
        private void check_Click(object sender, EventArgs e)
        {
            string input = vvod.Text;
            int vod = Convert.ToInt32(input);

            if (secretNum_ == vod)
            {
                MessageBox.Show("ВЫ УГАДАЛИ!!!!!!!!!");
            }
            else if (secretNum_ > vod)
            {
                
            }
            else
            {

            }
        }

    }
}
