using System;

class Program
{
    static void Main(string[] args)
    {
       Adress a1 = new Adress("Cornelia street", "New York City", "New York State", "USA");
       Lectures l1 = new Lectures("Michael Gates Gill", "30", "Memorial Sports Medicine Journal Lecture","Memorial Sports Medicine Journal Lecture is an educational meeting with a structured format curated to appeal to a variety of Sports Medicine disciplines", "11/27/23", "4:00 pm", "Lecture");
       l1.DisplayDetails();
       Console.WriteLine(a1.SetAdress());
       Console.WriteLine();
       l1.DisplayLecturesInfo();
       Console.WriteLine(a1.SetAdress());
       Console.WriteLine();
       l1.DisplayShortDescription();
       Console.WriteLine();


       Adress a2 = new Adress("Paseo de Montejo", "Merida", "Yucatan", "Mexico");
       OutdoorGathering o1 = new OutdoorGathering("Sunny", "Michaels Birthday Party","Michaels Birthday Party is an Outdor event. family and friends will gather for a barbecue and outdoor recreational activities ", "07/11/23", "6:00 pm", "Outdoor Gathering");
       o1.DisplayDetails();
       Console.WriteLine(a2.SetAdress());
       Console.WriteLine();
       o1.DisplayOutdoorInfo();
       Console.WriteLine(a2.SetAdress());
       Console.WriteLine();
       o1.DisplayShortDescription();
       Console.WriteLine();


       Adress a3 = new Adress("Brickyard St", "Long Beach", "California", "USA");
       Receptions r1 = new Receptions("reception@gmail.com", "New Year Party"," New Year Party is an event to say goodbye to 2023 and recive the 2024 ", "31/12/23", "8:00 pm", "Reception");
       r1.DisplayDetails();
       Console.WriteLine(a3.SetAdress());
       Console.WriteLine();
       r1.DisplayReceptionInfo();
       Console.WriteLine(a3.SetAdress());
       Console.WriteLine();
       r1.DisplayShortDescription();

       
       
    }


}