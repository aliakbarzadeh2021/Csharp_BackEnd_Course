using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Example7._2._3
{
    public class ReportGenerator
    {
        public string FileName;

        public ReportGenerator(string fileName)
        {
            FileName = fileName;
        }

        public void Generate()
        {
            FileStream stream = File.OpenWrite(FileName);
            using (StreamWriter writer = new StreamWriter(stream))
            {
                for (int i = 0; i < 100000; i++)
                {
                    writer.WriteLine($"Line {i}");
                }
            }
        }
    }
}
