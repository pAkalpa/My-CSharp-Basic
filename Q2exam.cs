using System;

public struct Fruit
{
    public string FruitName;
    public int FruitID;
    public double VitaminRatio;
}

class exam 
{
    static void Main(string[] args)
    {
        Fruit f1;
        string nuLvl = ""; // <--------------------------------- Use these type of null variables to store values inside loops

        Console.Write("Enter the Vitamin Ratio  :");
        f1.VitaminRatio = float.Parse(Console.ReadLine());
        Console.Write("Fruit Name :");
        f1.FruitName = Console.ReadLine();
        Console.Write("Enter the Fruit ID:");
        f1.FruitID = int.Parse(Console.ReadLine());

        if(f1.VitaminRatio <= 8 && f1.VitaminRatio >=6)
        {
            //Console.Write("Fruit {0} has a Vitamin Ratio of {1} which has a Bad Level of nutrients",f1.FruitName,f1.VitaminRatio);
            nuLvl = "Bad";
        }
        else if (f1.VitaminRatio <= 11 && f1.VitaminRatio >=9)
        {
            //Console.Write("Fruit {0} has a Vitamin Ratio of {1} which has a Good Level of nutrients",f1.FruitName,f1.VitaminRatio);
            nuLvl = "Good";
        }
        else if (f1.VitaminRatio >= 12)
        {
            //Console.Write("Fruit {0} has a Vitamin Ratio of {1} which has a Excellent Level of nutrients",f1.FruitName,f1.VitaminRatio);
            nuLvl = "Excellent";
        }
        Console.Write("Fruit {0} has a Vitamin Ratio of {1} which has a {2} Level of nutrients",f1.FruitName,f1.VitaminRatio,nuLvl);
    }
}