using System;
using System.IO;
public class Journal{
 
      public List<Entry> _entriesList;

      public Journal(){
      _entriesList= new List<Entry>();
      }
      
        public void CreateJournalEntry(){

       /*PromptGenerator randomPrompt = new PromptGenerator();
       string prompt = randomPrompt.GetRandomPrompt();
       Console.WriteLine(prompt);
       string userInput = Console.ReadLine();
       string currentDate = DateTime.Now.ToString();
        Entry newEntry = new Entry();
        newEntry._date =currentDate;
        newEntry._prompt=prompt;
        newEntry._response = userInput;
        _entriesList.Add(newEntry);*/
        
    }
    
     public void DisplayJournalEntries(){
       foreach (Entry entry in _entriesList)
        {
          
          entry.DisplayEntries();
        }
        

    }
   

   public void SaveToCSV(){
   
     Console.WriteLine("What is the name of the file?");
     String name = Console.ReadLine();

     string fileName = $"{name}.txt";
     using (StreamWriter outputFile = new StreamWriter(fileName))
{
    
    outputFile.WriteLine(_entriesList);
    
}
    
   }

   

   public void LoadFromCSV(){

   Console.WriteLine("What is the name of the file?");
     string filename = Console.ReadLine();
  
  string[] lines = System.IO.File.ReadAllLines(filename);

   foreach (string line in lines)
{
    string[] parts = line.Split(",");

    string date = parts[0];
    string prompt = parts[1];
    string response = parts[2];
}
   }
  
}