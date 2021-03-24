using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession_Class1.Models
{
    public class StudentModel
    {
        public Student Find()
        {
            return new Student
            {
                Id = "001",
                Name = "vinh",
                BirthDate = DateTime.Parse("10/23/2020"),
                Photo = "1.jpg",
                Score = 10.0
            };

        }

        public List<Student> FindAll()
        {
            return new List<Student>
            {
                new Student
                {
                     Id = "001",
                Name = "vinh",
                BirthDate = DateTime.Parse("10/23/2020"),
                Photo = "1.jpg",
                Score = 10.0
                },
                   new Student
                {
                     Id = "002",
                Name = "asdf",
                BirthDate = DateTime.Parse("10/23/2020"),
                Photo = "1.jpg",
                Score = 7.0
                },
                      new Student
                {
                     Id = "003",
                Name = "aaaa",
                BirthDate = DateTime.Parse("10/23/2020"),
                Photo = "1.jpg",
                Score = 4.5
                }

            };
        }
    }
}
