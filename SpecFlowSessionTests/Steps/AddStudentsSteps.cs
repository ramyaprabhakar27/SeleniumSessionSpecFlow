using NUnit.Framework;
using SeleniumSessionPageObjects.Pages;
using SeleniumSessionPageObjects.Utilities;
using SeleniumSessionTests.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace SpecFlowSessionTests.Steps
{
    [Binding]
    public class AddStudentsSteps
    {
        private List<StudentDetails> students = StudentDetails.AddStudentDetails();

        [BeforeFeature]
        public static void SetUp()
        {
            Driver.SetUp();
        }

        [AfterFeature]
        public static void Teardown()
        {
            Driver.TearDown();
        }

        [Given(@"I am at the Demo Page")]
        public void GivenIAmAtTheDemoPage()
        {
            Driver.GoToSite(URL.DemoSiteUrl);
        }
        
        [Given(@"I login as admin")]
        public void GivenILoginAsAdmin()
        {
            DemoSiteLoginPage.EnterUserName(TestLoginDetails.userName);
            DemoSiteLoginPage.EnterPassword(TestLoginDetails.passWord);
            DemoSiteLoginPage.Submit();
        }

        [When(@"I Add students")]
        public void WhenIAddStudents()
        {
            foreach (StudentDetails stud in students)
            {
                DemoSiteCreateStudentPage.AddStudentDetails();
                DemoSiteCreateStudentPage.EnterName(stud.Name);
                DemoSiteCreateStudentPage.SelectClass(stud.Class);
                DemoSiteCreateStudentPage.EnterRollNo(stud.RollNo);
                DemoSiteCreateStudentPage.SelectGender(stud.GenderType);
                DemoSiteCreateStudentPage.SaveStudentDetails();
            }
        }
        
        [Then(@"I should see the added students")]
        public void ThenIShouldSeeTheAddedStudents()
        {
            List<string> stulist = (from student in students
                                    select student.Name.ToString()).ToList();
            List<string> addedStuList = DemoSiteStudentDetailsPage.GetStudentNames();
            var exceptions = addedStuList.Except(stulist).ToList();
            Assert.True(exceptions.Count == 0);
        }
    }
}
