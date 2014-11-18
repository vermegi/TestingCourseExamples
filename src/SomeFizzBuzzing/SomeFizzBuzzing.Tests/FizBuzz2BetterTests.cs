using Moq;
using NUnit.Framework;

namespace SomeFizzBuzzing.Tests
{
    [TestFixture]
    public class FizBuzz2BetterTests
    {
        [Test]
        public void It_writes_1_for_1()
        {
            var writer = new Mock<IWriteStuff>();
            var sut = new FizzBuzz2(writer.Object);

            sut.GiveAnswer(1);

            writer.Verify(w => w.Write("1"));
            writer.Verify(w => w.WriteLine());
        }
    }
}