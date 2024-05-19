using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_3
{

    internal class Program
    {
        static void Main()
        {
            bool menu;
            do
            {
                menu = false;
                Console.Write("Введите вещественное число x: ");
                String xstr;
                xstr = Console.ReadLine();
                if (double.TryParse(xstr, out double x))
                {
                    Console.Write("Значение выражения x^2/2+x^4/4+x^6/6 = ");
                    Func func = new Func();
                    double answer = func.Ans(2, x) + func.Ans(4, x) + func.Ans(6, x);
                    Console.WriteLine(answer);

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
