namespace Factory
{
    public class Worker : IWorker
    {
        public string FIO { get; private set; }
        public decimal Salary { get; private set; }
        public decimal Total { get; private set; }
        public Worker(string fio, decimal salary)
        {
            FIO = fio;
            Salary = salary;
        }
        public decimal CalculateSalary()
        {
            return Total;
        }

        public void Work(int workCount)
        {
            Total += Salary * ((decimal)workCount / 10);
        }

        public void Reset()
        {
            Total = 0;
        }
    }
}
