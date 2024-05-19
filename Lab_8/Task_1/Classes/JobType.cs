using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _353504_Стецурин_8.Interfases;

namespace _353504_Стецурин_8.Classes
{
    public class JobType : IJobType
    {
        private string _name;
        private double _basePay;
        private double _bonus;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double BasePay
        {
            get { return _basePay; }
            set { _basePay = value; }
        }
        public double Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }
    }
}
