using Example7._2._3;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Example7._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLogs();
            Console.ReadKey();
        }

        private static void WriteLogs()
        {
            int logFilesAmount = 10;
            Thread[] threads = new Thread[logFilesAmount];
            Console.WriteLine("Starting writer threads...");
            for (int i=0; i<logFilesAmount; i++)
            {
                var logManager = new LogManager($"log-{i + 1}.txt");
                threads[i] = new Thread(logManager.Generate);
                threads[i].Start();
            }

            for(int i=0; i<logFilesAmount; i++)
            {
                threads[i].Join();
            }
            Console.WriteLine("All writer threads finished");
        }

        private static void WriteLogs2()
        {
            int logFilesAmount = 10;

            for (int i = 0; i < logFilesAmount; i++)
            {
                var logManager = new LogManager($"log-{i + 1}.txt");
                ThreadPool.QueueUserWorkItem(new WaitCallback((o) => { logManager.Generate(); }));
            }
            Console.WriteLine("Files written");
        }

        private static void writeFiles3()
        {
            int tasksAmount = 10;
            Task[] tasks = new Task[tasksAmount];

            Console.WriteLine("Writing tasks started");
            for (int i = 0; i < tasksAmount; i++)
            {
                string fileName = $"log-{i + 1}.txt";
                int id = i + 1;
                tasks[i] = Task.Run(() =>
                {
                    Console.WriteLine($"Task {id} running on thread: {Thread.CurrentThread.ManagedThreadId} / writing file {fileName}");
                    var generator = new ReportGenerator(fileName);
                    generator.Generate();
                });
            }
            Task.WaitAll(tasks);
            Console.WriteLine("Writing tasks finished");
        }
    }
}
