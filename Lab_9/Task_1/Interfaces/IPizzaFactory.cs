using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_9
{
    // Абстрактная фабрика для создания пиццы
    public interface IPizzaFactory
    {
        Pizza CreatePizza();
    }
}
