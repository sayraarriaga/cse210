using System;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while(number !=0){ 
        Console.WriteLine("Enter Number");
        string input = Console.ReadLine();
        number = int.Parse(input);
        if(number != 0){
        numbers.Add(number);
        }

        }
    
    
        int sum = 0;
        foreach (int num in numbers){
             sum += num;
            Console.WriteLine($"The sum is: {sum}");
        }

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach(int num in numbers)
    {
        if (num >max){
            max = num;
            Console.WriteLine($"The max number is: {max}");
        }
    }


    }
}