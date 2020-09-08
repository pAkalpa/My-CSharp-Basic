using System;

public struct HeartPatient
{
    public string Name;
    public string Gender;
    public int Age;
    public float SCholesterol;
}

class exam
{
    static void Main(string[] args)
    {
        HeartPatient hp1;

        string chLvl = "";

        Console.Write("Enter the Name:");
        hp1.Name = Console.ReadLine();
        Console.Write("Enter the Gender:");
        hp1.Gender = Console.ReadLine();
        Console.Write("Enter the age:");
        hp1.Age = int.Parse(Console.ReadLine());
        Console.Write("Enter the Total serum cholesterol :");
        hp1.SCholesterol = float.Parse(Console.ReadLine());

        if(hp1.Age <= 19 && hp1.SCholesterol == 170)
        {
            chLvl = "Normal";
        }
        else if(hp1.Age >= 20 && hp1.SCholesterol >= 125 && hp1.SCholesterol <= 200)
        {
            chLvl = "Normal";
        }
        else
        {
            chLvl = "Not Normal";
        }
        Console.WriteLine("Hello {0}, your cholesterol level is {1}",hp1.Name,chLvl);
    }
}