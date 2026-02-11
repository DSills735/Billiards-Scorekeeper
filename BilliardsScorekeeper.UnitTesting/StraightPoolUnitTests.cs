namespace BilliardsScorekeeper.UnitTesting
{
    public class StriaghtPoolUnitTests
    {

        [TestCase(151, true, 150)]
        [TestCase(160, true, 150)]
        [TestCase(100, true, 100)]
        [TestCase(-100, true, -101)]
        public void WinCondition_ReturnsTrue(int score, bool expectResult, int maxScore)
        {
            var winner = ScoreUpdater.WinCondition(score, maxScore);

            Assert.That(winner, Is.True);

        }
    }
}
