using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToDo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fh = new FileHandler();
            var print = new Print();
            

            if (args.Length == 0)
            {
                print.PrintUsage();
            }
            else if (args.Contains("-l"))
            {
                fh.AddLines();
            }
            //Console.ReadLine();
        }
    }
}
