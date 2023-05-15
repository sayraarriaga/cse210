using System;

class Program
{
    static void Main(string[] args)
    {
        /*Square square = new Square("orange", 5);
        square.SetColor();
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("red", 3, 6);
        rectangle.SetColor();
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("blue", 8);
        circle.SetColor();
        Console.WriteLine(circle.GetArea());*/
        
        List<Shape> shapes = new List<Shape>();
       Square s1 = new Square("orange", 5);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("red", 3, 6);
        shapes.Add(s2);

        Circle s3 = new Circle("blue", 8);
        shapes.Add(s3);

        foreach ( Shape s in shapes){

        
        string color = s.GetColor();
        double area = s.GetArea();

        Console.WriteLine($"The {color} shape has an area of {area}");
        }
        
    }

    }

    
            
        
