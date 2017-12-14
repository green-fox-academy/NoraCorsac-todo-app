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
                if (args.Length > 0)
                {
                    print.PrintText();
                }
                else
                {
                    Console.WriteLine("No todos for today! :)");
                }
            }
            else if (args.Contains("-a"))
            {
                if (args.Length == 1)
                {
                    print.Error();
                }
                else
                {
                    Console.WriteLine("Unable to add: no task provided");
                }
            }
            else if (args.Contains("-r"))
            {
                if (args.Length == 1)
                {
                    print.ErrorIndex();
                }
                else
                {
                    fh.RemoveLines(Int32.Parse(args[1]));
                }
            }
            else if (args.Contains("-c"))
            {

            }
           
        }
    }
}
