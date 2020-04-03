using HackerRank.Shared;
using System;

namespace HackerRank.Algorithms.Exercises
{
    public class CompareTheTriplets : IExercise<int[]>
    {
        public string AliceTriplet { get; private set; }
        public string BobTriplet { get; private set; }

        /// <summary>
        /// <para>Compare The Triplets</para>
        /// <para>Order: 3</para>
        /// <para>Description: Given two arrays of integers, find Alice's and Bob's respective comparison points.</para>
        /// <para>If a[i] > b[i], then Alice is awarded 1 point.</para>
        /// <para>If a[i] < b[i], then Bob is awarded 1 point.</para>
        /// <para>If a[i] = b[i], then neither person receives a point.</para>
        /// </summary>
        /// <param name="aliceTriplet">String containing three space-separated integers representing the array's elements.</param>
        /// <param name="bobTriplet">String containing three space-separated integers representing the array's elements.</param>
        public CompareTheTriplets(string aliceTriplet, string bobTriplet)
        {
            AliceTriplet = aliceTriplet;
            BobTriplet = bobTriplet;
        }

        public int[] Execute()
        {
            var splitedAliceTriplet = SplitNumbersInput(AliceTriplet);
            var splitedBobTriplet = SplitNumbersInput(BobTriplet);

            var aliceTriplet = ConvertArrayStringToInt(splitedAliceTriplet);
            var bobTriplet = ConvertArrayStringToInt(splitedBobTriplet);

            var ratingsArray = new int[2];

            for (var i = 0; i < aliceTriplet.Length; i++)
            {
                if (aliceTriplet[i] > bobTriplet[i])
                {
                    ratingsArray[(int)Names.Alice]++;
                }
                else if (aliceTriplet[i] < bobTriplet[i])
                {
                    ratingsArray[(int)Names.Bob]++;
                }
            }

            return ratingsArray;
        }

        private string[] SplitNumbersInput(string input)
        {
            return input.Split(' ');
        }

        private int[] ConvertArrayStringToInt(string[] numbers)
        {
            if(numbers.Length != 3)
            {
                throw new ArgumentOutOfRangeException("Input is not a triplet.");
            }

            var array = new int[3];

            for (var i = 0; i < numbers.Length; i++)
            {
                array[i] = int.Parse(numbers[i]);
            }

            return array;
        }
    }

    internal enum Names : byte
    {
        Alice, // Alice = 0
        Bob    // Bob = 1
    }
}
