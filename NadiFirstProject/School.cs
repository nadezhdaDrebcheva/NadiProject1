using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Student> Students { get; private set; }


        public School(string name, string address)
        {
            Name = name;
            Address = address;
            Students = new List<Student>();
        }
        public void AddStudents(List<Student> students) => Students.AddRange(students);



        public void RemoveStudent(int id)
        {
            foreach (Student student in Students)
            {
                if (student.Id == id)
                {
                    Students.Remove(student);
                }

            }
        }
        public List<Student> GetExcellentStudents()
        {
            List<Student> excellentStudents = new List<Student>();

            foreach (Student student in Students)
            {
                foreach (int item in student.studentMarks.Values)
                {
                    if (item == 6)
                    {
                        student.isExcellent = true;
                    }
                    else
                    {
                        student.isExcellent = false;
                        continue;
                    }
                }
            }
            foreach (Student student in Students)
            {
                if (student.isExcellent)
                {
                    excellentStudents.Add(student);
                }

            }

            return excellentStudents;
        }



    }



}
