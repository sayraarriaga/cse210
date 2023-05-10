using System;

class Program
{
    static void Main(string[] args)
    {
        Assigment a1 = new Assigment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSumary());

        MathAssigment a2 = new MathAssigment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSumary());
        Console.WriteLine(a2.GetHomework());

        WritingAssigment a3 = new WritingAssigment("Mary Waters", "European History", "The Causes of World War II");
         Console.WriteLine(a3.GetSumary());
         Console.WriteLine(a3.GetWritingInformation());
        
    }
}