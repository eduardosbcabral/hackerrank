using HackerRank.Algorithms.Exercises;
using HackerRank.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HackerRank.Tests
{
    [TestClass]
    public class AlgorithmsTests
    {
        [TestMethod]
        public void SolveMeFirstTests()
        {
            var exercise = new SolveMeFirst(3, 2);
            Assert.AreEqual(5, exercise.Execute());
            exercise = new SolveMeFirst(1000, 100);
            Assert.AreEqual(1100, exercise.Execute());
        }

        [TestMethod]
        public void SimpleArraySumTests()
        {
            var exercise = new SimpleArraySum(3, "1 2 3");
            Assert.AreEqual(6, exercise.Execute());
            exercise = new SimpleArraySum(6, "1 2 3 4 10 11");
            Assert.AreEqual(31, exercise.Execute());
            exercise = new SimpleArraySum(10, "338 65 713 595 428 610 728 573 871 868");
            Assert.AreEqual(5789, exercise.Execute());
        }

        [TestMethod]
        public void CompareTheTripletTests()
        {
            // Test case 1
            var exercise = new CompareTheTriplets("5 6 7", "3 6 10");
            var result = exercise.Execute();
            var aliceRating = 1;
            var bobRating = 1;
            Assert.AreEqual(aliceRating, result[0]);
            Assert.AreEqual(bobRating, result[1]);

            // Test case 2
            exercise = new CompareTheTriplets("17 28 30", "99 16 8");
            result = exercise.Execute();
            aliceRating = 2;
            bobRating = 1;
            Assert.AreEqual(aliceRating, result[0]);
            Assert.AreEqual(bobRating, result[1]);
        }

        [TestMethod]
        public void AVeryBigSumTests()
        {
            var exercise = new AVeryBigSum("1000000001 1000000002 1000000003 1000000004 1000000005");
            Assert.AreEqual(5000000015, exercise.Execute());
        }

        [TestMethod]
        public void DiagonalDifferenceTests()
        {
            // Case One (Correct)
            var inputCaseOne = new int[3][]
            {
                new int[] { 11, 2, 4 },
                new int[] { 4, 5, 6 },
                new int[] { 10, 8, -12 }
            };

            var exerciseCaseOne = new DiagonalDifference(inputCaseOne);
            Assert.AreEqual(15, exerciseCaseOne.Execute());

            // Case Two (Check Constraints)
            var inputCaseTwo = new int[3][]
            {
                new int[] { -100011, 2, 4 },
                new int[] { 4, 5, 6 },
                new int[] { 10, 8, -12 }
            };
            Assert.ThrowsException<ConstraintException>(
                () => new DiagonalDifference(inputCaseTwo));
        }
    }
}
