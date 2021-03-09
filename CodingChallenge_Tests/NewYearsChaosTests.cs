using NUnit.Framework;
using TMHCodingChallengeHostGUI;

namespace CodingChallenge_Tests
{
    [TestFixture]
    public class NewYearsChaosTests
    {
        


        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void IsValid_BothValidArrays_ReturnTrue()
        {
            int[] orig = { 1, 2, 3, 4, 5 };
            int[] final = { 5, 4, 3, 2, 1 };
            NewYearsChaos _genericSetup = new NewYearsChaos(orig, final);

            Assert.IsTrue(_genericSetup.IsValid);
        }

        [Test]
        public void IsValid_NewFinalLongerArray_ReturnTrue()
        {
            int[] orig = { 1, 2, 3, 4, 5 };
            int[] final = { 5, 4, 3, 2, 1 };
            NewYearsChaos _genericSetup = new NewYearsChaos(orig, final);

            _genericSetup.FinalQueue = new int[]{ 1,2,3,4,5,6,7,8,9,10};


            Assert.IsTrue(_genericSetup.IsValid);
        }

        [Test]
        public void PopulateOriginalQueueStandard_NewFinalQueueLonger_Matches()
        {
            int[] orig = { 1, 2, 3, 4, 5 };
            int[] final = { 5, 4, 3, 2, 1 };
            NewYearsChaos _genericConstr = new NewYearsChaos(orig, final);
            
            _genericConstr.FinalQueue = new int[] { 7, 6, 5, 4, 3, 2, 1 };

            // Expected
            int[] ExpectedArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            // Assert
            Assert.AreEqual(ExpectedArray, _genericConstr.OriginalQueue);
        }

        [Test]
        public void PopulateOriginalQueueStandard_OnlyFinalQueueConstructor_Matches()
        {
            int[] final = { 5, 4, 3, 2, 1 };
            NewYearsChaos _finalQueueOnlyConstr = new NewYearsChaos(final);

            int[] ExpectedArray = { 1, 2, 3, 4, 5 };
            Assert.AreEqual(ExpectedArray, _finalQueueOnlyConstr.OriginalQueue);

        }

    }
}