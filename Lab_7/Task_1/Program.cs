namespace _353504_Стецурин_7
{
    class Program
    {
        static void Main()
        {
            Vector v1 = new Vector(1,2,3);
            Vector v2 = new Vector(4,6,8);
            Vector v3 = new Vector();
            Console.WriteLine($"Вектор 1 = {v1}");
            Console.WriteLine($"Вектор 2 = {v2}");
            Console.WriteLine($"Вектор 3 = {v3}");
            v3.A = 5;
            Console.WriteLine("Вектор 3 = "+v3.ToString());
            Console.WriteLine($"Вектор 1 + Вектор 2 = {v1 + v2}");
            Console.WriteLine($"Вектор 1 - Вектор 2 = {v1 - v2}");
            Console.WriteLine($"Вектор 1 * 2 = {v1 * 2}");
            Console.WriteLine($"Вектор 2 / 2 = {v2 / 2}");
            Console.WriteLine($"Вектор 1 == Вектор 2: {v1 == v2}");
            Console.WriteLine($"Вектор 2 == Вектор 2: {v2 == v2}");
            Console.WriteLine($"Вектор 1 != Вектор 2: {v1 != v2}");
            Console.WriteLine($"Вектор 1 < Вектор 2: {v1 < v2}");
            Console.WriteLine($"Вектор 1 > Вектор 2: {v1 > v2}");
            Console.WriteLine($"Вектор 1 ++ = {v1++}");
            Console.WriteLine($"++ Вектор 1 = {++v1}");
            Console.WriteLine($"Вектор 2 -- = {v2--}");
            Console.WriteLine($"-- Вектор 2 = {--v2}");
            Console.WriteLine($"Вектор 3 is bool: {(bool)v3}");
            v3.A = 0;
            Console.WriteLine($"Вектор 3 is bool: {(bool)v3}");
            Console.WriteLine($"(double)v1 = {(double)v1}");

            Vector v4 = (Vector)5;
            Console.WriteLine($"Вектор 4 = {v4}");
            Console.WriteLine($"{v4[0]}, {v4[1]}, {v4[2]}");
        }
    }
}
