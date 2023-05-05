using System;

class Program
{
    static void Main(string[] args)
    {
        // create a menu and user input variable
        //while input is not 5
        //switch statements for user input.
       
       int menuInput =0;

       List<string> menu = new List<string>
       {
            "Please Select one of the following options",
            "1.Write",
            "2.Display",
            "3.Load",
            "4.Save",
            "5-Quit",
            "What would you like to do?"
       };
       while (menuInput !=5)
       {
       foreach(string menuItem in menu)
       {
        Console.WriteLine(menuItem);
       }
       menuInput = int.Parse(Console.ReadLine());

      

       PromptGenerator prompt = new PromptGenerator();
       string userInput = "";
       string currentDate = DateTime.Now.ToString();
       Journal journal = new Journal();
       Entry entry = new Entry();
     
       
        
       switch (menuInput)
       {
        case 1:
        Console.WriteLine(prompt.GetRandomPrompt());
        userInput = Console.ReadLine();
        
       break;
       case 2:
       entry._response= userInput;
        entry._date =currentDate;
        entry._prompt=prompt.GetRandomPrompt();
        journal._entriesList.Add(entry);
        journal.DisplayJournalEntries();
        
       break;

       case 3:
       journal.SaveToCSV();
       break;

       case 4:
       journal.SaveToCSV();
       break;
       }
       
       }
         
       }

    }
