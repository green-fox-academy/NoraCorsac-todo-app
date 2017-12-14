using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToDo
{
    public class FileHandler
    {
        public void Files()
        {
            
        }
        static void WriteFile (string Filename)
        {
            File.WriteAllText(Filename, "Walk the dog");
        }
        static void ReadFile(string Filename)
        {
            Console.WriteLine(File.ReadAllText(Filename));
        }
        public void RemoveLines(int number)
        {
            var file = new List<string>(File.ReadAllLines("TasksInText.txt"));
            file.RemoveAt(number);
            File.WriteAllLines("TasksInText.txt", file.ToArray());
        }
    }
}
