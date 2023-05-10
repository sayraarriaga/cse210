using System;

class MathAssigment : Assigment{
    private string _textBookSection;
    private string _problems;
    
    public MathAssigment(string studentName, string topic, string textBookSection, string problems) 
    : base(studentName, topic){
        _textBookSection = textBookSection;
        _problems = problems;
    }
        public string GetHomework(){
        return $"{_textBookSection} Porblems {_problems}";
        }

    }
