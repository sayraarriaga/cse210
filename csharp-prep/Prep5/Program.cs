using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResults(name, square);

    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");

        }
    static string PromptUserName(){
        Console.WriteLine("Please Write your Name");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(){
        Console.WriteLine("Please Write your favorite number");
        string input = Console.ReadLine();
        int favoriteNumber = int.Parse(input);
        return favoriteNumber;
    }
    static int  SquareNumber(int number){
        int square = number * number;
        return square;
    }
    static void DisplayResults(string name, int square){
        Console.WriteLine($"Brother {name},  the square of your number is {square}.");

}
}