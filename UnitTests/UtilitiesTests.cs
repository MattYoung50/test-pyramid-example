using TestPyramidExample;

namespace UnitTests
{
    public class UtilitiesTests
    {
        [Test]
        public void ReverseString_ReturnsCorrectReversedString()
        {
            string stringToReverse = "I'm a string we need to reverse";

            var reversedString = Utilities.ReverseString(stringToReverse);

            Assert.That(reversedString, Is.EqualTo("esrever ot deen ew gnirts a m'I"));
        }
    }
}