using System;

class Program
{
    // Function 1: DisplayWelcome
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function 2: PromptUserName
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Function 3: PromptUserNumber
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Function 4: SquareNumber
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function 5: DisplayResult
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }

    // Main method
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squared = SquareNumber(userNumber);

        DisplayResult(userName, squared);
    }
}
