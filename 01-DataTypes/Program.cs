/*
 * Topic: Data Types in C#
 * Description: Demonstrates the basic built-in data types,
 * variable declaration, constants, and output using Console.WriteLine().
 */


using System;

class Program
{
    static void Main()
    {
        byte age = 25;
        sbyte temperature = -10;

        short year = 2025;
        ushort points = 500;

        int population = 8500000;
        uint visitors = 4000000000;

        long distance = 922337203685477580;
        ulong stars = 18446744073709551615;

        float height = 1.85f;
        double pi = 3.14159265359;
        decimal balance = 1500.75m;

        char grade = 'A';
        string name = "Emin";

        bool isBackendDeveloper = true;

        const double Gravity = 9.81;

        var country = "USA";

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Temperature: {temperature}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Points: {points}");
        Console.WriteLine($"Population: {population}");
        Console.WriteLine($"Visitors: {visitors}");
        Console.WriteLine($"Distance: {distance}");
        Console.WriteLine($"Stars: {stars}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Pi: {pi}");
        Console.WriteLine($"Balance: {balance}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Backend Developer: {isBackendDeveloper}");
        Console.WriteLine($"Gravity: {Gravity}");
        Console.WriteLine($"Country: {country}");
    }
}
