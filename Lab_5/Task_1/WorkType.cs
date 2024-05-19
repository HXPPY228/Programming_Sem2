using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_5
{
    class WorkType
    {
        private string _name;
        private int _payment;
        public string Name
        {
            get { return _name; }
            init { _name = value; }
        }
        public int Payment
        {
            get { return _payment; }
            set { _payment = value; }
        }
        public WorkType(string name, int payment)
        {
            Name = name;
            Payment = payment;
        }
    }
}
