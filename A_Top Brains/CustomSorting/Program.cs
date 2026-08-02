using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Aman", Age = 20, Marks = 75 },
            new Student { Name = "Ravi", Age = 18, Marks = 80 },
            new Student { Name = "Neha", Age = 20, Marks = 60 },
            new Student { Name = "Pooja", Age = 18, Marks = 70 }
        };

        //using LINQ :
        var sortedStudents = students
            .OrderBy(s => s.Age)
            .ThenBy(s => s.Marks)
            .ToList();

        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Name : {student.Name} - Age: {student.Age}, Marks: {student.Marks}");
        }
    }
}
