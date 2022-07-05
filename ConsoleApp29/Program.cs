using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("жора", 16, 2);
            Worker worker2 = new Worker("петя", 32, 10);
            Worker worker3 = new Worker("ваня", 12);
            Worker worker4 = new Worker("витя", 50, 24);
            Worker worker5 = new Worker("потап", 18, 1);
            List<Worker> workers = new List<Worker>() { worker1, worker2 , worker3 , worker4 , worker5};

            Worker.PrintInfo(workers);
            workers.Sort(new Worker.SortClass(Worker.SortClass.ESortMetod.Age));
            Worker.PrintInfo(workers);
            workers.Sort(new Worker.SortClass(Worker.SortClass.ESortMetod.Working));
            Worker.PrintInfo(workers);
            Console.ReadKey();
        }
    }
}
