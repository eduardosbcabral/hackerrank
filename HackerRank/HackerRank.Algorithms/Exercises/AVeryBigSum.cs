using HackerRank.Shared;
using System;

namespace HackerRank.Algorithms.Exercises
{
    public class AVeryBigSum : IExercise<double>
    {
        public string Numbers { get; private set; }

        /// <summary>
        /// <para>A Very Big Sum</para>
        /// <para>Order: 4</para>
        /// <para>Description: Calculate the sum of the elements in an array.</para>
        /// <param name="numbers">String containing three space-separated doubles representing the array's elements.</param>
        /// </summary>
        public AVeryBigSum(string numbers)
        {
            Numbers = numbers;
        }

        public double Execute()
        {
            var splittedSecondInput = SplitNumbersInput(Numbers);
            var numbers = ConvertArrayStringToDouble(splittedSecondInput);

            var sum = 0d;

            for(var i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        private string[] SplitNumbersInput(string input)
        {
            return input.Split(' ');
        }

        private double[] ConvertArrayStringToDouble(string[] numbers)
        {
            var array = new double[numbers.Length];

            for (var i = 0; i < numbers.Length; i++)
            {
                var parsed = double.TryParse(numbers[i], out double number);

                if (parsed)
                {
                    if (number < 0 || number > Math.Pow(10, 10))
                    {
                        throw new ArgumentOutOfRangeException($"{numbers[i]} is outside the specified range.");
                    }

                    array[i] = number;
                }
                else
                    throw new ArgumentOutOfRangeException($"{numbers[i]} is outside the specified range.");
            }

            return array;
        }
    }
}
