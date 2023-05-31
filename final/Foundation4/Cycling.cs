using System;
class Cycling:Activity{
    private double _speed;

    public Cycling(double speed, string date, string activity, double lenght): base(date, activity, lenght){
     _speed = speed;
    }
    public override double GetSpeed(){
        return _speed;
    }
  

    public override double GetPace(){
        double speed = GetSpeed();
        double pace = 60 / speed;
        return pace;
    }
    public override double GetDistance(){
        double min = SetLenght();
        double pace = GetPace();
        double distance = min / pace;
        return distance;

        
    }
}