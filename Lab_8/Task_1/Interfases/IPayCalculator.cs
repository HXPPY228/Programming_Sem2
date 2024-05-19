using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_8.Interfases
{
    interface IPayCalculator
    {
        double CalculateAveragePay(List<IJobType> jobTypes);
    }
}
