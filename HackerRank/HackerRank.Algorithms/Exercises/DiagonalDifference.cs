using HackerRank.Shared;
using System;

namespace HackerRank.Algorithms.Exercises
{
    public class DiagonalDifference : IExercise<int>
    {
        public int[][] Numbers { get; private set; }

        /// <summary>
        /// <para>Diagonal Difference</para>
        /// <para>Order: 5</para>
        /// <para>Description: Given an square matrix, calculate the absolute difference between the sums of its diagonals.</para>
        /// </summary>
        /// <param name="numbers">Array of two dimensions containing the numbers.</param>
        public DiagonalDifference(int[][] numbers)
        {
            Numbers = numbers;
            CheckConstraints();
        }

        public int Execute()
        {
            return DiagonalsDifference();
        }

        public int DiagonalsDifference()
        {
            var sum = 0;

            for (var i = 0; i < Numbers.Length; i++)
            {
                sum += Numbers[i][i];
                sum -= Numbers[i][Numbers.Length - i - 1];
            }
            
            return Math.Abs(sum);
        }

        public void CheckConstraints()
        {
            for (var i = 0; i < Numbers.Length; i++)
            {
                for (var j = 0; j < Numbers[i].Length; j++)
                {
                    // Constraint given by exercise
                    if (Numbers[i][j] < -100 || Numbers[i][j] > 100)
                        throw new ConstraintException(Numbers[i][j]);
                }
            }
        }
    }
}
