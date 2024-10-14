﻿using System;
using System.Collections.Generic;
using System.IO;
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

        static void LoadCourses()
        {
            var path = "Data/courses.json";
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                courses = JsonSerializer.Deserialize<List<Course>>(json) ?? new List<Course>();

                Console.WriteLine($"Antal kurser: {courses.Count}");
            }
        }

        static void Main()
        {
            LoadCourses();

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

            var student2 = new Student
            {
                Name = "Emil",
                LastName = "Svensson",
                PhoneNumber = "0789966332",
                Address = "Skolgatan 78",
                ZipCode = "665599",
                City = "Sjöbo",
                SocialSecurityNumber = "1995636525"
            };
            students.Add(student2);

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

            var teacher2 = new Teacher
            {
                Name = "Göran",
                LastName = "Göransson",
                PhoneNumber = "0785522669",
                Address = "Kapellvägen 8",
                ZipCode = "45698",
                City = "Svenstorp",
                SocialSecurityNumber = "1885522663",
                KnowledgeInfo = "Engelska, Fysik och Idrott",
                EmploymentDate = new DateTime(2011, 2, 2)
            };
            teachers.Add(teacher2);

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
                Console.WriteLine(student.Read());
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
                Console.WriteLine(teacher.Read());
            }
        }

        static void ListAllCourses()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("Inga kurser valda.");
                return;
            }

            Console.WriteLine("\nKurser:");
            foreach (var course in courses)
            {
                Console.WriteLine(course.Read());
            }
        }

        static void ListAllEducationLeaders()
        {
            if (educationLeaders.Count == 0)
            {
                Console.WriteLine("Ingen ledare tillagd.");
                return;
            }

            Console.WriteLine("\nUtbildningsledare:");
            foreach (var educationLeader in educationLeaders)
            {
                Console.WriteLine(educationLeader.Read());
            }
        }

        static void ListAllAdmins()
        {
            if (admins.Count == 0)
            {
                Console.WriteLine("Ingen Admin tillagd.");
                return;
            }

            Console.WriteLine("\nAdministratörer:");
            foreach (var admin in admins)
            {
                Console.WriteLine(admin.Read());
            }
        }
    }
}
