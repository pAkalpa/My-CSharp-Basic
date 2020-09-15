using System;

class mmq2
{
    static void Main(string[] args)
    {
        float k = 8.998f;
        float charge1 = float.Parse(args[0]);
        float charge2 = float.Parse(args[1]);
        float distance = float.Parse(args[2]);

        mmq2 t1 = new mmq2();
        double ans = t1.calForce(charge1,charge2,distance,k);

        Console.WriteLine("Electrostatic Force is {0}",Math.Round(ans, 5));
    }
    double calForce(float a, float b, float c, float d)
    {
        double force = d * (a * b)/Math.Pow(c, 2);
        return force;
    }
}