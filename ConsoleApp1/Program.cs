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
            Console.WriteLine("Hello World!");

            Console.WriteLine(RollDice());

            static int RollDice()
            {
                int totalSum = 0;
                Random rng = new Random();
                for(int i = 0; i < 5; i++)
                {
                    int dieRoll = rng.Next(1, 21);
                    totalSum = totalSum + dieRoll;
                }

                return totalSum;
            }
        }
    }
}
