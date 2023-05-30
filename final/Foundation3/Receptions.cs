using System;
class Receptions:Event{
    private string _email;
    

    public Receptions(string email, string eventTitle, string description, string date, string time, string type): base(eventTitle, description, date, time, type){
    _email = email;
    }
 

    public void DisplayReceptionInfo(){
        string titleName = GetEventTitle();
        string description = GetDescription();
        string date = GetDate();
        string time = GetTime();
        Console.WriteLine($"Event: {titleName}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Date: {date}. Time:{time}");
        Console.WriteLine($"Email for RSVP: {_email}");

    }
}