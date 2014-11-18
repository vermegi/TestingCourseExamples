using NUnit.Framework;

namespace SomeFizzBuzzing.Tests
{
    [TestFixture]
    public class FizBuzz2Tests
    {
        [Test]
        public void It_writes_1_for_1()
        {
            var writer = new NageaapteWriter();
            var sut = new FizzBuzz2(writer);

            sut.GiveAnswer(1);

            Assert.That(writer.Output, Is.EqualTo("1\r\n"));
        }
    }

    public class NageaapteWriter : IWriteStuff
    {
        private string _message;

        public string Output { get { return _message; } }
        
        public void Write(string amessage)
        {
            _message = amessage;
        }

        public void WriteLine()
        {
            _message += "\r\n";
        }
    }
}