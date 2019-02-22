using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._01._ReverseNumbersWithAStack
{
    public class ReverseNumbersWithAStack
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            Stack<int> stackOfNumbers = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                stackOfNumbers.Push(numbers[i]);
            }

            while (stackOfNumbers.Count > 0)
            {
                Console.Write(stackOfNumbers.Pop() + " ");
            }

            Console.WriteLine();
        }
    }
}