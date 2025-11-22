using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFS_Console
{
    class Car
    {
        private string model_;
        private int speed_;

        public string GetModel()
        {
            return model_;
        }

        public void SetModel(string model)
        {
            model_ = model;
        }

        public int GetSpeed()
        {
            return speed_;
        }

        public void SetSpeed(int speed)
        {
            speed_ = speed;
        }


    }
}
