using System;

class CorneaCare
{
    static void Main(string[] args)
    {
        Console.Write("Enter Patient Name: ");
        string name = Console.ReadLine();//Input Patient Name 
        Console.Write("Enter the Left Eye Cylinder Power ");
        float lecp = float.Parse(Console.ReadLine());//Convert Left Eye Cylinder Power to float 
        Console.Write("Enter Left Eye Axis ");
        int lea = int.Parse(Console.ReadLine());//convert Left Eye Axis to integer 
        Console.Write("Enter the Right Eye Cylinder Power ");
        float recp = float.Parse(Console.ReadLine());//Right Eye 
        Console.Write("Enter Right Eye Axis ");
        int rea = int.Parse(Console.ReadLine());//Right Eye

        CorneaCare cc = new CorneaCare();
        float answer = cc.calculateSE(lecp,recp);

        Console.WriteLine(answer);
    }

    float calculateSE(float lecp, float recp)
    {
        float sphEq = (lecp+recp)/2.0f;
        return sphEq;
    }
}