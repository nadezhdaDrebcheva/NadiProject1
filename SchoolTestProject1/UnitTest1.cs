using NUnit.Framework;
using System.Collections.Generic;

namespace SchoolTestProject
{
    public class StudentsTests : BaseTests
    {


        [Test]
        [Description("Validate Students Count")]
        public void ValidateStudentsCount()
        {


            Assert.AreEqual(4, School.Students.Count);
        }
    }
}