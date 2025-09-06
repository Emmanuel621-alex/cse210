using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt for the first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

    S    // Prompt for the last nameS
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Output the name in the required format
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
