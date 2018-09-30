using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._02._ReverseNumbersWithAStack
{
    public class ReverseNumbersWithAStack
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            Stack<int> stackOfNumbers = new Stack<int>(numbers);

            Console.WriteLine(String.Join(" ", stackOfNumbers));
        }
    }
}