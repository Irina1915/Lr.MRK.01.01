using System.Collections.Generic;
using System.Windows.Forms;

namespace PropertiesWinForms
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Что-то нажали");
        }

        private void ShowButton_Click(object sender, System.EventArgs e)
        {
            /// 0. Определить источник данных (предполагаем, что это будет список студентов)
            /// 1. Определить столбцы таблицы (атрибуты объектов)
            /// В данном контексте это будут: ФИО, дата рождения, номер билета, средний балл
            /// 2. Перенести данные источника в виде строк в таблицу,
            /// причем важно соблюдать порядок следования данных в соотвествие с порядком столбцов.


            /// Задача #0
            List<Student> allStudents = new List<Student>();

            Student st1 = new Student();
            st1.Name = "Иванов Иван Иванович";
            st1.SetBirthDay(new System.DateTime(1997, 11, 27));
            st1.Numder = "Студ.билет 1234";
            st1.AVgBall = 2.63;

            Student st2 = new Student();
            st2.Name = "Петрова Ольга Дмитриевна";
            st2.SetBirthDay(new System.DateTime(2000, 12, 31));
            st2.Numder = "Студ.билет 1908";
            st2.AVgBall = 4.66;

            allStudents.Add(st1);
            allStudents.Add(st2);

            StudentsTable.DataSource = allStudents;
        }
    }
}
