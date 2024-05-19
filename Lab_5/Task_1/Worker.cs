using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_5
{
    class Workers
    {
        private string _lastName;
        private WorkType _workType;
        private int _hours;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public WorkType WorkType
        {
            get { return _workType; }
            set { _workType = value; }
        }
        public int Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }
        public Workers(string lastName, WorkType workType, int hours)
        {
            LastName = lastName;
            WorkType = workType;
            Hours = hours;
        }

        public int CalculateSalary()
        {
            return WorkType.Payment * Hours;
        }
    }
}
