using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace Homework8
{
    internal class Program
    {

        static void Main(string[] args)
        {
            School sofiaSchool = new School("Sofia High School", "str. Sofia 1, Sofia");

            string studentsJsonFile = "Students.json";
            JArray array = JsonDataFileReader.GetJArray(studentsJsonFile);
            List<Student> students = array.ToObject<List<Student>>();
            sofiaSchool.AddStudents(students);



            List<Student> otl = sofiaSchool.GetExcellentStudents();
            foreach (Student student in otl)
            {

                Console.WriteLine(student.Name);
            }

            try
            {
                foreach (Student student in otl)
                {

                    student.Speak();
                }

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Ne si na podhodqshta vuzrast za uchilishte");
            }

        }
    }
}