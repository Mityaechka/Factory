using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();

            IWorker ded = new Worker("DED", 100);
            IWorker babka = new Worker("BABKA", 78);
            IWorker brigade = new Brigade
            {
                new Worker("Worker 1",100),
                new Worker("Worker 2",150),
                new Worker("Worker 3",200),
            };

            factory.AddWorker(ded);
            factory.AddWorker(babka);
            factory.AddWorker(brigade);

            factory.Work(35);

            var worker = factory[1];
        }
    }
}
