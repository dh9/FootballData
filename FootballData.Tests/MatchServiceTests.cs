using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballData;

namespace FootballData.Tests
{
    [TestClass]
    public class MatchServiceTests
    {
        [TestMethod]
        public void GetMatches_CorrectValue()
        {
            var matchService = new MatchService();
            var matches = matchService.GetMatches();
            Assert.AreEqual("Getting Matches", matches);
        }
    }
}
