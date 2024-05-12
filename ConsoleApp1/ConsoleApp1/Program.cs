// See https://aka.ms/new-console-template for more information
using ProblemSolution.MaxInWindow;

Console.WriteLine("Hello, World!");
MaxWindow maxWindow = new MaxWindow();
var result = maxWindow.SlidingMaximum(new List<int> { 1, 3, -1, -3, 5, 3, 6, 7 }, 3);
foreach (var v in result)
{
    Console.WriteLine(v);
}
Console.ReadLine();