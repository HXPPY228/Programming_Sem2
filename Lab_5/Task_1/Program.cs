namespace _353504_Стецурин_5
{
    internal class Program
    {
        static void Main()
        {
            SalaryDepartment salaryDepartment = new SalaryDepartment();

            salaryDepartment.AddWorkType("Грузчик", 800);
            salaryDepartment.AddWorkType("Водитель", 1000);
            salaryDepartment.AddWorkType("Строитель", 1200);

            salaryDepartment.AddWorker("Иванов", "Грузчик", 160);
            salaryDepartment.AddWorker("Петров", "Водитель", 140);
            salaryDepartment.AddWorker("Сидоров", "Строитель", 120);
            salaryDepartment.AddWorker("Егоров", "Грузчик", 100);

            Console.WriteLine("В базе данных имеются следующие рабочие: ");
            salaryDepartment.AllWorkers();
            string lastName;
            bool repeat;
            int salary;
            do
            {
                Console.Write("Введите фамилию работника: ");
                lastName = Console.ReadLine();
                salary = salaryDepartment.GetSalaryByLastName(lastName);
                if (salary == -1)
                {
                    Console.WriteLine("Работник не найден");
                    repeat = true;
                }
                else repeat = false;
            } while (repeat);

            Console.WriteLine($"Зарплата для работника с фамилией {lastName}: {salary}");

            int totalSalary = salaryDepartment.GetTotalSalary();
            Console.WriteLine($"Общая сумма выплат: {totalSalary}");
        }
    }
}
