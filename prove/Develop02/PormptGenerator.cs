using System;
 public class PromptGenerator{
    public string _prompt;

  
public string GetRandomPrompt(){
   Random randomGenerator = new Random();
     int random = randomGenerator.Next(1,5);
     string promt = "";

     if (random == 1){
        promt = "What is Something that i am Grateful today?";
     }
     else if (random == 2){
        promt = "What was the best part of your day?";

     }
     else if (random == 3){
        promt = "What was something that i learned today?";

    }
    else if (random == 4){
        promt = "What was the most interesting thing you saw today?";

    }
    else{
        promt = "Who was one person that made you happy to see today?";
    } 
      return promt;
      
}
    
/*
    public void GetRandomePrompt(){
        Random randomGenerator = new Random();
     int random = randomGenerator.Next(1,5);
     string _promt = "";

     if (random == 1){
        _promt = "What is Something that i am Grateful today?";
     }
     else if (random == 2){
        _promt = "What was the best part of your day?";

     }
     else if (random == 3){
        _promt = "What was something that i learned today?";

    }
    else if (random == 4){
        _promt = "What was the most interesting thing you saw today?";

    }
    else{
        _promt = "Who was the person that made you more happy to see today";
    }

    Console.WriteLine("{_promt}");

 }*/
 }