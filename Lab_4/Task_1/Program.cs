using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_4
{
    class Program
    {
        static void Main()
        {
            OtdelKadrov otdelKadrov = OtdelKadrov.GetInstance();
            Console.WriteLine(otdelKadrov.companyName);
            Console.WriteLine($"Общая выплата по подоходному налогу: {otdelKadrov.TaxPayment()}");
            otdelKadrov.UpHours(10);
            Console.WriteLine($"Общая выплата по подоходному налогу после повышения нормы выработки: {otdelKadrov.TaxPayment()}");
            otdelKadrov.DownHours(20);
            Console.WriteLine($"Общая выплата по подоходному налогу после понижения нормы выработки: {otdelKadrov.TaxPayment()}");
        }
    }
}
