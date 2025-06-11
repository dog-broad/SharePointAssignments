using System;

class ReportCard
{
    static void Main()a
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Standard (STD): ");
        string standard = Console.ReadLine();

        Console.Write("Enter Division (Div): ");
        string division = Console.ReadLine();

        Console.Write("Enter the number of subjects: ");
        int numSubjects = int.Parse(Console.ReadLine());

        double totalMarks = 0;
        for (int i = 0; i < numSubjects; i++)
        {
            Console.Write($"Enter marks for subject {i + 1}: ");
            totalMarks += double.Parse(Console.ReadLine());
        }

        double averageScore = totalMarks / numSubjects;

        Console.WriteLine("\n*Report Card");
        Console.WriteLine($"* Name of the candidate :- {name}\t\t\t*");
        Console.WriteLine($"* STD:- {standard}\t\t\t\t\t\t*");
        Console.WriteLine($"* Div:- {division}\t\t\t\t\t\t*");
        Console.WriteLine($"* Average Score :- {averageScore:f2}\t\t\t\t*");
        Console.WriteLine("");
    }
}'