using System;
using System.Linq;

namespace Factory
{
    public class Factory
    {
        private int CurrentDay { get; set; }
        private WorkersCollection Workers { get; set; } = new WorkersCollection();
        public IWorker this[int index]
        {
            get
            {
                if (Workers.Any(x => x.Key == index))
                    return Workers.FirstOrDefault(x => x.Key == index).Value;
                else
                    return null;
            }
        }
        public Factory(params IWorker[] workers)
        {
            foreach (var worker in workers)
            {
                Workers.AddWorker(worker);
            }
        }
        public void Work(int daysCount)
        {
            for (int i = 0; i < daysCount; i++)
            {
                Work();
            }
        }
        public void Work()
        {
            Random r = new Random();
            foreach (var worker in Workers)
            {
                worker.Value.Work(r.Next(0, 10));
            }
            CurrentDay++;
            if (CurrentDay % 15 == 0)
            {
                GiveSalary();
            }
            else if (CurrentDay % 30==0)
            {
                GiveSalary();
                CurrentDay = 0;
            }
        }
        public void GiveSalary()
        {
            foreach (var w in Workers)
            {
                Console.WriteLine(w.Value.CalculateSalary());
                w.Value.Reset();
            }
        }
        public int AddWorker(IWorker worker) => Workers.AddWorker(worker);
        public void RemoveWorker(IWorker worker) => Workers.RemoveWorker(worker);
    }
}
