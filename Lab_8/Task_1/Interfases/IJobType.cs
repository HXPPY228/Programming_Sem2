using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_8.Interfases
{
    interface IJobType
    {
        string Name { get; set; }
        double BasePay { get; set; }
        double Bonus { get; set; }
    }
}
