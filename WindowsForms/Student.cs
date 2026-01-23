using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    class Student
    {
        private string name_;
        private int age_;
        private double arg_;
        private int numBilet_;
        private string foto_;
      

        public Student()
        {
            name_ = "Вася Пупкин";
            age_ = 15;
        }


        public string Name
        {
           get{ return name_; }
        }


        public string  Age
        {
            get { return Convert.ToString(age_); }
        }

        public string Arg
        {
            get { return Convert.ToString(arg_); }
        }


        public string NumBilet
        {
            get { return Convert.ToString(numBilet_); }
        }

        public string Foto
        {
            get { return foto_; }
        }



        public Student(string name, int age, double arg, int numBilet, string foto)
        {
            this.name_ = name;
            this.age_ = age;
            this.arg_ = arg; 
            this.numBilet_ = numBilet;
            this.foto_ = foto;
        }
    }
}
