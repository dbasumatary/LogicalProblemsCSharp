namespace LogicalProblemsCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Problems\n");
            LogicalProblems logicalProblems = new LogicalProblems();
            logicalProblems.FibonacciSeries();
            logicalProblems.PerfectNumber();
        }
    }
}