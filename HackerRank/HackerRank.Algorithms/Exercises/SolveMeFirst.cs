using HackerRank.Shared;

namespace HackerRank.Algorithms.Exercises
{
    public class SolveMeFirst : IExercise<int>
    {
        public int A { get; private set; }
        public int B { get; private set; }

        /// <summary>
        /// <para>Theme: Algorithm</para>
        /// <para>Order: 1</para>
        /// <para>Description: This exercise require us to compute the sum of two integers.</para>
        /// </summary>
        /// <param name="a">First integer input</param>
        /// <param name="b">Second integer input</param>
        public SolveMeFirst(int a, int b)
        {
            A = a;
            B = b;
        }

        public int Execute()
        {
            return A + B;
        }

        public void CheckConstraints()
        {
        }
    }
}
