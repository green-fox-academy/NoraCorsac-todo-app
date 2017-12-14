using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToDo
{
    public class Print
    {


        public void PrintUsage()
        {
            Console.WriteLine("Command Line Todo application\n\n" +
                "=============================\n\n" +
                "Command line arguments:\n" +
                " -l   Lists all the tasks\n" +
                " -a   Adds a new task\n" +
                " -r   Removes an task\n" +
                " -c   Completes an task");
        }
    }
}
