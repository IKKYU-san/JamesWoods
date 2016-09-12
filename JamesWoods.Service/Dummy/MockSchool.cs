using JamesWoods.Domain;
using JamesWoods.Domain.Enums;
using System.Collections.Generic;

namespace JamesWoods.Service.Dummy
{
    public static class MockSchool
    {

        // Students

        public static List<Student> AllStudents
        {
            get
            {
                var students = new List<Student>
                {
                    Student1,
                    Student2,
                    Student3
                };

                return students;
            }
        }

        public static Student Student1
        {
            get
            {
                return new Student { Id = 1, FirstName = "Niklas", LastName = "Lindkvist", Email = "niklas@gmail.com", Address = Address1, AttendToCourses = new List<Course> { Cource1, Cource2 } };
            }
        }

        public static Student Student2
        {
            get
            {
                return new Student { Id = 2, FirstName = "Klara", LastName = "Lindkvist", Email = "klara@hotmail.com", Address = Address2, AttendToCourses = new List<Course> { Cource2 } };
            }
        }

        public static Student Student3
        {
            get
            {
                return new Student { Id = 3, FirstName = "Sven", LastName = "Olsson", Email = "sven@countermail.com", Address = Address3, AttendToCourses = new List<Course> { Cource1 } };
            }
        }


        // Addresses

        public static Address Address1
        {
            get
            {
                return new Address { City = "Göteborg", Country = Country.Sweden, Street="Linnégatan 12", ZipCode="413 11" };
            }
        }

        public static Address Address2
        {
            get
            {
                return new Address { City = "Linköping", Country = Country.Sweden, Street = "Storgatan 123", ZipCode = "144 33" };
            }
        }

        public static Address Address3
        {
            get
            {
                return new Address { City = "Göteborg", Country = Country.Sweden, Street = "Marklandsgatan 9B", ZipCode = "432 11" };
            }
        }

        // Courses

        public static List<Course> AllCourses
        {
            get
            {
                return new List<Course> { Cource1, Cource2 };
            }
        }

        public static Course Cource1
        {
            get
            {
                return new Course { Id = 1, Name = "HTML-kurs", Assignements = new List<Assignement> { Assignement1, Assignement2, Assignement3 } };
            }
        }

        public static Course Cource2
        {
            get
            {
                return new Course { Id = 2, Name = "REST-kurs", Assignements = new List<Assignement> { Assignement4, Assignement5 } };
            }
        }

        // Assignements


        public static Assignement Assignement1
        {
            get
            {
                return new Assignement { Id = 1, Name = "HTML Uppgift 1", Order = 1 };
            }
        }

        public static Assignement Assignement2
        {
            get
            {
                return new Assignement { Id = 2, Name = "HTML Uppgift 2", Order = 2 };
            }
        }

        public static Assignement Assignement3
        {
            get
            {
                return new Assignement { Id = 3, Name = "HTML Uppgift 3", Order = 3 };
            }
        }

        public static Assignement Assignement4
        {
            get
            {
                return new Assignement { Id = 4, Name = "REST Uppgift 1", Order = 1 };
            }
        }

        public static Assignement Assignement5
        {
            get
            {
                return new Assignement { Id = 5, Name = "REST Uppgift 2", Order = 2 };
            }
        }


        // Evaluations

        public static List<Evalutation> AllEvaluations
        {
            get
            {
                return new List<Evalutation> { Evaluation1, Evaluation2, Evaluation3, Evaluation4, Evaluation5, Evaluation6, Evaluation7 };
            }
        }

        // Evaluations Student1

        public static Evalutation Evaluation1
        {
            get
            {
                return new Evalutation { Id = 1, Assignement = Assignement1, Comment = "Bra jobbat", Mark = Mark.Perfect, Student = Student1};
            }
        }

        public static Evalutation Evaluation2
        {
            get
            {
                return new Evalutation { Id = 2, Assignement = Assignement2, Comment = "Nja...", Mark = Mark.DontPass, Student = Student1};
            }
        }


        public static Evalutation Evaluation3
        {
            get
            {
                return new Evalutation { Id = 3, Assignement = Assignement3, Comment = "Godkänt", Mark = Mark.Pass, Student = Student1};
            }
        }

        public static Evalutation Evaluation4
        {
            get
            {
                return new Evalutation { Id = 4, Assignement = Assignement4, Comment = "", Mark = Mark.NotEvaluated, Student = Student1 };
            }
        }

        // Evaluations Student2

        public static Evalutation Evaluation5
        {
            get
            {
                return new Evalutation { Id = 5, Assignement = Assignement5, Comment = "Njaaaaa...", Mark = Mark.DontPass, Student = Student2 };
            }
        }

        // Evaluations Student3

        public static Evalutation Evaluation6
        {
            get
            {
                return new Evalutation { Id = 6, Assignement = Assignement1, Comment = "Godkänt", Mark = Mark.Pass, Student = Student3 };
            }
        }


        public static Evalutation Evaluation7
        {
            get
            {
                return new Evalutation { Id = 7, Assignement = Assignement2, Comment = "Ej godkänt", Mark = Mark.DontPass, Student = Student3 };
            }
        }
    }
}
