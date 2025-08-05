// See https://aka.ms/new-console-template for more information
using MiniLINQPlayground.Logic;

var numbers = new List<int> { 1, 2, 3, 4, 5 };

// Mini Where Test
var evens = numbers.MiniWhere(n => n % 2 == 0);
Console.WriteLine("Even numbers:");
foreach (var n in evens)
{
    Console.WriteLine(n);
}

