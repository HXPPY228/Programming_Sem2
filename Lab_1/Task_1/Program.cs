using System;

namespace _353504_Стецурин_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа: ");
            string astr = Console.ReadLine();
            string bstr = Console.ReadLine();
            double a = Convert.ToDouble(astr);
            double b = Convert.ToDouble(bstr);
            double c = a / b;
            Console.WriteLine("Частное от деление двух чисел: " + c);
        }
    }
}
