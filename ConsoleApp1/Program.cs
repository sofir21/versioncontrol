﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is a comment.
// Riley Procopio

//This is a comment - Josh

//Sofia Rivas

// Gian Aponte

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RollDice());
            Console.WriteLine();
            Console.WriteLine(FixCase());
            Console.WriteLine();
            LargestOfThree();
            Console.WriteLine();
            IsEvenOrOdd();
            Console.ReadLine();
        }

        /// <summary>
        /// asks user for sentence,
        /// returns string with first letter capitalized
        /// sofia rivas
        /// </summary>
        /// <returns></returns>
        public static string FixCase()
        {
            Console.WriteLine("Provide the string youd like to capitalize:");
            string input = Console.ReadLine();
            return input.First().ToString().ToUpper() + input.Substring(1).ToLower();

        }

        /// <summary>
        /// Rolls a set of die
        /// </summary>
        /// <returns></returns>
        public static int RollDice()
        {
            int totalSum = 0;
            Random rng = new Random();
            for(int i = 0; i < 6; i++)
            {
                //Using "21" since the outer boundary is exclusive
                int dieRoll = rng.Next(1, 21);
                totalSum = totalSum + dieRoll;
            }

            return totalSum;
        }

        // Asks the user for three numbers and finds the highest of the three
        public static void LargestOfThree() 
        {
            int highestNum;
            int currentNum;

            Console.Write("Welcome to the Largest Of Three! Enter three numbers!");

            Console.Write("1st Number: ");
            currentNum = int.Parse(Console.ReadLine());
            highestNum = currentNum;

            Console.Write("2nd Number: ");
            currentNum = int.Parse(Console.ReadLine());
            if (currentNum > highestNum)
            {
                highestNum = currentNum;
            }

            Console.Write("3rd Number: ");
            currentNum = int.Parse(Console.ReadLine());
            if (currentNum > highestNum)
            {
                highestNum = currentNum;
            }

            Console.WriteLine("The highest number was " + highestNum + "!");
        }

        // Ask the user for a number and tell them whether it's odd or even
        public static void IsEvenOrOdd()
        {
            int input;

            Console.WriteLine("Enter a number: ");
            input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }

    }
}
