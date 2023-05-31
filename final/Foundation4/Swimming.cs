using System;
class Swimming:Activity{
    private int  _numberOfLaps;

    public Swimming(int numberOfLaps, string date, string activity, double lenght): base(date, activity, lenght){
     _numberOfLaps = numberOfLaps;
    }
    public int GetLaps(){
        return _numberOfLaps;
    }
    public override double GetDistance(){
        double distance = _numberOfLaps * 50 / 1000;
        return distance;

        
    }
    public override double GetSpeed(){
        double distance = GetDistance();
        double min = SetLenght();
        double speed = (distance / min) * 60;
        return speed;
    }
    public override double GetPace(){
        double distance = GetDistance();
        double min = SetLenght();
        double pace = min / distance;
        return pace;
    }
}