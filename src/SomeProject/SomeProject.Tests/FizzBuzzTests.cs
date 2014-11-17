using System.Text;
using NUnit.Framework;

namespace SomeProject.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void It_writes_1_to_the_console_for_1()
        {
            var theConsole = new ConsoleForTest();

            var sut = new FizzBuzz(theConsole);

            sut.GiveAnswer(1);

            Assert.That(theConsole.Output, Is.EqualTo("1\r\n"));
        }

        [Test]
        public void It_writes_2_to_the_console_for_2()
        {
            var theConsole = new ConsoleForTest();

            var sut = new FizzBuzz(theConsole);

            sut.GiveAnswer(2);

            Assert.That(theConsole.Output, Is.EqualTo("2\r\n"));
        }

        [Test]
        public void It_writes_Fizz_to_the_console_for_3()
        {
            var theConsole = new ConsoleForTest();

            var sut = new FizzBuzz(theConsole);

            sut.GiveAnswer(3);

            Assert.That(theConsole.Output, Is.EqualTo("Fizz\r\n"));
        }

        [Test]
        public void It_writes_Buzz_to_the_console_for_5()
        {
            var theConsole = new ConsoleForTest();

            var sut = new FizzBuzz(theConsole);

            sut.GiveAnswer(5);

            Assert.That(theConsole.Output, Is.EqualTo("Buzz\r\n"));
        }

        [Test]
        public void It_writes_FizzBuzz_to_the_console_for_15()
        {
            var theConsole = new ConsoleForTest();

            var sut = new FizzBuzz(theConsole);

            sut.GiveAnswer(15);

            Assert.That(theConsole.Output, Is.EqualTo("FizzBuzz\r\n"));
        }
    }

    public class ConsoleForTest : IAmAConsole
    {
        private StringBuilder _sb = new StringBuilder();

        public string Output { get{ return _sb.ToString();}}

        public void Write(string astring)
        {
            _sb.Append(astring);
        }

        public void WriteLine()
        {
            _sb.AppendLine();
        }
    }
}
