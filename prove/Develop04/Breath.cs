using System;
class Breath:Activity{

private string _startBreath;
private string _endBreath;

public Breath(string startBreath, string endBreath, string startMessage, string startMessage2, string time, string endMessage, string endMessage2): base(startMessage, startMessage2, time, endMessage, endMessage2){
 _startBreath = startBreath;
 _endBreath = endBreath;
}
public string GetStartBreathing(){
    return _startBreath;
}
public string GetEndBreathing(){
    return _endBreath;
}



public string SetStartBreathing(){    
    
    return $"{_startBreath}";
}

public string SetEndBreathing(){
    return $"{_endBreath}";
    
}
public void DisplayStartBreathing(){
    string sBreathing = SetStartBreathing();
    Console.WriteLine();
    Console.WriteLine();
    Console.Write(sBreathing);
    for(int i=4; i>0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }

}
public void DisplayEndBreathing(){
    string eBreathing = SetEndBreathing();
     Console.WriteLine();
    Console.Write(eBreathing);
    for(int i=6; i>0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            
        }

}
}
