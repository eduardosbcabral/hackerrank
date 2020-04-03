using HackerRank.Shared;
using System;

namespace HackerRank.Algorithms.Exercises
{
    public class SimpleArraySum : IExercise<int>
    {
        public int SizeOfArray { get; private set; }
        public string Numbers { get; private set; }

        /// <summary>
        /// <para>Simple Array Sum</para>
        /// <para>Order: 2</para>
        /// <para>Description: Given an array of integers, find the sum of its elements.</para>
        /// </summary>
        /// <param name="sizeOfArray">Size of the array.</param>
        /// <param name="numbers">String containing <paramref name="sizeOfArray"/> space-separated integers representing the array's elements.</param>
        public SimpleArraySum(int sizeOfArray, string numbers)
        {
            SizeOfArray = sizeOfArray;
            Numbers = numbers;
        }

        public int Execute()
        {
            var splittedNumbers = SplitNumbersInput();

            var array = ConvertArrayStringToInt(splittedNumbers);

            return SumIntArray(array);
        }

        private string[] SplitNumbersInput()
        {
            return Numbers.Split(' ');
        }

        private int[] ConvertArrayStringToInt(string[] numbers)
        {
            var array = new int[SizeOfArray];

            for(var i = 0; i < numbers.Length; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }

            return array;
        }

        private int SumIntArray(int[] array)
        {
            int arraySum = 0;

            for (var i = 0; i < array.Length; i++)
            {
                arraySum += array[i];
            }

            return arraySum;
        }
    }
}
