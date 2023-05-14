using System;

class Activity{
    private string _startMessage;
    private string _startMessage2;
    private string _endMessage;
    private string _endMessage2;
    private string _time;
    private List<string> _listAnimation;

    public Activity(string startMessage, string startMessage2, string endMessage, string endMessage2, string time){
        _startMessage = startMessage;
        _startMessage2 = startMessage2;
        _endMessage = endMessage;
        _endMessage2 = endMessage2;
        _time = time;
        _listAnimation = new List<string>();
        _listAnimation.Add("|");
        _listAnimation.Add("/");
        _listAnimation.Add("-");
        _listAnimation.Add("\\");
        _listAnimation.Add("|");
        _listAnimation.Add("/");
        _listAnimation.Add("-");
        _listAnimation.Add("\\");

    }

    public string GetStartMessage(){
        return _startMessage;
    }

     public string GetStartMessage2(){
        return _startMessage2;
    }
     public string GetEndMessage(){
        return _endMessage;
    }
    public string GetTime(){
        return _time;
       
    }
    public string GetEndMessage2(){
        return _endMessage2;
    }
    public string SetEndMessage2(){
        return _endMessage2;
    }
    public string SetStartMessage(){
        return $"{_startMessage}.";
    }
    public string SetStartMessage2(){
        return $"{_startMessage2}";
    }
    public string SetTime(){
        return $"{_time}";
    }

    public string SetEndMessage(){
         
        return $"{_endMessage}.";
    }
    public void DisplayGetReady(){
        Console.WriteLine("Get Ready...");
    }
    public void DisplaySpinner(){
        
        foreach(string s in _listAnimation){
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            
            
        }
    }
    public void DisplayCountDown(){
   
    Console.Write("You may begin in: ");
    for(int i=6; i>0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
 }
    
    }
}
