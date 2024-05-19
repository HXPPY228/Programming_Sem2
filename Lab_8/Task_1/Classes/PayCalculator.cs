using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _353504_Стецурин_8.Interfases;

namespace _353504_Стецурин_8.Classes
{
    class PayCalculator : IPayCalculator
    {
        private IPayCalculator _strategy;

        public PayCalculator(IPayCalculator strategy)
        {
            _strategy = strategy;
        }

        public double CalculateAveragePay(List<IJobType> jobTypes)
        {
            return _strategy.CalculateAveragePay(jobTypes);
        }
    }
}
