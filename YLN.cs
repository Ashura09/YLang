using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YLang
{
    class YLN
    {
        public void ReadYLN(string path)
        {
            path = AppDomain.CurrentDomain.BaseDirectory + path;
            // Console.WriteLine(path);
            Console.WriteLine("");
            string[] lines;
            lines = File.ReadAllLines(path);

            #region All of the commands
            /// <summary>
            /// Interpreter of YLN code
            /// </summary>

            string yes = "yes";
            string no = "no";
            string input = "";
            int Yi = 0; // for (int i = 0) var

            foreach (string line in lines)
            {
                if (line.StartsWith("append"))
                {
                    string appendpath = line.Replace("append ", "");
                    YLN appendinterpreter = new YLN();
                    appendinterpreter.ReadYLN(appendpath);
                }
                if (line.StartsWith("say"))
                {
                    string parser = line.Replace("say ", "");
                    if (parser.StartsWith("var: "))
                    {
                        string variable = parser.Replace("var: ", "");
                        if (variable == "input()")
                        {
                            Console.WriteLine(input);
                            parser = "";
                        }
                    }
                    if (parser != "")
                    {                      
                        Console.WriteLine(parser);
                    }
                }
                if (line.StartsWith("out")) return;
                if (line.StartsWith("input()"))
                {
                    input = Console.ReadLine();
                }
                if (line.StartsWith("newl")) Console.WriteLine("");
                if (line.StartsWith("sum"))
                {
                    string expression = line.Replace("sum ", "");
                    string[] numbers = expression.Split('+');
                    Console.WriteLine(float.Parse(numbers[0]) + float.Parse(numbers[1]));
                }
                if (line.StartsWith("sub"))
                {
                    string expression = line.Replace("sub ", "");
                    string[] numbers = expression.Split('-');
                    Console.WriteLine(float.Parse(numbers[0]) - float.Parse(numbers[1]));
                }
                if (line.StartsWith("div"))
                {
                    string expression = line.Replace("div ", "");
                    string[] numbers = expression.Split('/');
                    Console.WriteLine(float.Parse(numbers[0]) / float.Parse(numbers[1]));
                }
                if (line.StartsWith("mul"))
                {
                    string expression = line.Replace("mul ", "");
                    string[] numbers = expression.Split('*');
                    Console.WriteLine(float.Parse(numbers[0]) * float.Parse(numbers[1]));
                }
                if (line.StartsWith("var"))
                {
                    string[] lineCon = line.Split(' ');
                    string variable = lineCon[1];
                    Console.WriteLine(variable.ToString());
                }
            }
            #endregion
            Console.WriteLine("");
        }
    }
}
