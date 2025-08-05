using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        // Example logic
        Console.WriteLine("Welcome to the Grade Calculator!");

        Console.Write("Enter marks: ");
        int marks = int.Parse(Console.ReadLine());

        if (marks >= 80)
            Console.WriteLine("Grade: A");
        else if (marks >= 70)
            Console.WriteLine("Grade: B");
        else if (marks >= 60)
            Console.WriteLine("Grade: C");
        else if (marks >= 50)
            Console.WriteLine("Grade: D");
        else
            Console.WriteLine("Grade: F");
    }
}
