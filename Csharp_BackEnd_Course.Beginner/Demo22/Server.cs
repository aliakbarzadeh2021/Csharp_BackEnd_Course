using System;
using System.Collections.Generic;
using System.Text;

namespace Example7._3._1
{
    public class Server
    {
        public string Name { get; set; }
        public int Ram { get; set; }
        public bool Status { get; set; }
        public string Location { get; set; }

        public override string ToString() => $"{Name} / {Ram} / {Location}";
    }
}
