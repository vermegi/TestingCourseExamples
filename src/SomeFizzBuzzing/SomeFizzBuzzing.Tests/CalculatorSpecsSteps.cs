using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SomeFizzBuzzing.Tests
{
    [Binding]
    public class CalculatorSpecsSteps
    {
        private Calculator _calculator = new Calculator();
        private int _result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            _calculator.EnterNumber(p0);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}