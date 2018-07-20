using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowSessionTests.Steps
{
    [Binding]
    [Scope (Feature = "AddStudentsWithScopeBinding")]
    class AddStudentsWithScopeBindingSteps
    {
        [Given(@"I am at the Demo Page")]
        public void GivenIAmAtTheDemoPage()
        {
            Console.WriteLine("I am from scope bound method");
        }

        [Given(@"I login as admin")]
        public void GivenILoginAsAdmin()
        {
            Console.WriteLine("I am from scope bound method");
        }


        [When(@"I Add students")]
        public void WhenIAddStudents()
        {
            Console.WriteLine("I am from scope bound method");
        }

        [Then(@"I should see the added students")]
        public void ThenIShouldSeeTheAddedStudents()
        {
            Console.WriteLine("I am from scope bound method");
        }
    }
}
