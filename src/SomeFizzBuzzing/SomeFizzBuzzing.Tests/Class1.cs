using System;
using NUnit.Framework;

namespace SomeFizzBuzzing.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        public void It_returns_1_for_1(int input, string expected)
        {
            var sut = new FizzBuzz();

            var result = sut.GiveAnswer(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void It_returns_2_for_2()
        {
            var sut = new FizzBuzz();

            var result = sut.GiveAnswer(2);

            Assert.That(result, Is.EqualTo("2"));
        }

        [Test]
        public void It_returns_Fizz_for_3()
        {
            var sut = new FizzBuzz();

            var result = sut.GiveAnswer(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void It_returns_Buzz_for_5()
        {
            var sut = new FizzBuzz();

            var result = sut.GiveAnswer(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void It_returns_FizzBuzz_for_15()
        {
            var sut = new FizzBuzz();

            var result = sut.GiveAnswer(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        [ExpectedException(typeof(ApplicationException))]
        public void It_throws_an_exception_for_negative_number()
        {
            var sut = new FizzBuzz();

            var result = sut.GiveAnswer(0);
        }

    }
}
