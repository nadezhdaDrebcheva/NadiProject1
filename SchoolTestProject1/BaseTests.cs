using Homework8;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTestProject
{
    public abstract class BaseTests
    {
        protected School School { get; set; }
        protected JArray Array { get; set; }

        [OneTimeSetUp]
        public void SetupSchool()
        {
            string StudentsstudentsJsonFile = "Students.json";
            School = new School("Sofia High School", "Sofia 1000");
            Array = JsonDataFileReader.GetJArray(StudentsstudentsJsonFile);

            List<Student> students = Array.ToObject<List<Student>>();
            School.AddStudents(students);
        }
    }
}