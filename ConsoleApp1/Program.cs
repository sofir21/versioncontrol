using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is a comment.
// Riley Procopio


//This is a comment - Josh

//Sofia Rivas

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FixCase()) ;
            Console.ReadLine();
        }

        /// <summary>
        /// asks user for sentence,
        /// returns string with first letter capitalized
        /// </summary>
        /// <returns></returns>
        public static string FixCase()
        {
            Console.WriteLine("Provide the string youd like to capitalize:");
            string input = Console.ReadLine();
            return input.First().ToString().ToUpper() + input.Substring(1).ToLower();
        }

    }
}
