using System;
using System.IO;

namespace ArchitectureTesting.Patterns.Decorator
{
    /***
     * This class will act as the base so we can wrap it for further functionality later
     ***/
    public class FileWriter : IWriter
    {
        public void Write(string path, string name) 
        {
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            using var writer = new StreamWriter(path);
            Console.WriteLine("Writing to file...");
            writer.WriteLine($"My name is {name}");
        }
    }
}
