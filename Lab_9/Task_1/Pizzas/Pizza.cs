using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_9
{
    // Абстрактный класс для пиццы
    public abstract class Pizza
    {
        public string? Name { get; set; }
        public DoughType DoughType { get; set; }
        public IAddition Addition { get; set; }

        protected void Bake(string message)
        {
            Console.WriteLine($"Пицца {Name}: {message}");
        }

        public abstract void GetInfo();
        public void UseAdd()
        {
            Addition.AddAddition();
            Console.WriteLine("");
        }
    }
}
