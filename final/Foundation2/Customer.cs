using System;
class Customer{
    private string _nameCustomer;
     

    public Customer(string nameCostumer){
     _nameCustomer = nameCostumer;
     
    }
    public string GetnameCustomer(){
        return _nameCustomer;
    }
    public string SetnameCustomer(){
        return $"{_nameCustomer}";
    }

    public string ShippingLabel(){
        
        
        return $"Customer: {_nameCustomer}. Adress:";

    }

    

}