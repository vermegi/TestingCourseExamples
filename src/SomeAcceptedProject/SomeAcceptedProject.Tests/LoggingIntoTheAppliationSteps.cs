using System;
using TechTalk.SpecFlow;

namespace SomeAcceptedProject.Tests
{
    [Binding]
    public class LoggingIntoTheAppliationSteps
    {
        [Given(@"I am on the login page of the application")]
        public void GivenIAmOnTheLoginPageOfTheApplication()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I fill out '(.*)' as a username")]
        public void GivenIFillOutAsAUsername(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I fill out '(.*)' as a password")]
        public void GivenIFillOutAsAPassword(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I am redirected to the general home page")]
        public void ThenIAmRedirectedToTheGeneralHomePage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}