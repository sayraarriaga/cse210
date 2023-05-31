using System;

class Program
{
    static void Main(string[] args)
    {
        /*Running r1 = new Running(4.8, "03 nov 22", "Running", 30);
        r1.GetDistance();
        r1.GetSpeed();
        r1.GetPace();
        Console.WriteLine(r1.GetMethod());

        Cycling c1 = new Cycling(9.7, "03 nov 22", "Cycling", 25);
        c1.GetDistance();
        c1.GetSpeed();
        c1.GetPace();
        Console.WriteLine(c1.GetMethod());

        Swimming s1 = new Swimming(100, "03 nov 22", "Swimming", 30);
        s1.GetDistance();
        s1.GetSpeed();
        s1.GetPace();
        Console.WriteLine(s1.GetMethod());*/


        List<Activity> activities = new List<Activity>();
        Running r1 = new Running(4.8, "03 nov 22", "Running", 30);
        activities.Add(r1);

        Cycling c1 = new Cycling(9.7, "04 nov 22", "Cycling", 25);
        activities.Add(c1);
       
        Swimming s1 = new Swimming(100, "05 nov 22", "Swimming", 30);
        activities.Add(s1);

        foreach(Activity a in activities){
            a.GetDistance();
            a.GetSpeed();
            a.GetPace();
            Console.WriteLine(a.GetMethod());
        }


            
        
    }
}