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
        public void FibonacciSeries()
        {
            int firstNum = 0, secondNum = 1;
            Console.Write("Enter the number up to which to see the Fibonacci series: ");
            string userInput = Console.ReadLine();
            int count = Convert.ToInt32(userInput);

            Console.Write("The Fibonacci series is : " + firstNum + " " + secondNum);

            for (int i = 2; i < count; i++)
            {
                int nextNum = firstNum + secondNum;
                Console.Write(" " + nextNum);
                firstNum = secondNum;
                secondNum = nextNum;
            }
        }
    }
}
