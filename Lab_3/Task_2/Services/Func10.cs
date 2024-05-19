using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_3_2.Services
{
    internal static class Func10
    {
        public static readonly int abc = 10;
        public void Ans(double z) 
        {
            double y, x, e=2.71;
            if (z >=1) 
            {
                Console.WriteLine("Z >= 1, считается ветка 1...");
                x = z-1;
            } 
            else
            {
                Console.WriteLine("Z < 1, считается ветка 2...");
                x = z * z + 1;
            }
            if (x == 0)
            {
                Console.WriteLine("ОШИБКА: НА НОЛЬ ДЕЛИТЬ НЕЛЬЗЯ!");
                return;
            }
            y = (Math.Pow(e, Math.Sin(x) * Math.Sin(x) * Math.Sin(x)) + Math.Log(x + 1)) / Math.Sqrt(x);
            Console.Write("Ответ: ");
            Console.WriteLine(y);
        }
    }
}
