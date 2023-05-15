using System;
class Rectangle:Shape{
    private double _lenght;
    private double _width;

public Rectangle(string color, double lenhght, double width): base(color){
    _lenght = lenhght;
    _width = width;
}
public override double GetArea(){
    return _lenght * _width;
}

}