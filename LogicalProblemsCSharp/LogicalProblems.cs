using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblemsCSharp
{
    public class LogicalProblems
    {
        //UC1 - Fibonacci Series
        public int FibonacciSeries(int number)
        {
            int firstNum = 0, secondNum = 1, nextNum = 0;

            Console.Write("The Fibonacci series is : " + firstNum + " " + secondNum);

            for (int i = 2; i < number; i++)
            {
                nextNum = firstNum + secondNum;
                Console.Write(" " + nextNum);
                firstNum = secondNum;
                secondNum = nextNum;
            }
            return nextNum;
        }

        //UC2 - Perfect Number
        public bool PerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                //Checking perfectly divisible numbers
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == number)
            {
                Console.WriteLine(number + " is a perfect number");
                return true;
            }
            else
            {
                Console.WriteLine(number + " is NOT a perfect number");
                return false;
            }
        }

        //UC3 - Prime Number
        public bool PrimeNumber(int number)
        {
            bool isPrime = true;

            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine(number + " is a Prime number");
                return true;
            }
            else { 
                Console.WriteLine(number + " is not a Prime number");
                return false;
            }
        }

        //UC4 - Reverse Number
        public int ReverseNumber(int number)
        {    
            Console.WriteLine("The original number is " + number);

            int reverse = 0;
            while (number != 0)
            {
                int remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }
            Console.WriteLine("The reversed number is " + reverse);
            return reverse;
        }

        //Stopwatch
        public int Stopwatch()
        {
            Console.Write("Enter the start time: ");
            string startInput = Console.ReadLine();
            DateTime startTime = DateTime.Now;
            Console.WriteLine(startTime.ToString());

            Console.Write("Enter the end time: ");
            string endInput = Console.ReadLine();
            DateTime endTime = DateTime.Now;
            Console.WriteLine(endTime.ToString());

            Console.WriteLine();
            TimeSpan elapsedTime = endTime - startTime;
            Console.WriteLine("The elapsed time is " + elapsedTime.TotalSeconds + " seconds");
            return (int)elapsedTime.TotalSeconds;
        }
    }
}
