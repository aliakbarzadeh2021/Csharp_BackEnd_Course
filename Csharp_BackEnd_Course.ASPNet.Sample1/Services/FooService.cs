using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example5._2._1.Services
{
    public class FooService
    {
        public List<string> GetNames()
        {
            return new List<string>()
            {
                "Bob",
                "Mary",
                "John",
                "Jane"
            };
        }
    }
}
