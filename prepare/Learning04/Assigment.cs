using System;

class Assigment{
    private string _studentName = "";
    private string _topic = "";

    public Assigment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;

    }
    public string GetStudentName(){
        return _studentName;
    }
    public string GetTopic(){
        return _topic;
    }

    public string GetSumary(){
        return $"{_studentName} _ {_topic}";
    }
}