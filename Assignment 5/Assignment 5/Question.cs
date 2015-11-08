using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Question
    {
        

        public static int AskForInteger(string prompt)
        {  
            System.Console.Write("  "+prompt);
            return int.Parse(System.Console.ReadLine());
        }

        public static string SceenQuestion(string question)
        {
            System.Console.Write("   "+question);
            return System.Console.ReadLine();
        }
    }
}
