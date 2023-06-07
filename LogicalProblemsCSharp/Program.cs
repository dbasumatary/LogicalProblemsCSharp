namespace LogicalProblemsCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Problems\n");
            LogicalProblems logicalProblems = new LogicalProblems();
            logicalProblems.FibonacciSeries(7);
            logicalProblems.PerfectNumber(29);
            logicalProblems.PrimeNumber(42);
            logicalProblems.ReverseNumber(49);
            logicalProblems.Stopwatch();
        }
    }
}