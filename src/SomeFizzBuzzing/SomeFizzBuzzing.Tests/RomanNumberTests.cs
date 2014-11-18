using NUnit.Framework;

namespace SomeFizzBuzzing.Tests
{
    [TestFixture]
    public class RomanNumberTests
    {
        [Test]
        public void It_returns_I_for_1()
        {
            var sut = new RomanNumberGenerator();

            var result = sut.GenerateFor(1);

            Assert.That(result, Is.EqualTo("I"));
        }

        [Test]
        public void It_returns_II_for_2()
        {
            var sut = new RomanNumberGenerator();

            var result = sut.GenerateFor(2);

            Assert.That(result, Is.EqualTo("II"));
        }
    }
}