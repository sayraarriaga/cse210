using System;
public class Comment{
    public string _commentName;
    public string _comment;
    public List<Video> _coments = new List<Video>();

    public void Display(){
        Console.WriteLine($"User: {_commentName} : {_comment}");
    }

}