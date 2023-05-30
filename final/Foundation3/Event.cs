using System;
class Event{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private string _type;
    
    

    public Event(string eventTitle, string description, string date, string time, string type){
    _eventTitle = eventTitle;
    _description = description;
    _date = date;
    _time = time;
    _type = type;


    }
    public string GetEventTitle(){
        return _eventTitle;
    }
    public string GetDescription(){
        return _description;
    }
    public string GetDate(){
        return _date;
    }
    public string GetTime(){
        return _time;
    }
     public string GetEventType(){
        return _type;
    }

public void DisplayDetails(){
       
        Console.WriteLine($"{_eventTitle}, {_description}. {_date}, {_time}");
    }

     public void DisplayShortDescription(){
     
        Console.WriteLine($"{_eventTitle}, {_type}, {_date} ");
      
        

    }
    

}