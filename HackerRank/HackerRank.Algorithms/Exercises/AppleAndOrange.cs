using HackerRank.Shared;
using System;

namespace HackerRank.Algorithms.Exercises
{
    public class AppleAndOrange : IExercise<int[]>
    {
        public int StartPointHouse { get; private set; }
        public int EndPointHouse { get; private set; }
        public int AppleTreePoint { get; private set; }
        public int OrangeTreePoint { get; private set; }
        public int[] FallenApples { get; private set; }
        public int[] FallenOranges { get; private set; }

        /// <summary>
        /// <para>Apple And Orange</para>
        /// <para>Order: 11</para>
        /// <para>Description: Find how many apples and oranges that will fall on the house.</para>
        /// </summary>
        /// <param name="startPointHouse">Starting point of Sam's house location.</param>
        /// <param name="endPointHouse">Ending location of Sam's house location.</param>
        /// <param name="appleTreePoint">Location of the Apple tree.</param>
        /// <param name="orangeTreePoint">Location of the Orange tree.</param>
        /// <param name="fallenApples">Distances at which each apple falls from the tree.</param>
        /// <param name="fallenOranges">Distances at which each orange falls from the tree.</param>

        public AppleAndOrange(
           int startPointHouse,
           int endPointHouse,
           int appleTreePoint,
           int orangeTreePoint,
           int[] fallenApples,
           int[] fallenOranges)
        {
            StartPointHouse = startPointHouse;
            EndPointHouse = endPointHouse;
            AppleTreePoint = appleTreePoint;
            OrangeTreePoint = orangeTreePoint;
            FallenApples = fallenApples;
            FallenOranges = fallenOranges;
            CheckConstraints();
        }

        public int[] Execute()
        {
            var applesOnHouse = 0;
            foreach(var apple in FallenApples)
            {
                var newApplePosition = apple + AppleTreePoint;
                if (newApplePosition >= StartPointHouse && newApplePosition <= EndPointHouse)
                    applesOnHouse++;
            }

            var orangesOnHouse = 0;
            foreach (var orange in FallenOranges)
            {
                var newOrangePosition = orange + OrangeTreePoint;
                if (newOrangePosition >= StartPointHouse && newOrangePosition <= EndPointHouse)
                    orangesOnHouse++;
            }

            return new int[]
            {
                applesOnHouse,
                orangesOnHouse
            };
        }

        public void CheckConstraints()
        {
            if(StartPointHouse < 1 || StartPointHouse > Math.Pow(10, 5))
                throw new ConstraintException(StartPointHouse);

            if (EndPointHouse < 1 || EndPointHouse > Math.Pow(10, 5))
                throw new ConstraintException(EndPointHouse);

            if (AppleTreePoint < 1 || AppleTreePoint > Math.Pow(10, 5))
                throw new ConstraintException(AppleTreePoint);

            if (OrangeTreePoint < 1 || OrangeTreePoint > Math.Pow(10, 5))
                throw new ConstraintException(OrangeTreePoint);

            if (FallenApples.Length < 1 || FallenApples.Length > Math.Pow(10, 5))
                throw new ConstraintException(OrangeTreePoint);

            if (FallenOranges.Length < 1 || FallenOranges.Length > Math.Pow(10, 5))
                throw new ConstraintException(OrangeTreePoint);

            if(AppleTreePoint > StartPointHouse)
                throw new ConstraintException(AppleTreePoint);

            if(StartPointHouse > EndPointHouse)
                throw new ConstraintException(StartPointHouse);

            if (EndPointHouse > OrangeTreePoint)
                throw new ConstraintException(EndPointHouse);
        }
    }
}
