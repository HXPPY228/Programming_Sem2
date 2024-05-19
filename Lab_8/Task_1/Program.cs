using _353504_Стецурин_8.Classes;
using _353504_Стецурин_8.Interfases;

namespace _353504_Стецурин_8
{
    class Program
    {
        static void Main()
        {
            // Создание объектов видов работ
            JobType jobType1 = new JobType { Name = "Тестировщик", BasePay = 1300, Bonus = 10 };
            JobType jobType2 = new JobType { Name = "Программист", BasePay = 1600, Bonus = 7 };
            JobType jobType3 = new JobType { Name = "Дизайнер", BasePay = 1000, Bonus = 7 };

            // Создание объекта отдела расчета зарплаты с использованием стратегии вычисления средней величины оплаты
            PayCalculator allPayCalculator = new PayCalculator(new PayCalculationWithBonus());
            PayrollDepartment payrollDepartment1 = new PayrollDepartment(allPayCalculator);

            // Добавление видов работ в отдел расчета зарплаты
            payrollDepartment1.AddJobType(jobType1);
            payrollDepartment1.AddJobType(jobType2);
            payrollDepartment1.AddJobType(jobType3);

            // Вычисление средней величины оплаты
            double averagePay1 = payrollDepartment1.CalculateAveragePay();
            Console.WriteLine($"Средняя величина оплаты за все виды работ: {averagePay1}");

            // Создание объекта отдела расчета зарплаты с использованием стратегии вычисления средней величины оплаты без учета надбавок
            PayCalculator basePayCalculator = new PayCalculator(new PayCalculationWithoutBonus());
            PayrollDepartment payrollDepartment2 = new PayrollDepartment(basePayCalculator);

            // Добавление видов работ в отдел расчета зарплаты
            payrollDepartment2.AddJobType(jobType1);
            payrollDepartment2.AddJobType(jobType2);
            payrollDepartment2.AddJobType(jobType3);

            // Вычисление средней величины оплаты без учета надбавок
            double averagePay2 = payrollDepartment2.CalculateAveragePay();
            Console.WriteLine($"Средняя величина оплаты без учета надбавок: {averagePay2}");
        }
    }
}
