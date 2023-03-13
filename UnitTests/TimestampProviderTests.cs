using Moq;
using TestPyramidExample;

namespace UnitTests
{
    public class TimestampProviderTests
    {
        [Test]
        public void GetTimestamp_ReturnsCorrectTimestampString()
        {
            var timeProvider = new Mock<ITimeProvider>();
            timeProvider.Setup(p => p.GetDay()).Returns(13);
            timeProvider.Setup(p => p.GetMonth()).Returns(3);
            timeProvider.Setup(p => p.GetYear()).Returns(2023);
            timeProvider.Setup(p => p.GetHour()).Returns(11);
            timeProvider.Setup(p => p.GetMinute()).Returns(7);
            timeProvider.Setup(p => p.GetSecond()).Returns(40);
            var uut = new TimestampProvider(timeProvider.Object);

            var timestampString = uut.GetTimestamp();

            Assert.That(timestampString, Is.EqualTo("03/13/2023 11:07:40"));
        }
    }
}