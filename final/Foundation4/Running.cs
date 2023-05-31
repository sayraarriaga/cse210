using System;
class Running:Activity{
    private double _distance;

    public Running(double distance, string date, string activity, double lenght): base(date, activity, lenght){
     _distance = distance;
    }
    
    
    public override double GetDistance(){
        return _distance;

        
    }
     public override double GetSpeed(){
        double min = SetLenght();
        double speed = (_distance / min) * 60;
        return speed;
    }
    public override double GetPace(){
        double min = SetLenght();
       double pace = min / _distance;
        return pace;
    }
}