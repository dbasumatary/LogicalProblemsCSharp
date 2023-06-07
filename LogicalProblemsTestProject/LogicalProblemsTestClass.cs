using LogicalProblemsCSharp;

namespace LogicalProblemsTestProject
{
    [TestClass]
    public class LogicalProblemsTestClass
    {
        LogicalProblems logicalProblems;

        [TestInitialize]
        public void Setup() { logicalProblems = new LogicalProblems(); }

        [TestMethod]
        [DataRow(3, 1)]
        [DataRow(7, 8)]
        [DataRow(8, 13)]
        [DataRow(5, 3)]
        public void Fibonacci_ForGivenNumber_ReturnsLastFibonacciNumber(int number, int expected)
        {
            int result = logicalProblems.FibonacciSeries(number);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(3, false)]
        [DataRow(28, true)]
        [DataRow(6, true)]
        [DataRow(43, false)]
        public void PerfectNumber_ForGivenNumber_ReturnIfPerfectNumberIsTrueOrFalse(int number, bool expected)
        {
            bool result = logicalProblems.PerfectNumber(number);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(13, true)]
        [DataRow(28, false)]
        [DataRow(41, true)]
        [DataRow(28, false)]
        public void PrimeNumber_ForGivenNumber_ReturnIfPrimeNumberIsTrueOrFalse(int number, bool expected)
        {
            bool result = logicalProblems.PrimeNumber(number);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(34, 43)]
        [DataRow(281, 182)]
        [DataRow(61, 16)]
        [DataRow(4329, 9234)]
        public void ReverseNumber_ForGivenNumber_ReturnTheReverseNumber(int number, int expected)
        {
            int result = logicalProblems.ReverseNumber(number);
            Assert.AreEqual(expected, result);
        }
    }
}