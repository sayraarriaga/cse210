using System;
class Lectures:Event{
    private string _speaker;
    private string _capacity;
    
    public Lectures(string speaker, string capacity, string titleName, string description, string date, string time, string type): base(titleName, description, date, time, type){
     _speaker = speaker;
     _capacity = capacity;
    }
      
      public void DisplayLecturesInfo(){
        string titleName = GetEventTitle();
        string description = GetDescription();
        string date = GetDate();
        string time = GetTime();
        Console.WriteLine($"Event: {titleName}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity} persons");
        Console.WriteLine($"Date: {date}. Time:{time}");

    }
  


}