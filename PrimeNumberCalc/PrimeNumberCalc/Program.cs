using System;
using System.Collections.Generic;

namespace PrimeNumberCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var isFinished = false;
            string userInput;
            int userInputAsInt;
            int primeNumLowest;
            int primeNumHighest;
            var primeNumbers = new List<int>();
            int i = 0;


            while (!isFinished)
            {
                Console.WriteLine("Enter a number! If you would like to stop the process, just type finish.");
                userInput = Console.ReadLine();
                Console.WriteLine();

                if (userInput.ToLower() == "finish")
                    isFinished = true;
                else if (Int32.TryParse(userInput, out userInputAsInt))
                    numbers.Add(userInputAsInt);
                else
                    Console.WriteLine("Please enter a number or the word finish!");
            }

            foreach (var number in numbers)
            {
                if (number != number / 2)
                {
                    primeNumbers.Add(number);
                }
            }

            foreach (var number in primeNumbers)
            {
                Console.WriteLine(number + " ");
            }

        }
    }

}