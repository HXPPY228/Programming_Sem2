using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_9
{
    // Конкретные классы для разных размеров пиццы
    public class BigPizza : Pizza
    {
        public override void GetInfo()
        {
            Bake($"{DoughType} тесто. Большой размер.");
        }
    }

    public class MediumPizza : Pizza
    {
        public override void GetInfo()
        {
            Bake($"{DoughType} тесто. Средний размер.");
        }
    }

    public class SmallPizza : Pizza
    {
        public override void GetInfo()
        {
            Bake($"{DoughType} тесто. Маленький размер.");
        }
    }
}
