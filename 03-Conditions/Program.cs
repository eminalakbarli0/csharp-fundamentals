/*
 * Topic: Conditions in C#
 * Description: Demonstrates if, else, else if,
 * nested if statements and switch.
 */

using System;

class Program
{
    static void Main()
    {
        int age = 20;

        // if statement
        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }

        // if...else statement
        int score = 65;

        if (score >= 50)
        {
            Console.WriteLine("You passed the exam.");
        }
        else
        {
            Console.WriteLine("You failed the exam.");
        }

        // if...else if...else statement
        int grade = 85;

        if (grade >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Grade: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Grade: C");
        }
        else
        {
            Console.WriteLine("Grade: F");
        }

        // Nested if
        bool hasTicket = true;
        bool hasID = true;

        if (hasTicket)
        {
            if (hasID)
            {
                Console.WriteLine("Entry allowed.");
            }
            else
            {
                Console.WriteLine("ID required.");
            }
        }

        // switch statement
        int day = 3;

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;

            case 2:
                Console.WriteLine("Tuesday");
                break;

            case 3:
                Console.WriteLine("Wednesday");
                break;

            default:
                Console.WriteLine("Unknown day");
                break;
        }
    }
}
