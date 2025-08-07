// See https://aka.ms/new-console-template for more information
using MiniLINQPlayground.Logic;
using MiniLINQPlayground.Logic.Exercises;
using MiniLINQPlayground.Models;

var students = new List<Student> {
    new Student {Name = "Fahad", Marks =  58 }, 
    new Student {Name = "Arpit", Marks = 72 },
    new Student {Name = "Shekhar", Marks = 80 }
};

var result = students.GroupBy(student => student.Marks > 70);

foreach (var kvp in result)
{
    Console.WriteLine($"Key : {kvp.Key}");
    foreach (var student in kvp)
    {
        Console.WriteLine($"  {student.Name} - {student.Marks}");
    }
}