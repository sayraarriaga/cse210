using System;

class Program
{
    static void Main(string[] args)
    {
        
       
        Product p = new Product("case for Iphone", "789036", 10.50, 2);
        Product p2 = new Product("earrings", "679076", 4.50, 1);
        Product p3 = new Product("Necklace", "105428", 7.90, 3);

        Order o = new Order();
        o._products.Add(p);
        o._products.Add(p2);
        o._products.Add(p3);
        Console.WriteLine("Products:");
        o.DisplayProduct();
        Adress a = new Adress("valle de las Palmas", "Matamoros", "Tamaulipas", "Mexico");
        Customer c = new Customer("Cecilia Canabal");
        Console.WriteLine("Total:");
        Console.WriteLine(o.GetGrandTotal());
        Console.WriteLine();
        Console.WriteLine(c.ShippingLabel());
        Console.WriteLine(a.SetAdress());
     
        
        
        
        
        
    }
}