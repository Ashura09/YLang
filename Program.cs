using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace YLang
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Load a file, please.");
            Console.WriteLine("Type the name of a file relative to the program's folder (with extension).\n");

            string ylnpath = Console.ReadLine();

            try
            {
                YLN ylninterpreter = new YLN();
                ylninterpreter.ReadYLN(ylnpath);
            }
            catch
            {
                Console.WriteLine("Error while executing: " + ylnpath);
            }
            System.Console.WriteLine("Press any key...");
            System.Console.ReadKey();
        }
    }
}
