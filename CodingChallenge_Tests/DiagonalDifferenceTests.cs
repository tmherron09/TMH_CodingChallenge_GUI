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
        public void HackerRankResult_Int11()
        {
            DiagonalDifference diagDiff = new DiagonalDifference();


            
        }

        [Test]
        public void IsValid_NewFinalLongerArray_ReturnTrue()
        {
            int[] orig = { 1, 2, 3, 4, 5 };
            int[] final = { 5, 4, 3, 2, 1 };
            NewYearsChaos _genericSetup = new NewYearsChaos(orig, final);

            _genericSetup.FinalQueue = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            Assert.IsTrue(_genericSetup.IsValid);
        }

        ual(Expected, Output);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 1, 5, 3, 4 }, false, 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 1, 2, 3, 4 }, true, 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 3, 4, 2, 1 }, true, 9)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 1, 2, 5, 3, 4, 7, 8, 6 }, false, 4)]
        public void CalculateBribesGeneric_Chaotic_Matches(int[] orig, int[] final, bool isChaotic, int bribeCount)
        {
            NewYearsChaos _genericConstr = new NewYearsChaos(orig, final);

            string Expected = $"{(isChaotic ? "Too Chaotic " : "")}Total Bribes: {bribeCount}";
            string Output = _genericConstr.CalculateBribesOptimized();
            Assert.AreEqual(Expected, Output);
        }



    }
}
