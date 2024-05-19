using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_4
{
    public class OtdelKadrov
    {
        private static OtdelKadrov instance;
        public string companyName { get; set; }
        public int numOfWorkers { get; set; }
        public int paymentHour { get; set; }
        private static double Nalog = 0.13;
        private NormaHourPerMonth normaHour;
        private OtdelKadrov(string name = "", int num = 1, int payment = 1, int norma = 100)
        {
            companyName = name;
            numOfWorkers = num;
            paymentHour = payment;
            normaHour = new NormaHourPerMonth(norma);
        }
        public static OtdelKadrov GetInstance()
        {
            if (instance == null)
            {
                instance = new OtdelKadrov() {companyName = "faaaa"};
            }
            return instance;
        }

        public double TaxPayment()
        {
            return paymentHour * normaHour.hourPerMonth * numOfWorkers * Nalog;
        }

        public void UpHours(int a)
        {
            normaHour.UpHourPerMonth(a);
        }

        public void DownHours(int a)
        {
            normaHour.DownHourPerMonth(a);
        }
    }
}
