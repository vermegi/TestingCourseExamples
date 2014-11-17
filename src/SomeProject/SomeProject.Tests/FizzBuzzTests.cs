using NUnit.Framework;

namespace SomeProject.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void It_returns_1_for_1()
        {
            var sut = new FizzBuzz();

            var result = sut.GiveAnswer(1);

            Assert.That(result, Is.EqualTo("1"));
        }

        [Test]
        public void It_returns_2_for_2()
        {
            var sut = new FizzBuzz();

            var result = sut.GiveAnswer(2);

            Assert.That(result, Is.EqualTo("2"));            
        }

        [Test]
        public void It_retuns_Fizz_for_3()
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
    }
}
