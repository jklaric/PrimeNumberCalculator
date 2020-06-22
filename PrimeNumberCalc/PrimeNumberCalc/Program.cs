using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PrimeNumberCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var isFinished = false;
            string userInput;
            int userInputAsInt;
            int primeNumLowest;
            int primeNumHighest;
            var primeNumbers = new List<int>();
            bool isPrime = true;

            while (!isFinished)
            {
                Console.WriteLine("Enter a number! If you would like to stop the process, just type finish.");
                userInput = Console.ReadLine();
                Console.WriteLine();

                if (userInput.ToLower() == "finish")
                    isFinished = true;
                else if (Int32.TryParse(userInput, out userInputAsInt))
                {
                    if (TestForPrime(userInputAsInt, isPrime) == true)
                    {
                        primeNumbers.Add(userInputAsInt);
                    }
                }
                else
                    Console.WriteLine("Please enter a number or the word finish!");
            }

            Console.WriteLine("If you would like to verify the result, the following is the result of " + primeNumbers.Min() + " raised to the power of " + primeNumbers.Max());

            Console.WriteLine(Math.Pow(primeNumbers.Min(), primeNumbers.Max()));

        }

        static bool TestForPrime(int userInputAsInt, bool isPrime)
        {


            if (userInputAsInt % 2 == 0)
            {
                isPrime = false;
            }
            if (userInputAsInt % 3 == 0)
            {
                isPrime = false;
            }

            if (userInputAsInt % 5 == 0)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < userInputAsInt / 2; i++)
                {
                    if (userInputAsInt % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }

            return isPrime;
        }

    }

}





