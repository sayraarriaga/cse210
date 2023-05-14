using System;

class Program
{
    static void Main(string[] args)
    {
          
       int menuInput =0;

       List<string> menu = new List<string>
       {
            "Menu Options",
            "1.Start Breathing Activity",
            "2.Start Reflection Activity",
            "3.Start Listing Activity",
            "4.Quit",
            "Select a choice from the menu"
       };
       while (menuInput !=4)
       {
       foreach(string menuItem in menu)
       {
        Console.WriteLine(menuItem);
       }
       menuInput = int.Parse(Console.ReadLine());

       switch(menuInput){
        case 1:
        Breath breath = new Breath("Breathe in...", "Breathe out...", "Wlcome to the Breathing Activity", "This Activity will help you relax by walking your through breathing in and out by slowly. Clear your mind and focus on your beathing","Well Done!!", "you have complited a sesion of the breathing activity", "How Long, in seconds, Would you like for your sesion?");
        Console.WriteLine(breath.GetStartMessage());
        Console.WriteLine(breath.GetStartMessage2());
        Console.WriteLine(breath.GetTime());
        string timeInput = Console.ReadLine();
        int timeInt = int.Parse(timeInput);
        Console.Clear();
        breath.DisplayGetReady();  
        breath.DisplaySpinner();  
        breath.DisplayStartBreathing();
        breath.DisplayEndBreathing();
        breath.DisplayStartBreathing();
        breath.DisplayEndBreathing();
        breath.DisplayStartBreathing();
        breath.DisplayEndBreathing();
        Console.WriteLine();
        Console.WriteLine(breath.GetEndMessage()); 
        breath.DisplaySpinner(); 
        Console.WriteLine(breath.GetEndMessage2());
        breath.DisplaySpinner();
        Console.Clear();
        Console.WriteLine(menu);
        
        break;
        
       
        case 2:
        Reflection reflection = new Reflection("Welcome to the Reflexion Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Well Done!", "you have complited a sesion of the Reflection activity", "How Long, in seconds, Would you like for your sesion?");
        Console.WriteLine(reflection.GetStartMessage());
        Console.WriteLine(reflection.GetStartMessage2());
        Console.WriteLine(reflection.GetTime());
        string timeInput2 = Console.ReadLine();
        Console.Clear();
        reflection.DisplayGetReady();  
        reflection.DisplaySpinner();  
        Console.WriteLine(reflection.GetRandomePromts());
        Console.WriteLine("When you have something in mind please press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        reflection.DisplayCountDown();
        Console.Clear();
        Console.Write(reflection.GetRamdomPromptReflection());
        reflection.DisplaySpinner();
        Console.WriteLine();
        Console.Write(reflection.GetRamdomPromptReflection());
        reflection.DisplaySpinner();
        Console.WriteLine();
         Console.Write(reflection.GetRamdomPromptReflection());
        reflection.DisplaySpinner();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(reflection.GetEndMessage());
        reflection.DisplaySpinner();  
        Console.WriteLine(reflection.GetEndMessage2());
        reflection.DisplaySpinner();
        Console.Clear();
        Console.WriteLine(menu);
        break;
        
        case 3:
        ListingActivity listing = new ListingActivity("Welcome to the List Activity",  "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.","Well Done!", "you have complited  a sesion of the Listing activity", "How Long, in seconds, Would you like for your sesion?");
        Console.WriteLine(listing.GetStartMessage());
        Console.WriteLine(listing.GetStartMessage2());
        Console.WriteLine(listing.GetTime());
        string timeInput3 = Console.ReadLine();
        Console.Clear();
        listing.DisplayGetReady();  
        listing.DisplaySpinner();  
        Console.WriteLine("List as many responses as you can to the following prommpt (Press Enter when you are done).");
        listing.DisplayCountDown();
        Console.Clear();
        Console.WriteLine(listing.GetRandomListing());
         string inputList = Console.ReadLine();
        List<string> _inputList = listing.ReturnInputList();
        while(inputList != ""){
            inputList = Console.ReadLine();
            _inputList.Add(inputList);
        }
        listing.DisplayNumberOfITems();
        Console.WriteLine();
        Console.WriteLine(listing.GetEndMessage());
        listing.DisplaySpinner();  
        Console.WriteLine(listing.GetEndMessage2());
        listing.DisplaySpinner();
        Console.Clear();
        Console.WriteLine(menu);
        break;
        

        
       }

    
    }

    }   
}