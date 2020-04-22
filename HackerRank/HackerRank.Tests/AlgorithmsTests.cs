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

        [TestMethod]
        public void PlusMinusTests()
        {
            // Case One (Correct)
            var inputCaseOne = new int[6]
            {
                -4, 3, -9, 0, 4, 1
            };

            var exerciseCaseOne = new PlusMinus(inputCaseOne);

            var expectedOutputCaseOne = new double[3]
            {
                0.5,
                0.333333,
                0.166667
            };

            var resultCaseOne = exerciseCaseOne.Execute();

            CollectionAssert.AreEqual(expectedOutputCaseOne, resultCaseOne);

            // Case Two (Check Constraints)
            var inputCaseTwo = new int[6]
            {
                -4000, 3, -9, 0, 4, 1
            };
            Assert.ThrowsException<ConstraintException>(
                () => new PlusMinus(inputCaseTwo));
        }

        [TestMethod]
        public void StaircaseTests()
        {
            // Case One (Correct)
            var inputCaseOne = 4;

            var exercise = new Staircase(inputCaseOne);

            var expectedOutputCaseOne = new string[4]
            {
                "   #",
                "  ##",
                " ###",
                "####"
            };

            var resultCaseOne = exercise.Execute();

            CollectionAssert.AreEqual(expectedOutputCaseOne, resultCaseOne);

            // Case Two (Check Constraints)
            var inputCaseTwo = 500;

            Assert.ThrowsException<ConstraintException>(
                () => new Staircase(inputCaseTwo));
        }

        [TestMethod]
        public void MiniMaxSum()
        {
            // Case One (Correct)
            var inputCaseOne = new uint[5]
            {
                769082435, 210437958, 673982045, 375809214, 380564127
            };

            var exercise = new MiniMaxSum(inputCaseOne);

            var expectedOutputCaseOne = new uint[2]
            {
                1640793344, 2199437821
            };

            var resultCaseOne = exercise.Execute();

            CollectionAssert.AreEqual(expectedOutputCaseOne, resultCaseOne);

            // Case Two (Check Constraints) - Input Size
            var inputCaseTwo = new uint[2]
            {
                1, 2
            };

            Assert.ThrowsException<ConstraintException>(
                () => new MiniMaxSum(inputCaseTwo));
        }
    }
}
