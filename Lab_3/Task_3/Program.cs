using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _353504_Стецурин_3_3
{
    internal class Program
    {
        static void Main()
        {
            bool menu;
            do
            {
                menu = false;
                Console.WriteLine("Выберите требуемое:\n[1] Определить день недели произвольной даты \n[2] Определить сколько дней пройдет между текущей и произвольной датой? ");
                string выбор = Console.ReadLine();
                switch (выбор)
                {
                    case "1":
                        Console.Write("Введите дату в формате ДД.ММ.ГГГГ: ");
                        string date = Console.ReadLine();
                        DateTime parsedDate;
                        if (DateTime.TryParse(date, out parsedDate))
                        {
                            Console.Write("День недели: ");
                            DayOfWeek dayOfWeek = DateService.GetDayOfWeek(date);
                            Console.WriteLine(dayOfWeek);

                            Console.WriteLine("\nПродолжить(1) или Закончить(2)");
                            string menustr = Console.ReadLine();
                            if (menustr == "1")
                                menu = true;
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Неверный формат даты.");
                            menu = true;
                        }
                        break;
                    case "2":
                        Console.Write("Введите день: ");
                        string day = Console.ReadLine();
                        Console.Write("Введите месяц: ");
                        string month = Console.ReadLine();
                        Console.Write("Введите год: ");
                        string year = Console.ReadLine();
                        int день, месяц, год;
                        DateTime parsedDate1;
                        string date1 = day + "." + month + "." + year;
                        if (int.TryParse(day, out день) && int.TryParse(month, out месяц) && int.TryParse(year, out год) && DateTime.TryParse(date1, out parsedDate1))
                        {
                            int ответ = DateService.GetDaysSpan(день, месяц, год);
                            Console.Write("Кол-во дней между датами: ");
                            Console.WriteLine(ответ);

                            Console.WriteLine("\nПродолжить(1) или Закончить(2)");
                            string menustr = Console.ReadLine();
                            if (menustr == "1")
                                menu = true;
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Неверный формат даты.\n");
                            menu = true;
                        }
                        break;
                    default:
                        Console.WriteLine("Неверный выбор, пожалуйста выберите 1 или 2.\n");
                        menu = true;
                        break;
                }
            } while (menu);
        }
    }
}
