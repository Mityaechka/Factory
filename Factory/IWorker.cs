namespace Factory
{
    public interface IWorker
    {
        decimal CalculateSalary();
        void Work(int workCount);
        void Reset();
    }
}
