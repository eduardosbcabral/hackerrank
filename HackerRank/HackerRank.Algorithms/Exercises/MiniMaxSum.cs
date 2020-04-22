using HackerRank.Shared;
using System;

namespace HackerRank.Algorithms.Exercises
{
    public class MiniMaxSum : IExercise<uint[]>
    {
        public uint[] Numbers { get; private set; }

        /// <summary>
        /// <para>Plus Minus</para>
        /// <para>Order: 8</para>
        /// <para>Description: Given an array of unsigned integers of size 4, calculate the minimum and maximum sum of exactly four numbers.</para>
        /// </summary>
        /// <param name="numbers">Contains unsigned integers describing an array of numbers.</param>
        public MiniMaxSum(uint[] numbers)
        {
            Numbers = numbers;
            CheckConstraints();
        }

        public uint[] Execute()
        {
            Array.Sort(Numbers);

            uint minimum = 0;
            uint maximum = 0;

            for(var i = 0; i < Numbers.Length; i++)
            {
                if(i != 0)
                {
                    maximum += Numbers[i];
                }

                if(i != (Numbers.Length - 1))
                {
                    minimum += Numbers[i];
                }
            }

            return new uint[2]
            {
                minimum,
                maximum
            };
        }

        public void CheckConstraints()
        {
            if (Numbers.Length != 5)
                throw new ConstraintException($"Length: {Numbers.Length}");

            foreach (var number in Numbers) {
                if (number < 1 || number > Math.Pow(10, 9))
                    throw new ConstraintException(number);
            }
        }
    }
}
