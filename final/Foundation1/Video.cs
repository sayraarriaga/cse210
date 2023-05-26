using System;
public class Video{
    public string _title;
    public string _author;
    public double _lenght;
    
    public List<Comment> _coments = new List<Comment>();

    public void Display(){
      
    Console.WriteLine();
    Console.WriteLine($"Title:{_title}. Author: {_author} Lenght: {_lenght} seconds");
    Console.WriteLine("Comments:");
     foreach(Comment comment in _coments){
        comment.Display();
        }
    }
}
