using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Luke";
            //string quote = "The man said, \\Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab.";
            //string filename = @"C:\\Users\\Luke";///when see file names use double backslash
            //////OR 
            ////string filename = @"C:\Users\Luke";


            //bool trueOrFalso = name.Contains("u");
            //trueOrFalso = name.EndsWith("u");

            //int length = name.Length;


            ////name = name.ToUpper();
            ////name = name.ToLower();

            //Console.WriteLine(length);
            //Console.ReadLine();


            //string name = "Luke";
            //name = "Joe";


            StringBuilder sb = new StringBuilder();

            sb.Append("my name is Jesse");

            Console.WriteLine(sb);
            Console.ReadLine();



        }
    }
}
