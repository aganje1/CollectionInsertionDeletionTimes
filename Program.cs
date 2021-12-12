using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        public const int N = 1000000;
        static void Main(string[] args)
        {
            Random rand = new Random();

            LinkedList<int> linkList = new LinkedList<int>();
            var linkedListStopWatch = new System.Diagnostics.Stopwatch();
            linkedListStopWatch.Start();
            for (int i = 0; i < N; i++)
            {
                linkList.AddLast(rand.Next(0, 1001));
            }
            linkedListStopWatch.Stop();

            List<int> list = new List<int>();
            var listStopWatch = new System.Diagnostics.Stopwatch();
            listStopWatch.Start();
            for (int i = 0; i < N; i++)
            {
                list.Add(rand.Next(0, 1001));
            }
            listStopWatch.Stop();

            int[] array = new int[N];
            var arrayStopWatch = new System.Diagnostics.Stopwatch();
            arrayStopWatch.Start();
            for (int i = 0; i < N; i++)
            {
                array[i] = (rand.Next(0, 1001));
            }
            arrayStopWatch.Stop();



            Console.WriteLine($"LinkedList Insertion Time: {linkedListStopWatch.ElapsedMilliseconds} ms.");
            Console.WriteLine($"List Insertion Time: {listStopWatch.ElapsedMilliseconds} ms.");
            Console.WriteLine($"Array Insertion Time: {arrayStopWatch.ElapsedMilliseconds} ms.");
            Console.ReadKey();

            linkedListStopWatch.Start();
            linkList.Clear();
            linkedListStopWatch.Stop();

            listStopWatch.Start();
            list.Clear();
            listStopWatch.Stop();

            Console.WriteLine($"LinkedList Deletion Time: {linkedListStopWatch.ElapsedMilliseconds} ms.");
            Console.WriteLine($"List Deletion Time: {listStopWatch.ElapsedMilliseconds} ms.");
            Console.ReadKey();
        }
    }
}
