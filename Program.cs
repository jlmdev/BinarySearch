using System;
using System.Collections.Generic;


namespace BinarySearch
{
    class Program
    {
        public static int binarySearch(List<int> listOfNumbers, int item)
        {
            var low = 0;
            var high = listOfNumbers.Count - 1;

            while (low <= high)
            {
                decimal mid = (low + high) / 2;
                var guess = listOfNumbers[Decimal.ToInt32(Math.Floor(mid))];
                if (guess == item)
                {
                    return guess;
                }
                if (guess > item)
                {
                    high = Decimal.ToInt32(mid) - 1;
                }
                else
                    low = Decimal.ToInt32(mid) + 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 1, 3, 5, 7, 9 };
            Console.WriteLine(binarySearch(myList, 3));
            Console.WriteLine(binarySearch(myList, 9));
            Console.WriteLine(binarySearch(myList, 6));
        }
    }
}
