using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WinAppLib.OOD.MutiThread_Jan22
{
    public class TaskExample
    {

        /*
         * Two main stategies for partitioning work among threads
         * a) Data Parallelism - partitions the data between threads (ex: RunAsParallel())
         * b) Task Parallelism - partitions the tasks - each thread perfoms a diferent task
         * 
         * 
         * 
         */
        public void RunTask()
        {
            Task.Run(() =>
            {
                Console.WriteLine("\nMy first task!");
                for (int i = 1; i < 10; i++)
                {
                    var result = i * i;
                    Console.WriteLine($"i={i}, result= {result}");
                }

            });
        }

        public void RunTask2()
        {
           Task task = Task.Run(() =>
           {
                Console.WriteLine("\nMy second task!");
                for (int i = 1; i < 10; i++)
                {
                    Thread.Sleep(100);
                    var result = i * i;
                    Console.WriteLine($"i={i}, result= {result}");
                }
           });
            Console.WriteLine(task.IsCompleted);
            task.Wait(); // wait (block) for the task to finish
        }

        public void RunTask3()
        {
            Task<int> task = Task.Run(() =>
            {
                Console.WriteLine("\nThis task returns an int!!");
                return 3;
            });

            int result = task.Result; // blocks if the task is not already finished
            Console.WriteLine($"task.result = {result}");
        }

        public void RunTask4()
        {
            Task<int> task = Task.Run(() =>
            {
                Console.WriteLine("\nThis task will throw an exceptio!!");
                int i = 10;
                int j = 0;
                return i / j;
            });

            int result = task.Result; // blocks if the task is not already finished
            Console.WriteLine($"task.result = {result}\n");
        }

        public void RunAsParallel()
        {
            var s = "\n" +"The quick brown for fox ran over the hill";
            Console.WriteLine(s);
            var r = s
                .AsParallel().WithDegreeOfParallelism(2)
                .Where(c => !char.IsWhiteSpace(c)) //selecting the characters based on a condiotion
                .AsParallel().WithDegreeOfParallelism(3)
                .Select(c => char.ToUpper(c));  // do an operation on each character

            var result = new string(r.ToArray());
            Console.WriteLine(result);
        }

        public void RunAsParallel2()
        {
            Console.WriteLine("RunAsParallel2");
            var s = "abcthequickbrownfoxranoverthehillxyz";

            s.AsParallel()
                .Select(c => char.ToUpper(c))
                .ForAll(Console.Write);
        }
    }
}
