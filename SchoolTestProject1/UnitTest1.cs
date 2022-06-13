using Homework8;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace SchoolTestProject
{
    public class StudentsTests : BaseTests
    {


        [Test]
        [Description("IfObjectHasPropertyId")]
        public void IfObjectHasPropertyId()
        {
            bool hasID = false;
            foreach ( JObject jObject in Array)
            {
                foreach (var pair in jObject)
                {
                    if(pair.Key.Contains("Id"))
                        {
                         hasID = true;
                        break;
                    }
                    
                }
            }

            Assert.IsFalse(hasID);
        }


        [Test]
        [Description("ValidateUniqueIds")]
        public void ValidateUniqueIds()
        {
            List<int> ids = School.Students.Select(students => students.Id).ToList();

            bool areIdsUnique = ids.Distinct().Count() == ids.Count();
            Assert.IsTrue(areIdsUnique);

        }


        [Test]
        [Description("Are sbjects Equivalent")]
        public void AreSubjectsEquivalent()
        {
            List<string> subjectsToCompare = School.Students.First().studentMarks.Keys.ToList();

            foreach (Student student in School.Students)
            {
             List <string> subjects = student.studentMarks.Keys.ToList();

                CollectionAssert.AreEquivalent(subjectsToCompare, subjects);
            }

        }

        [Test]
        [Description("Validate Json objects are properly parsed")]
        public void ValidateJsonObjectsAreProperlyParsed()
        {
            for (int i = 0; i < School.Students.Count; i++)
            {
                Student student = School.Students[i];
                JObject jObject = Array[i].ToObject<JObject>();

                string expectedName = jObject["Name"].ToObject<string>();
                int expectedAge = jObject["Age"].ToObject<int>();
                Dictionary<string, int> expectedMarks = jObject["Marks"].ToObject<Dictionary<string, int>>();

                Assert.AreEqual(expectedName, student.Name);
                Assert.AreEqual(expectedAge, student.Age);

                foreach (var pair in expectedMarks)
                {
                    Assert.AreEqual(student.studentMarks[pair.Key], pair.Value);
                }

            }

        }

        [Test]
        [Description("Validate Actual Students Count After Removing Students")]
        public void ValidateValidateStudentsCountAfterRemoving()


        {            
               School.Students.RemoveAll(student => student.Age == 18);
               Assert.AreEqual(3, School.Students.Count);
            }
                    
                }

            }

        

    
    