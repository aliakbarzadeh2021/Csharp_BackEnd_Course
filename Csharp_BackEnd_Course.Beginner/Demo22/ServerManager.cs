using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Example7._3._1
{
    public class ServerManager
    {
        private List<Server> _servers = new List<Server>()
        {
            new Server() { Name = "Server1", Ram = 8, Status = true, Location = "North America" },
            new Server() { Name = "Server2", Ram = 16, Status = true, Location = "Europe" },
            new Server() { Name = "Server3", Ram = 8, Status = false, Location = "Asia" },
            new Server() { Name = "Server4", Ram = 32, Status = true, Location = "Europe" },
            new Server() { Name = "Server5", Ram = 32, Status = false, Location = "Asia" },
            new Server() { Name = "Server6", Ram = 32, Status = false, Location = "Europe" },
            new Server() { Name = "Server7", Ram = 16, Status = true, Location = "North America" },
            new Server() { Name = "Server8", Ram = 8, Status = false, Location = "North America" },
            new Server() { Name = "Server9", Ram = 16, Status = true, Location = "Asia" },
            new Server() { Name = "Server10", Ram = 8, Status = false, Location = "Europe" },
            new Server() { Name = "Server11", Ram = 32, Status = false, Location = "Asia" },
            new Server() { Name = "Server12", Ram = 16, Status = true, Location = "North America" },
            new Server() { Name = "Server13", Ram = 32, Status = false, Location = "Asia" },
            new Server() { Name = "Server14", Ram = 16, Status = true, Location = "Europe" },
        };

        public void PrintOfflineAsianServersWithLotsOfRam()
        {
            foreach (var server in _servers)
            {
                if(server.Location == "Asia" && server.Ram > 16 && !server.Status)
                {
                    Console.WriteLine(server);
                }
            }
        }

        public void PrintOfflineAsianServersWithLotsOfRamLinq()
        {
            var targetServers = from s in _servers
                                where s.Location == "Asia" &&
                                      s.Ram > 16 &&
                                      s.Status == false
                                orderby s.Name descending
                                select s;
            foreach (var server in targetServers)
            {
                Console.WriteLine(server);
            }
        }

        public void PrintOfflineServers()
        {
            var offlineServers = from s in _servers
                                 where s.Status == false
                                 orderby s.Location descending
                                 select s;

            Console.WriteLine($"Number of offline servers: {offlineServers.Count()}");

            _servers.Add(new Server() { Name = "Server15", Ram = 16, Status = false, Location = "Europe" });

            Console.WriteLine($"Number of offline servers: {offlineServers.Count()}");
        }
    }
}
