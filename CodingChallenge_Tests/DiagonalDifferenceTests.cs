using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMHCodingChallengeHostGUI;

namespace CodingChallenge_Tests
{
    [TestFixture]
    public class DiagonalDifferenceTests
    {


        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void HackerRankResult_Int15()
        {
            DiagonalDifference diagDiff = new DiagonalDifference();


            int expected = 15;
            int actual = diagDiff.DiagonalDifferenceResult();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RandomAssignment_ListSize_Expected()
        {
            int n = 9;
            DiagonalDifference diagDiff = new DiagonalDifference(n);

            List<List<int>> expectedArr = new List<List<int>>(n);
            for(int i = 0; i < n; i++)
            {
                expectedArr.Add(new List<int>());
                for (int j = 0; j < n; j++)
                {
                    expectedArr[i].Add(0);
                }
            }
            List<List<int>> actualArr = diagDiff.Arr;


            Assert.IsTrue((expectedArr.Count == actualArr.Count && expectedArr[0].Count == actualArr[0].Count));
        }


    }
}
