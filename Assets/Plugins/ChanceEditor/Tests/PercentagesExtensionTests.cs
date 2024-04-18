using NUnit.Framework;

namespace ChanceEditor.Tests
{
    public class PercentagesExtensionTests
    {
        #region ToProbability
        [Test]
        public void WhenToProbability_AndHas1Percentage_ThenReturned0Comma01Probability()
        {
            Assert.AreEqual(0.01f, 1.ToProbability());
        }

        [Test]
        public void WhenToProbability_AndHas0Prcentages_ThenReturned0Probability()
        {
            Assert.AreEqual(0f, 0.ToProbability());
        }

        [Test]
        public void WhenToProbability_AndHas99Prcentages_ThenReturned0Comma99Probability()
        {
            Assert.AreEqual(0.99f, 99.ToProbability());
        }

        [Test]
        public void WhenToProbability_AndHas100Prcentages_ThenReturned1Probability()
        {
            Assert.AreEqual(1f, 100.ToProbability());
        }
        #endregion

        #region ToPercentages
        [Test]
        public void WhenToPercentages_AndHas0Comma01Probability_ThenReturned1Percentage()
        {
            Assert.AreEqual(1, 0.01f.ToPercentages());
        }

        [Test]
        public void WhenToPercentages_AndHas0Probability_ThenReturned0Prcentages()
        {
            Assert.AreEqual(0, 0f.ToPercentages());
        }

        [Test]
        public void WhenToPercentages_AndHas0Comma99Probability_ThenReturned99Prcentages()
        {
            Assert.AreEqual(99, 0.99f.ToPercentages());
        }

        [Test]
        public void WhenToPercentages_AndHas1Probability_ThenReturned100Prcentages()
        {
            Assert.AreEqual(100, 1f.ToPercentages());
        }
        #endregion
    }
}
