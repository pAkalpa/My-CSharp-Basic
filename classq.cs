using System;

class test
{
    static void Main(string[] args)
    {
        //variable declaration for radius height and area
        float radi, hei, area;

        //Take User Input for Radius
        Console.Write("Input Radius of Cylinder :");
        radi = float.Parse(Console.ReadLine());

        //Take User Input for Radius
        Console.Write("Input Height of Cylinder :");
        hei = float.Parse(Console.ReadLine());

        test nt = new test();
        double ans = nt.areaCal(radi,hei);

        //Display Output(Area) in Console
        Console.WriteLine("Area of Cylinder :{0}",ans);
    }
    //calculate area
    double areaCal(float radi,float hei)
    {
        double area = 2 * Math.PI * radi * hei + (2 * Math.PI * (radi * radi));
        return area;
    }
}