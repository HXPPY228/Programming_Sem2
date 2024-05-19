using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_9
{
    // Конкретные классы для добавок
    public class Spicy : IAddition
    {
        public void AddAddition()
        {
            Console.WriteLine("Добавляем острый перец");
        }
    }

    public class BlueCheese : IAddition
    {
        public void AddAddition()
        {
            Console.WriteLine("Добавляем синий сыр");
        }
    }

    public class ExtraMeat : IAddition
    {
        public void AddAddition()
        {
            Console.WriteLine("Добавляем больше мяса");
        }
    }

}
