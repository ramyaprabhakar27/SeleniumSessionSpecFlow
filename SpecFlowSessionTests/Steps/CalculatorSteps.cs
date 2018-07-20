using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowSessionTests
{
    [Binding]
    public class CalculatorSteps
    {
        private Calculator calculator = new Calculator();
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            calculator.FirstNumber = p0;
        }
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int p0)
        {
            calculator.SecondNumber = p0;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current["Result"] = calculator.Add();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            ScenarioContext.Current["Result"] = calculator.Multiply();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.True(p0 == Convert.ToInt32(ScenarioContext.Current["Result"]));
        }
    }
}
