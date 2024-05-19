
namespace _353504_Стецурин_9
{
    class Program
    {
        static void Main()
        {
            // Создаем фабрики для разных размеров пиццы
            IPizzaFactory bigPizzaFactory = new BigPizzaFactory();
            IPizzaFactory mediumPizzaFactory = new MediumPizzaFactory();
            IPizzaFactory smallPizzaFactory = new SmallPizzaFactory();

            var pizzasex = new List<Pizza>();

            // Создаем пиццу с добавками
            Pizza bigPizza = bigPizzaFactory.CreatePizza();
            bigPizza.Name = "Острая";
            bigPizza.DoughType = DoughType.Толстое;
            bigPizza.Addition = new Spicy();
            

            Pizza mediumPizza = mediumPizzaFactory.CreatePizza();
            mediumPizza.Name = "Мясная";
            mediumPizza.DoughType = DoughType.Закрытое;
            mediumPizza.Addition = new ExtraMeat();
            

            Pizza smallPizza = smallPizzaFactory.CreatePizza();
            smallPizza.Name = "4 Сыра";
            smallPizza.DoughType = DoughType.Тонкое;
            smallPizza.Addition = new BlueCheese();

            pizzasex.Add(bigPizza);
            pizzasex.Add(mediumPizza);
            pizzasex.Add(smallPizza);

            foreach (Pizza item in pizzasex)
            {
                item.GetInfo();
                item.UseAdd();
            }

        }
    }

}
