using System;
class Product{
    private string _productName;
    private string _id;
    private double _price;
    private double _quantity;

    public Product(string productName, string id, double price, double quantity){
    _productName = productName;
    _id = id;
    _price = price;
    _quantity = quantity;
}
public string GetProductName(){
    return _productName;
}
public string GetId(){
    return _id;
}

public double GetPrice(){
    return _price;
}

public double Getquantity(){
    return _quantity;
}
public void DisplayProduct(){
    
    Console.WriteLine( $"{_productName}, ID: {_id}");
}


public double GetTotal(){
    
    double totalPrice = _price * _quantity;
    return totalPrice;
}




}

