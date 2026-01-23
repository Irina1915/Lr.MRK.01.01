using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();

            List<Student> Students = new List<Student>();
            Students.Add(new Student("Стив Харингтон", 15, 3.4, 69, "D:\\П-30 буд\\Репозиторий\\i (1).webp"));
            Students.Add(new Student("Кастиэль Винчестер", 17,4.9, 77, "D:\\П-30 буд\\Репозиторий\\i (2).webp"));
            Students.Add(new Student("Робин Бакли", 16, 2.9, 59, "D:\\П-30 буд\\Репозиторий\\i (3).webp"));
            Students.Add(new Student("Макс Мейфилд", 15, 4.5, 65, "D:\\П-30 буд\\Репозиторий\\i(4).jpg"));

            st_list.DataSource = Students;

            st_list.DisplayMember = "Name";
        }

        private void st_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student student = st_list.SelectedItem as Student;
            label_name.Text = student.Name;

            label_age.Text = student.Age;

            label_avg.Text = student.Arg;

            label_num.Text = student.NumBilet;

            fotoSt.Image = student.Foto;
        }
    }

    
}
