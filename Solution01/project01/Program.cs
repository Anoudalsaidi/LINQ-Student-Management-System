using System;
using System.Collections.Generic;
using System.Linq;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create List of Students
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Ali", Age = 20, Department = "CS", Grade = 90 },
                new Student { Id = 2, Name = "Sara", Age = 22, Department = "IT", Grade = 75 },
                new Student { Id = 3, Name = "Mona", Age = 21, Department = "CS", Grade = 88 },
                new Student { Id = 4, Name = "Omar", Age = 23, Department = "IS", Grade = 60 },
                new Student { Id = 5, Name = "Lina", Age = 20, Department = "IT", Grade = 95 },
                new Student { Id = 6, Name = "Ahmed", Age = 24, Department = "CS", Grade = 70 }
            };

            // ==============================
            // Get students with grade > 80
            // Using Where()
            // ==============================
            var highGrades = students.Where(s => s.Grade > 80);

            Console.WriteLine("Students with Grade > 80:");

            foreach (var student in highGrades)
            {
                Console.WriteLine(student.Name);
            }

            // ==============================
            // Print only student names
            // Using Select()
            // ==============================
            var names = students.Select(s => s.Name);

            Console.WriteLine("\nAll Student Names:");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // ==============================
            // Get first student in CS department
            // Using FirstOrDefault()
            // ==============================
            var firstCS = students.FirstOrDefault(s => s.Department == "CS");

            Console.WriteLine("\nFirst Student in CS Department:");

            if (firstCS != null)
            {
                Console.WriteLine(firstCS.Name);
            }

            // ==============================
            // Sort students by grade descending
            // Using OrderByDescending()
            // ==============================
            var sortedStudents = students.OrderByDescending(s => s.Grade);

            Console.WriteLine("\nStudents Sorted By Grade:");

            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.Name} - {student.Grade}");
            }

            // ==============================
            // Calculate average grade
            // Using Average()
            // ==============================
            var averageGrade = students.Average(s => s.Grade);

            Console.WriteLine($"\nAverage Grade: {averageGrade}");

            // ==============================+
            // Count students in IT department
            // Using Count()
            // ==============================+
            var itCount = students.Count(s => s.Department == "IT");

            Console.WriteLine($"\nNumber of IT Students: {itCount}");

            // =============================
            // Get highest grade
            // Using Max()
            // =============================
            var highestGrade = students.Max(s => s.Grade);

            // Get top student
            var topStudent = students.FirstOrDefault(s => s.Grade == highestGrade);

            Console.WriteLine($"\nTop Student: {topStudent.Name}");
        }
    }
}