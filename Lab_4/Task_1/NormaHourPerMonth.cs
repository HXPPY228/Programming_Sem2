using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_4
{
    public class NormaHourPerMonth
    {
        public int hourPerMonth { get; set; }
        public NormaHourPerMonth(int hourPerMonth)
        {
            this.hourPerMonth = hourPerMonth;
        }
        public NormaHourPerMonth(double hourPerMonth)
        {
            this.hourPerMonth = (int)hourPerMonth;
        }
        public void UpHourPerMonth(int a)
        {
            hourPerMonth += a;
        }
        public void DownHourPerMonth(int a)
        {
            hourPerMonth -= a;
        }
    }
}
