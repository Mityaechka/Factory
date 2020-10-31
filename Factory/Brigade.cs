using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Factory
{
    public class Brigade : IWorker, IEnumerable<IWorker>
    {
        private List<IWorker> Workers { get; set; } = new List<IWorker>();

        public void Add(IWorker worker)
        {
            Workers.Add(worker);
        }
        public decimal CalculateSalary()
        {
            return Workers.Sum(x => x.CalculateSalary());
        }

        public IEnumerator<IWorker> GetEnumerator()
        {
            return Workers.GetEnumerator();
        }

        public void Reset()
        {
            foreach (var w in Workers)
            {
                w.Reset();
            }
        }

        public void Work(int workCount)
        {
            foreach (var w in Workers)
            {
                w.Work(workCount);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Workers.GetEnumerator();
        }
    }
}
