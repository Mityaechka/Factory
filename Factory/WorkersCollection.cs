using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Factory
{
    public class WorkersCollection : IEnumerable<KeyValuePair<int, IWorker>>
    {
        private int Index { get; set; } = 0;
        private Dictionary<int, IWorker> Workers { get; set; } = new Dictionary<int, IWorker>();
        public void RemoveWorker(IWorker worker)
        {
            var w = Workers.FirstOrDefault(x => x.Value == worker);
            if (w.Value != null)
                Workers.Remove(w.Key);
        }
        public int AddWorker(IWorker worker)
        {
            var index = Index++;
            Workers.Add(index, worker);
            return index;
        }
        public IEnumerator<KeyValuePair<int, IWorker>> GetEnumerator()
        {
            return Workers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Workers.GetEnumerator();
        }
    }
}
