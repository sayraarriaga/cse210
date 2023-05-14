using System;

class Reflection: Activity{
    private List<string> _prompts;
    private List<string> _promptReflection;
    

    public Reflection(string startMessage, string startMessage2, string time, string endMessage, string endMessage2 ): base(startMessage, startMessage2, time, endMessage, endMessage2 )
    {
        _prompts = new List<string>();
        
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult");
        _prompts.Add("Think of a time when you helped someone in need");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _promptReflection = new List<string>();

        _promptReflection.Add("Why was this experience meaningful to you?");
        _promptReflection.Add("Have you ever done anything like this before?");
        _promptReflection.Add("How did you feel when it was complete?");
        _promptReflection.Add("What made this time different than other times when you were not as successful?");
        _promptReflection.Add("What is your favorite thing about this experience?");
        _promptReflection.Add("What could you learn from this experience that applies to other situations?");
        _promptReflection.Add("What did you learn about yourself through this experience?");
        _promptReflection.Add("How can you keep this experience in mind in the future?");
         
    }

    public string GetRandomePromts(){

        Random random = new Random();
        int numberPrompt = random.Next(_prompts.Count);
        string randomPrompt = _prompts[numberPrompt];
        return randomPrompt;
    }

    public string GetRamdomPromptReflection(){
        Random random = new Random();
        int numberPrompt = random.Next(_promptReflection.Count);
        string randomPrompt2 = _promptReflection[numberPrompt];
        return randomPrompt2;

    }

    
}

