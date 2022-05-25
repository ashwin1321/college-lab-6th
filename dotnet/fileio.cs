using System;
using System.IO;

namespace FileIO
{
    class PrintingString
    {
        static FileStream fs;
        static StreamWriter sw;

        static string file_name = "D:\\message.txt";

        public static void WriteToFile(string s)
        {
            fs = new FileStream(file_name, 
                FileMode.Append, FileAccess.Write);

            sw = new StreamWriter(fs);
            sw.WriteLine(s); sw.Flush(); sw.Close();
            fs.Close();
        }

        public static void WriteALlText()
        {
            File.WriteAllText(file_name, "hello");
        }
        
        public static void ReadFromFile()
        {
            if (File.Exists(file_name))
            {
                string[] lines = File.ReadAllLines(file_name);
                foreach (string line in lines)
                    Console.WriteLine(line);
            }
        }

        static void Main(string[] args)
        {
            WriteToFile("This is text 1.....");
            WriteToFile("This is text 2.....");
            WriteToFile("This is text 3.....");

            ReadFromFile();

            Console.ReadKey();
        }
    }
}