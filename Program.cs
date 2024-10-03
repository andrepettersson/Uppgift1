using System;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Uppgift1
{
    public class Program
    {
        static List<Course> courses = new List<Course>();
        static List<Student> students = new List<Student>();
        static List<Teacher> teachers = new List<Teacher>();
        static List<EducationLeader> educationLeaders = new List<EducationLeader>();
        static List<Admin> admins = new List<Admin>();

        public static void Main()
        {
         
            var course1 = new Course
            {
                CourseNumber = "M100",
                Title = "Matematik",
                LengthOfCourse = "8 Veckor",
                StartDate = new DateTime(2024, 9, 10),
                EndDate = DateTime.Now.AddMonths(2),
                ClassRoomOrDistance = "Distans"
            };
            courses.Add(course1);

            var course2 = new Course
            {
                CourseNumber = "E200",
                Title = "Engelska",
                LengthOfCourse = "12 Veckor",
                StartDate = new DateTime(2024, 2, 9),
                EndDate = DateTime.Now.AddMonths(2),
                ClassRoomOrDistance = "Klassrum"
            };
            courses.Add(course2);

           
            var student1 = new Student
            {
                Name = "Kajsa",
                LastName = "Börjesson",
                PhoneNumber = "075695555",
                Address = "Bamsevägen 2",
                ZipCode = "15569",
                City = "Klågerup",
                SocialSecurityNumber = "1589654885"
            };
            students.Add(student1);

           
            var teacher1 = new Teacher
            {
                Name = "Anna",
                LastName = "Svensson",
                PhoneNumber = "0756988543",
                Address = "Lärargatan 12",
                ZipCode = "12345",
                City = "Vinslöv",
                SocialSecurityNumber = "1234567890",
                KnowledgeInfo = "Engelska, Svenska och Matematik",
                EmploymentDate = new DateTime(2019, 8, 1)
            };
            teachers.Add(teacher1);

           
            var educationLeader1 = new EducationLeader
            {
                Name = "Sven",
                LastName = "Karlsson",
                PhoneNumber = "0765432123",
                Address = "Krokvägen 2",
                ZipCode = "115669",
                City = "Malmö",
                SocialSecurityNumber = "4565465456",
                EmploymentDate = new DateTime(2022, 8, 4)
            };
            educationLeaders.Add(educationLeader1);

        
            var admin1 = new Admin
            {
                Name = "Magnus",
                LastName = "Svenningsson",
                PhoneNumber = "0735522669",
                Address = "Åkesvägen 8",
                ZipCode = "669955",
                City = "Cypern",
                SocialSecurityNumber = "1488336699",
                EmploymentDate = new DateTime(2021, 6, 5)
            };
            admins.Add(admin1);

            
            ListAllStudents();
            ListAllTeachers();
            ListAllCourses();
            ListAllEducationLeaders();
            ListAllAdmins();
        }

        static void ListAllStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Inga studenter är tillagda.");
                return;
            }

            Console.WriteLine("\nStudenter:");
            foreach (var student in students)
            {
                Console.WriteLine(student.AddStudentInfo());
            }
        }

        static void ListAllTeachers()
        {
            if (teachers.Count == 0)
            {
                Console.WriteLine("Inga lärare är tillagda.");
                return;
            }

            Console.WriteLine("\nLärare:");
            foreach (var teacher in teachers)
            {
                Console.WriteLine(teacher.TeacherInfo());
            }
        }

        static void ListAllCourses()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("Inga kurser valda");
                return;
            }

            Console.WriteLine("\nKurser:");
            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseInfo());
            }
        }

        static void ListAllEducationLeaders()
        {
            if (educationLeaders.Count == 0)
            {
                Console.WriteLine("Ingen ledare tillagd");
                return;
            }

            Console.WriteLine("\nUtbildningsledare:");
            foreach (var educationLeader in educationLeaders)
            {
                Console.WriteLine(educationLeader.EducationLeaderInfo());
            }
        } 

        static void ListAllAdmins()
        {
            if (admins.Count == 0)
            {
                Console.WriteLine("Ingen Admin tillagd");
                return;
            }

            Console.WriteLine("\nAdministratörer:");
            foreach (var admin in admins)
            {
                
                Console.WriteLine(admin.AddAdminInfo());
            }
             var options = new JsonSerializerOptions();

             options.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize(courses, options);
            File.WriteAllText("courses.json", jsonString);

        }
    }
}