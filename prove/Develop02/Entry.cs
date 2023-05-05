using System;
public class Entry{
     public string _date;
      public string _prompt;
      public string _response;
  /*public Entry(string date, string prompt, string response){
    date = _date;
    prompt = _prompt;
    response = _response;
  }*/

    public void DisplayEntries(){
        Console.WriteLine($"{_date} {_prompt} {_response} ");
    }
      public string GetEntryAsCSV(){
        // return string.Format("{0}|{1}|{2}", date, prompt, response);
      string entryCsv = $"{_date} {_prompt}{_response}";
      return entryCsv;
   

  }
}