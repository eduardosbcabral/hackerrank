using HackerRank.Shared;
using System;

namespace HackerRank.Algorithms.Exercises
{
    public class BirthdayCakeCandles : IExercise<int>
    {
        public int Number { get; private set; }
        public int[] Candles { get; private set; }

        /// <summary>
        /// <para>Birthday Cake Candles</para>
        /// <para>Order: 9</para>
        /// <para>Description: Given an array of height of candles, find how many can we blow out. But we can only blow out the tallest ones.</para>
        /// </summary>
        /// <param name="number">Number of candles.</param>
        /// <param name="candles">An array of integers representing candle heights.</param>
        public BirthdayCakeCandles(int number, int[] candles)
        {
            Number = number;
            Candles = candles;
            CheckConstraints();
        }

        public int Execute()
        {
            var tallerIndex = 0;
            var tallerFrequency = 0;

            for (var i = 0; i < Candles.Length; i++)
            {
                if (Candles[i] > Candles[tallerIndex])
                {
                    tallerIndex = i;
                    tallerFrequency = 1;
                }
                else if(Candles[i] == Candles[tallerIndex])
                {
                    tallerFrequency++;
                }
            }

            return tallerFrequency;
        }

        public void CheckConstraints()
        {
            if (Number != Candles.Length)
                throw new ConstraintException($"Should be same quantity: {Number}");

            if(Number < 1 || Number > Convert.ToInt32(Math.Pow(10, 5)))
                throw new ConstraintException(Number);

            foreach(var candle in Candles)
            {
                if(candle < 1 || candle > Convert.ToInt32(Math.Pow(10, 7)))
                    throw new ConstraintException(candle);
            }
        }
    }
}
