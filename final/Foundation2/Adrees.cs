using System;
class Adress{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Adress(string street, string city, string state, string country){
        _street =street;
        _city = city;
        _state = state;
        _country = country;

    }

    public string GetStreet(){
        return _street;
    }
    public string GetCity(){
        return _city;
    }
    public string GetState(){
        return _state;
    }
    public string GetCountry(){
        return _country;
    }

    public string SetCountry(){
        string countryShipping;
        if (_country == "USA"){
            countryShipping = "usa";
            }
        else
            {
            countryShipping = "other";
            }
        
        return countryShipping;
    }

    public string SetAdress(){
        return $"{_street}. {_city}, {_state}. {_country}";
    }
}