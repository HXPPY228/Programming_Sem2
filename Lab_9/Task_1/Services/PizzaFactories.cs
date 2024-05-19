using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_9
{
    // Конкретные фабрики для разных размеров пиццы
    public class BigPizzaFactory : IPizzaFactory
    {
        public Pizza CreatePizza()
        {
            return new BigPizza();
        }
    }

    public class MediumPizzaFactory : IPizzaFactory
    {
        public Pizza CreatePizza()
        {
            return new MediumPizza();
        }
    }

    public class SmallPizzaFactory : IPizzaFactory
    {
        public Pizza CreatePizza()
        {
            return new SmallPizza();
        }
    }
}
