using System;
using LabFourClassLib;

class Program
{
    static void Main()
    {
        string test1 = "Hello";
        string test2 = "world";

        Console.WriteLine($"'{test1}' starts with an uppercase? {test1.StartsWithUpper()}");
        Console.WriteLine($"'{test2}' starts with an uppercase? {test2.StartsWithUpper()}");
    }
}
