/*
 * Topic: Operators in C#
 * Description: Demonstrates arithmetic, assignment,
 * comparison, and logical operators.
 */

using System;

class Program
{
    static void Main()
    {
        int a = 20;
        int b = 6;

        // Arithmetic Operators
        Console.WriteLine("Arithmetic Operators");
        Console.WriteLine($"Addition: {a + b}");
        Console.WriteLine($"Subtraction: {a - b}");
        Console.WriteLine($"Multiplication: {a * b}");
        Console.WriteLine($"Division: {a / b}");
        Console.WriteLine($"Remainder: {a % b}");

        // Assignment Operators
        Console.WriteLine("\nAssignment Operators");

        int number = 10;

        number += 5;
        Console.WriteLine(number);

        number -= 3;
        Console.WriteLine(number);

        number *= 2;
        Console.WriteLine(number);

        // Comparison Operators
        Console.WriteLine("\nComparison Operators");

        Console.WriteLine(a == b);
        Console.WriteLine(a != b);
        Console.WriteLine(a > b);
        Console.WriteLine(a < b);
        Console.WriteLine(a >= b);
        Console.WriteLine(a <= b);

        // Logical Operators
        Console.WriteLine("\nLogical Operators");

        bool hasJob = true;
        bool knowsCSharp = true;

        Console.WriteLine(hasJob && knowsCSharp);
        Console.WriteLine(hasJob || knowsCSharp);
        Console.WriteLine(!hasJob);

        // Increment / Decrement
        Console.WriteLine("\nIncrement / Decrement");

        int x = 5;

        x++;
        Console.WriteLine(x);

        x--;
        Console.WriteLine(x);
    }
}
