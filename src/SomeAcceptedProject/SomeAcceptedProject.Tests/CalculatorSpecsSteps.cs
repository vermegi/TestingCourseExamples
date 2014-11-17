using System;
using System.Collections.Generic;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SomeAcceptedProject.Tests
{
    [Binding]
    public class CalculatorSpecsSteps
    {
        private Calculator _calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            _calculator.InsertNumber(p0);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            var result = _calculator.Result;

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }

    internal class Calculator
    {
        private readonly List<int> _numbers = new List<int>();

        public void InsertNumber(int number)
        {
            _numbers.Add(number);
        }

        public void Add()
        {
            foreach (var number in _numbers)
            {
                Result += number;
            }
        }

        public int Result { get; private set; }
    }
}