using System;
using System.ComponentModel;

namespace PropertiesWinForms
{
    public class Student
    {
        private string name_;
        private DateTime birthDay_;
        private string number_;
        private double avgBall_;

        [DisplayName("ФИО")]
        public string Name
        {
            get { return name_; }
            set { name_ = value; }
        }

        [DisplayName("Дата рождения")]
        public string BirthDay
        {
            get { return birthDay_.ToString("dd.mm.yyyy"); }
        }
        public void SetBirthDay(DateTime d)
        {
            birthDay_ = d;
        }

        [DisplayName("Номер билета")]
        public string Numder
        {
            get { return number_; }
            set { number_ = value; }
        }

        [DisplayName("Средний балл")]
        public double AVgBall
        {
            get { return avgBall_; }
            set { avgBall_ = value; }
        }
    }
}
