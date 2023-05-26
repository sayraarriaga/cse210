using System;

class Order{
    public  List<Product> _products = new List<Product>();
    public Order(){
       

}


public double GetGrandTotal(){
    Adress a = new Adress("", "", "", "");
    string country = a.GetCountry();
    double shippingPrice;
    if (country == "usa"){
        shippingPrice = 5;
    }
    else{
        shippingPrice = 35;
    }
    double granTotal = -1;
    foreach(Product product in _products){
       double t = product.GetTotal();
       granTotal = t + t + shippingPrice;
    }
    return granTotal;

}
public void DisplayProduct(){
    foreach(Product p in _products){
        p.DisplayProduct();
    }
}
}
