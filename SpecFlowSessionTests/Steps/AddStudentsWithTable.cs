using System;
using SeleniumSessionTests.Utilities;
using SeleniumSessionPageObjects.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowSessionTests.Steps
{
    [Binding]
    [Scope (Feature = "AddStudentsWithTable")]
    class AddStudentsWithTable
    {
        [Given(@"I am at the Demo Page")]
        public void GivenIAmAtTheDemoPage()
        {
            Console.WriteLine("I am from spec flow assist test");
        }

        [Given(@"I login as admin")]
        public void GivenILoginAsAdmin()
        {
            Console.WriteLine("I am from spec flow assist test");
        }

        [When(@"I Add students")]
        public void WhenIAddStudents(Table table)
        {
            var student = table.CreateInstance<Student>();
            var student2 = table.CreateInstance<(string name, StudentClass stdClass, string stdRollNo, Gender stdGender)>();
        }
        [When(@"I Add students in Bulk")]
        public void WhenIAddStudentsInBulk(Table table)
        {
            var students = table.CreateSet<Student>();
        }
        
        [Then(@"I should see the added students")]
        public void ThenIShouldSeeTheAddedStudents()
        {
            Console.WriteLine("I am from spec flow assist test");
        }
    }
}
