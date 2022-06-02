using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Example7._2._1
{
    public class LogManager
    {
        public string FileName;

        public LogManager(string fileName)
        {
            FileName = fileName;
        }

        public void Generate()
        {
            using (StreamWriter writer = new StreamWriter(FileName))
            {
                for(int i=0; i<10000; i++)
                {
                    writer.WriteLine($"Line {i + 1}");
                }
            }
        }
    }
}
