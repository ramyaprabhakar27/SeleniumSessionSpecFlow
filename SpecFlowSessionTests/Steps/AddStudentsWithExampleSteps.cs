using NUnit.Framework;
using SeleniumSessionPageObjects.Pages;
using SeleniumSessionPageObjects.Utilities;
using SeleniumSessionTests.Utilities;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SpecFlowSessionTests.Steps
{
    [Binding]
    [Scope(Feature = "AddStudentsWithExample", Tag = "demo")]
    public class AddStudentsWithExampleSteps
    {

        [Given(@"I Enter the name as (.*)")]
        public void GivenIEnterTheNameAs(string name)
        {
            ScenarioContext.Current["StudentName"] = name;
            DemoSiteCreateStudentPage.AddStudentDetails();
            DemoSiteCreateStudentPage.EnterName(name);
        }
        
        [Given(@"I Select the class as (.*)")]
        public void GivenISelectTheClassAs(StudentClass classlevel)
        {
            DemoSiteCreateStudentPage.SelectClass(classlevel);
        }
        
        [Given(@"I Enter the roll number as (.*)")]
        public void GivenIEnterTheRollNumberAs(string rollNumber)
        {
            DemoSiteCreateStudentPage.EnterRollNo(rollNumber);
        }
        
        [Given(@"I Select the gender as (.*)")]
        public void GivenISelectTheGenderAs (Gender gender)
        {
            DemoSiteCreateStudentPage.SelectGender(gender);
        }

        [Given(@"I save the student data")]
        public void GivenISaveTheStudentData()
        {
            DemoSiteCreateStudentPage.SaveStudentDetails();
        }

        [Then(@"I should see the added student")]
        public void ThenIShouldSeeTheAddedStudent()
        {
            List<string> addedStuList = DemoSiteStudentDetailsPage.GetStudentNames();
            Assert.True(addedStuList.Contains(ScenarioContext.Current["StudentName"].ToString()));
        }

        [BeforeFeature (Order = 10)]
        public static void LoginAsAdmin()
        {
            Driver.SetUp();
            Driver.GoToSite(URL.DemoSiteUrl);
            DemoSiteLoginPage.EnterUserName(TestLoginDetails.userName);
            DemoSiteLoginPage.EnterPassword(TestLoginDetails.passWord);
            DemoSiteLoginPage.Submit();
        }

        [AfterFeature]
        public static void TestTearDown()
        {
            Driver.TearDown();
        }
    }
}
