using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _353504_Стецурин_8.Interfases;

namespace _353504_Стецурин_8.Classes
{
    class PayrollDepartment
    {
        private List<IJobType> _jobTypes = new List<IJobType>();
        private IPayCalculator _payCalculator;

        public PayrollDepartment(IPayCalculator payCalculator)
        {
            _payCalculator = payCalculator;
        }

        public void AddJobType(IJobType jobType)
        {
            _jobTypes.Add(jobType);
        }
        public double CalculateAveragePay()
        {
            return _payCalculator.CalculateAveragePay(_jobTypes);
        }
    }
}
