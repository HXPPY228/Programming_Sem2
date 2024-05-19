using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_2_2
{
    internal class Program
    {
        static public readonly int sozdal;
        static Program() { 
        sozdal = 1;
        }
        static void Main()
        {
            Console.WriteLine(sozdal);
            bool menu;
            do 
            {
                menu = false;
                Console.WriteLine("Вариант 10 (26).\nЛежит ли точка в заштрихованной области?\nВведите координаты точки на плоскости: ");
                string strx, stry;
                strx=Console.ReadLine();
                stry=Console.ReadLine();
                if (double.TryParse(strx, out double num1) && double.TryParse(stry, out double num2))
                {
                    Console.WriteLine("");
                    double x, y;
                    x = Convert.ToDouble(strx);
                    y = Convert.ToDouble(stry);
                    int otvet;
                    if (y < 12 && y > Math.Abs(x))
                        otvet = 1;
                    else if (y == 12 && Math.Abs(x) <= 12)
                        otvet = 2;
                    else if (Math.Abs(x) == y && y <= 12)
                        otvet = 2;
                    else
                        otvet = 0;
                    switch (otvet)
                    {
                        case 1:
                            Console.WriteLine("Да.");
                            break;
                        case 2:
                            Console.WriteLine("На границе.");
                            break;
                        case 0:
                            Console.WriteLine("Нет.");
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("Продолжить(1) или Закончить(2)\n");
                    string menustr = Console.ReadLine();
                    if (menustr == "1")
                        menu = true;
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите корректные целочисленные значения.");
                    menu = true;
                }

            } while (menu);
        }
    }
}
