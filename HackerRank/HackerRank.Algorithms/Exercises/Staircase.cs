using HackerRank.Shared;
using System;
using System.Linq;

namespace HackerRank.Algorithms.Exercises
{
    public class Staircase : IExercise<string[]>
    {
        public int Size { get; private set; }

        /// <summary>
        /// <para>Staircase</para>
        /// <para>Order: 7</para>
        /// <para>Description: Given a size, print a staircase made by empty spaces and #
        /// </summary>
        /// <param name="size">Staircase size.</param>
        public Staircase(int size)
        {
            Size = size;
            CheckConstraints();
        }

        public string[] Execute()
        {
            var lines = new string[Size];

            for(var i = 1; i <= Size; i++)
            {
                var line = new string(' ', Size - i) + new string('#', i);
                lines[i - 1] = line;
            }

            return lines;
        }

        public void CheckConstraints()
        {
            if (Size < 0 || Size >= 100)
                throw new ConstraintException(Size);
        }
    }
}
