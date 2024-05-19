using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_2_1
{
    internal class Program
    {
        static void Main()
        {
            bool menu;
            do
            {
                menu = false;
                Console.WriteLine("Вариант 7 (26).");
                Console.WriteLine("Введите двухзначное число: ");

                string str1, nstr1;
                str1 = Console.ReadLine();
                    if (int.TryParse(str1, out int num1) && ((num1 >= -99 && num1 <= -10) || (num1 >= 10 && num1 <= 99)))
                    {
                        Console.WriteLine("");
                        int num11, num12;
                        nstr1 = str1.Replace("-", "");
                        num11 = nstr1[0];
                        num12 = nstr1[1];
                        int otvet;
                        if (num11 == num12)
                            otvet = 1;
                        else
                            otvet = 0;
                        switch (otvet)
                        {
                            case 0:
                                Console.WriteLine("Цифры в числе не одинаковы.");
                                break;
                            case 1:
                                Console.WriteLine("Цифры в числе одинаковы");
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
                        Console.WriteLine("Пожалуйста, введите корректное двухзначное целочисленное значение.\n");
                    menu = true;
                    }
                
            } while (menu);
            
        }
    }
}
