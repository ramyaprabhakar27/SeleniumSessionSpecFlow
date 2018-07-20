using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumSessionPageObjects.Utilities;

namespace SeleniumSessionTests.Utilities
{
    public static class TestLoginDetails
    {
        public static string userName = "admin";
        public static string passWord = "admin";
    }

    public class Student
    {
        public string Name { get; set; }
        public StudentClass Class { get; set; }
        public string RollNo { get; set; }
        public Gender GenderType { get; set; }
    }

    public class StudentDetails
    {
        StudentDetails(string stdName, StudentClass stdClass, string stdRollNo, Gender stdGender)
        {
            Name = stdName;
            Class = stdClass;
            RollNo = stdRollNo;
            GenderType = stdGender;
        }
        public string Name { get; set; }
        public StudentClass Class { get; set; }
        public string RollNo { get; set; }
        public Gender GenderType { get; set; }

        public static List<StudentDetails> AddStudentDetails()
        {
            StudentDetails Student1 = new StudentDetails("Ramya",StudentClass.V , "123", Gender.Female);
            StudentDetails Student2 = new StudentDetails("Barsha", StudentClass.VII, "120", Gender.Female);
            StudentDetails Student3 = new StudentDetails("kam", StudentClass.X, "122", Gender.Female);
            StudentDetails Student4 = new StudentDetails("John", StudentClass.IX, "154", Gender.Male);
            List<StudentDetails> students = new List<StudentDetails>
            {
                Student1,
                Student2,
                Student3,
                Student4
            };
            return students;
        }
    }
}
