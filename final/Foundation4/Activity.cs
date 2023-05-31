using System;
class Activity{
    private string _date;
    private string _activity;
    private double _lenght;
    public Activity(string date, string activity, double lenght){
     _date = date;
     _activity= activity;
     _lenght = lenght;

     

    }
    public string SetDate(){
        return _date;
    }
    public string SetActivity(){
        return _activity;
    }
    public double SetLenght(){
        return _lenght;
    }
    public virtual double GetDistance(){
        return -1;

        
    }
    public virtual double GetSpeed(){
        return -1;
    }
    public virtual double GetPace(){
        return -1;
    }
    public string GetMethod(){
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        return $"{_date} {_activity} ({_lenght}min): Distance: {distance} Km, Speed: {speed} Kph, Pace: {pace} min per Km ";
    }

}