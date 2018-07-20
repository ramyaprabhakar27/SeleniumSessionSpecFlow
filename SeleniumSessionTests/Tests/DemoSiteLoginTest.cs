using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NLog;
using SeleniumSessionTests.Utilities;
using SeleniumSessionPageObjects.Utilities;
using SeleniumSessionPageObjects.Pages;

namespace SeleniumSessionTests.Tests
{
    [TestFixture]   
    [Category ("Demo Site Login Test")]
    public class DemoSiteLoginTest
    {
        private Logger logger = LogManager.GetLogger("DemoSite");
        private  List<StudentDetails> students = StudentDetails.AddStudentDetails();
        //private static Logger logger = LogManager.GetCurrentClassLogger();

        [SetUp]
        public void SetUp()
        {
            Driver.SetUp();
        }

        [Test]
        [Description("Login to DemoSite, Add Student Details and Assert that we are on the right Page")]
        public  void DemoSiteLoginPageTest()
        {
            LoginAsAdmin();
            VerifyInDemoPage();
            AddStudents();
            VerifyAddedStudents();
        }

        private  void LoginAsAdmin()
        {
            Driver.GoToSite(URL.DemoSiteUrl);
            Assert.True(DemoSiteLoginPage.GetDemoSiteLoginPageTitle().Equals("demo_site"), "Not on a Demo Site Home Page");
            DemoSiteLoginPage.EnterUserName(TestLoginDetails.userName);
            DemoSiteLoginPage.EnterPassword(TestLoginDetails.passWord);
            DemoSiteLoginPage.Submit();
            logger.Info("Logged in Successsfully");
        }

        private void VerifyInDemoPage()
        {
            Assert.True(DemoSiteStudentDetailsPage.GetDemoSiteStudentDetailsPageTitle().Equals("Student-details"), "Not on a Student Details Page");
        }

        private void AddStudents()
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

        private void VerifyAddedStudents()
        {
            List<string> stulist = (from student in students
                                    select student.Name.ToString()).ToList();
            List<string> addedStuList = DemoSiteStudentDetailsPage.GetStudentNames();
            var exceptions = addedStuList.Except(stulist).ToList();
            Assert.True(exceptions.Count == 0);
        }

        [TearDown]
        public static void TearDown()   
        {
            Driver.TearDown();
        }
    }
}