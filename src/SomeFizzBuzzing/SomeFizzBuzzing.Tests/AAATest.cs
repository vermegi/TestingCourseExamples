using NUnit.Framework;

namespace SomeFizzBuzzing.Tests
{
    [TestFixture]
    public abstract class AAATest
    {
        public abstract void Arrange();
        public abstract void Act();

        [TestFixtureSetUp]
        public void SetupTest()
        {
            Arrange();
            Act();
        }
    }
}    