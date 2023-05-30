using System;
class OutdoorGathering: Event{
   private string _weather;
   
   public OutdoorGathering(string weather, string titleName, string description, string date, string time, string type): base(titleName, description, date, time, type){
   _weather = weather;
   
   }

   public string GetWeather(){
      return _weather;
   }

     
  
    public void DisplayOutdoorInfo(){
        string titleName = GetEventTitle();
        string description = GetDescription();
        string date = GetDate();
        string time = GetTime();
        Console.WriteLine($"Event: {titleName}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Date: {date}. Time:{time}");
         Console.WriteLine($"The weather will be: {_weather}");

    }
    

}