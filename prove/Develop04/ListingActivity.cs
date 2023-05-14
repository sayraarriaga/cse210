using System;
class ListingActivity:Activity{
    private List<string> _listingList;
    private List<string> _inputList;
    public ListingActivity(string startMessage, string startMessage2,  string endMessage, string endMessage2, string time): base(startMessage, startMessage2,endMessage, endMessage2, time ){
        _listingList = new List<string>();
        _listingList.Add("Who are people that you appreciate?");
        _listingList.Add("What are personal strengths of yours?");
        _listingList.Add("Who are people that you have helped this week?");
        _listingList.Add("When have you felt the Holy Ghost this month?");
        _listingList.Add("Who are some of your personal heroes?");
        _inputList = new List<string>();
    }
    public string GetRandomListing(){
          Random random = new Random();
        int numberPrompt = random.Next(_listingList.Count);
        string randomPrompt = _listingList[numberPrompt];
        return randomPrompt;
    }

    public List<string> ReturnInputList(){
        return _inputList;
    }

    public void DisplayNumberOfITems(){
        Console.WriteLine($"You Listed {_inputList.Count} items!");
    }
    
}