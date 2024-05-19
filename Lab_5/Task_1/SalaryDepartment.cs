namespace _353504_Стецурин_5
{
    class SalaryDepartment
    {
        private List<Workers> _workers = new List<Workers>();
        private List<WorkType> _workTypes = new List<WorkType>();
        public void AllWorkers()
        {
            foreach (Workers worker in _workers)
            {
                Console.WriteLine(worker.LastName);
            }
        }
        public void AddWorker(string lastName, string workTypeName, int hours)
        {
            WorkType workType = _workTypes.FirstOrDefault(wt => wt.Name == workTypeName);
            if (workType == null)
            {
                throw new System.Exception("Такой работы не существует!");
            }

            Workers worker = new Workers(lastName, workType, hours);
            _workers.Add(worker);
        }

        public void AddWorkType(string name, int rate)
        {
            WorkType workType = new WorkType(name, rate);
            _workTypes.Add(workType);
        }

        public int GetSalaryByLastName(string lastName)
        {
            Workers worker = _workers.FirstOrDefault(w => w.LastName == lastName);
            if (worker == null)
            {
                return -1;
            }

            return worker.CalculateSalary();
        }

        public int GetTotalSalary()
        {
            return _workers.Sum(w => w.CalculateSalary());
        }
    }
}
