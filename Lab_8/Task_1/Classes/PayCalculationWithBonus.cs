using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _353504_Стецурин_8.Interfases;

namespace _353504_Стецурин_8.Classes
{
    class PayCalculationWithBonus : IPayCalculator
    {
        public double CalculateAveragePay(List<IJobType> jobTypes)
        {
            double totalPay = 0;
            foreach (IJobType jobType in jobTypes)
            {
                totalPay += jobType.BasePay + jobType.BasePay * jobType.Bonus / 100;
            }
            return totalPay / jobTypes.Count;
        }
    }
}
