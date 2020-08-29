using System;

class exam
{
    static void Main(string[] args)
    {
        Console.Write("Enter the Charge 1:");
        float charge1 = float.Parse(Console.ReadLine());
        Console.Write("Enter the Charge 2:");
        float charge2 = float.Parse(Console.ReadLine());
        Console.Write("Enter the Distance:");
        float distance = float.Parse(Console.ReadLine());

        double elecFce = 8.998 * (charge1 * charge2)/(distance * distance);

        Console.WriteLine("Electrostatic force is {0}",elecFce);
    }
}