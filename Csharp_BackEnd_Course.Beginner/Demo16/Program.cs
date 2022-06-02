using System;
using System.IO;

namespace Example3._11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            readFile();
            Console.ReadKey();
        }

        private static void readFile()
        {
            StreamReader reader = new StreamReader("test-file.txt");
            string contents = reader.ReadToEnd();
            Console.WriteLine("File contents:");
            Console.WriteLine(contents);
            reader.Close();
        }

        private static void readFile2()
        {
            using (StreamReader reader = new StreamReader("test-file.txt"))
            {
                string contents = reader.ReadToEnd();
                Console.WriteLine("File contents:");
                Console.WriteLine(contents);
            }
        }

        private async static void readFile3()
        {
            using (StreamReader reader = new StreamReader("test-file.txt"))
            {
                string contents = await reader.ReadToEndAsync();
                Console.WriteLine("File contents:");
                Console.WriteLine(contents);
            }
        }

        private static void readFile4()
        {
            try
            {
                using (StreamReader reader = new StreamReader("test-file.txt"))
                {
                    string contents = reader.ReadToEnd();
                    Console.WriteLine("File contents:");
                    Console.WriteLine(contents);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found");
            }
            catch (FileLoadException e)
            {
                Console.WriteLine("File load failed");
            }
            catch (Exception)
            {
                Console.WriteLine("File operation failed");
            }
        }

        private static void writeFile()
        {
            StreamWriter writer = new StreamWriter("test-file.txt", true);
            writer.WriteLine("Visual Studio is the best IDE");
            writer.Close();
            Console.WriteLine("Wrote to file");
        }
    }
}
