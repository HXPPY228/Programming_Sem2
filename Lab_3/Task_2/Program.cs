using _353504_Стецурин_3_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_3_2
{
    internal class Program
    {
        static void Main()
        {
            bool menu;
            do
            {
                menu = false;
                Console.Write("Введите z: ");
                String zstr = Console.ReadLine();
                if (double.TryParse(zstr, out double z))
                {
                    Func10 func10 = new Func10();
                    func10.Ans(z);
                    Console.WriteLine("\nПродолжить(1) или Закончить(2)");
                    string menustr = Console.ReadLine();
                    if (menustr == "1")
                        menu = true;
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("\nПожалуйста, введите корректное вещественное значение.\n");
                    menu = true;
                }
            } while (menu);
        }
    }
}
