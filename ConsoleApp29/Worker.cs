using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Worker
    {
        private string name;
        private int age;
        private int working;
        private int id;
        private static int lastId;
        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Working
        {
            get { return working; }
            set { working = value; }
        }
        public int ID
        {
            get { return id; }
        }
        public Worker(string name, int age, int working)
        {
            this.name = name; this.age = age; this.working = working;
            id = lastId++;
        }
        public Worker(string name, int age) : this(name,age,0) {}
        static Worker()
        {
            lastId = 0;
        }
        public override string ToString()
        {
            return $"#{ID} Name: {Name}, Age: {Age}, W: {Working}";
        }
        public static void PrintInfo(List<Worker> workers)
        {
            foreach (Worker item in workers)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
        }
        public class SortClass : IComparer<Worker>
        {
            public enum ESortMetod
            {
                ID, Age, Working
            }
            public ESortMetod sortMetod;
            public SortClass(ESortMetod sortMetod)
            {
                this.sortMetod = sortMetod;
            }
            public int Compare(Worker x, Worker y)
            {
                int A=0, B=0;
                switch (sortMetod)
                {
                    case ESortMetod.ID:
                        A = x.ID; B = y.ID;
                        break;
                    case ESortMetod.Age:
                        A = x.Age; B = y.Age;
                        break;
                    case ESortMetod.Working:
                        A = x.Working; B = y.Working;
                        break;
                }
                if (A > B) return 1;
                else if (A < B) return -1;
                else return 0;
            }
        }
    }
}
