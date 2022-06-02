using System;

namespace Example7._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerManager serverManager = new ServerManager();
            //serverManager.PrintOfflineAsianServersWithLotsOfRam();
            //serverManager.PrintOfflineAsianServersWithLotsOfRamLinq();
            serverManager.PrintOfflineServers();
            Console.ReadKey();
        }
    }
}
