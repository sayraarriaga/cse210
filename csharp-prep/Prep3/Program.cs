using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber =randomGenerator.Next(1,100);
         int guessNumber = -1;
         

    while (guessNumber != magicNumber){
      
        Console.WriteLine("What is your guess?");
        string input2 = Console.ReadLine();
        guessNumber = int.Parse(input2);

        if(guessNumber > magicNumber)
    {
        Console.WriteLine("Lower");
    }
      else if(guessNumber < magicNumber)
    {
        Console.WriteLine("Higher");
    }
      else if(guessNumber == magicNumber)
    {
        Console.WriteLine("You guessed it!");
    }
    
   
    }

    }
}