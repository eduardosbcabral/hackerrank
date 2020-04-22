using HackerRank.Shared;
using System;

namespace HackerRank.Algorithms.Exercises
{
    public class PlusMinus : IExercise<double[]>
    {
        public int[] Numbers { get; private set; }

        /// <summary>
        /// <para>Plus Minus</para>
        /// <para>Order: 6</para>
        /// <para>Description: Given an array of integers, calculate the fractions of its elements that are positive, negative, and are zeros.</para>
        /// </summary>
        /// <param name="numbers">Contains integers describing an array of numbers.</param>
        public PlusMinus(int[] numbers)
        {
            Numbers = numbers;
            CheckConstraints();
        }

        public double[] Execute()
        {
            var positive = 0;
            var negative = 0;
            var zero = 0;

            for(var i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] == 0)
                    zero++;

                if (Numbers[i] > 0)
                    positive++;

                if (Numbers[i] < 0)
                    negative++;
            }

            return new double[3]
            {
                Divide(positive, Numbers.Length),
                Divide(negative, Numbers.Length),
                Divide(zero, Numbers.Length)
            };
        }

        public double Divide(int numberOne, int numberTwo)
        {
            return Math.Round((double)numberOne / numberTwo, 6, MidpointRounding.AwayFromZero);
        }

        public void CheckConstraints()
        {
            for (var i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] < -100 || Numbers[i] > 100)
                    throw new ConstraintException(Numbers[i]);
            }
        }
    }
}
