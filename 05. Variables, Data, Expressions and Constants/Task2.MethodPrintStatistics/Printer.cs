namespace Task2.MethodPrintStatistics
{
    using System;
    using System.Linq;

    public class Printer
    {
        public void PrintStatistics(double[] numbers)
        {
            Console.WriteLine("Statistics for {0}: ", numbers);
            double smallestNumber = numbers.Min();
            this.PrintMinNumber(smallestNumber);
            double largestNumber = numbers.Max();
            this.PrintMaxNumber(largestNumber);
            double averageNumber = numbers.Average();
            this.PrintAverageNumber(averageNumber);
        }

        public void PrintMinNumber(double smallestNumber)
        {
            Console.WriteLine("The smallest number is {0}", smallestNumber);
        }

        public void PrintMaxNumber(double largestNumber)
        {
            Console.WriteLine("The largest number is {0}", largestNumber);
        }

        public void PrintAverageNumber(double averageNumber)
        {
            Console.WriteLine("The average number is {0}", averageNumber);
        }
    }
}
