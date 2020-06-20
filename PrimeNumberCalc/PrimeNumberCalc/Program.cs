using System;
using System.Collections.Generic;

namespace PrimeNumberCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            bool loopCtrl = true;

            while (loopCtrl)
            {
                while (true)
                {


                    Console.WriteLine("Enter a number! If you would like to stop the process, just type finish.");
                    int userInput = int.Parse(Console.ReadLine());

                    if (userInput.GetType() == typeof(int))
                    {
                        numbers.Add(userInput);
                    }
                    else if (true)
                    {
                        loopCtrl = false;
                    }
                    else
                    {
                        Console.WriteLine("Please, enter a valid number or the finish command.");
                    }

                    break;

                }
                break;
            }
            Console.WriteLine(numbers[0]);

                
            }
        }

}

