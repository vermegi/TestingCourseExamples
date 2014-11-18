using NUnit.Framework;

namespace SomeFizzBuzzing.Tests
{
    public class FictureTestsBetter : AAATest
    {
        private FizzBuzz _sut;
        private string _result;

        public override void Arrange()
        {
            _sut = new FizzBuzz();
        }

        public override void Act()
        {
            _result = _sut.GiveAnswer(1);
        }

        [Test]
        public void It_returns_1()
        {
            Assert.That(_result, Is.EqualTo("1"));
        }
    }
}