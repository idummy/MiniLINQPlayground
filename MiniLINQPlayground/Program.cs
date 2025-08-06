// See https://aka.ms/new-console-template for more information
using MiniLINQPlayground.Logic;
using MiniLINQPlayground.Models;

var numbers = new List<int>{23,54,676,34,54,4,3,5,56,3};


var result = numbers.MiniAggregate((a, b) => a + b);

Console.WriteLine(result);  