using System;

public struct HeartPatient 
{
    public string Name,Gender;//varibles to store name and gender
    public int age;//variables to store age
    public float SCholesterol;//variables to strore Cholesterol
}

class exam 
{
    static void Main(string[] args)
    {
        HeartPatient hp1;//new HeartPatient called hp1

        Console.Write("Enter the Name: ");
        hp1.Name = Console.ReadLine();//Input Patient Name
        Console.Write("Enter the Gender: ");
        hp1.Gender = Console.ReadLine();//Input Patient Gender
        Console.Write("Enter the age: ");
        hp1.age = int.Parse(Console.ReadLine());//Input Patient Age
        Console.Write("Enter the Total serum cholesterol: ");
        hp1.SCholesterol = float.Parse(Console.ReadLine());//Input Patient Cholesterol level and convert to float

        if (hp1.Gender == "Female" || hp1.Gender == "Male" && hp1.age >= 20)//check gender and age
        {
            if (hp1.SCholesterol < 125)//check colesterol level less than 125
            {
                Console.WriteLine("Hello {0}, your cholesterol level is Low",hp1.Name);
            }
            else if (hp1.SCholesterol >= 125 && hp1.SCholesterol <= 200)//check colesterol level in between of 125 and 200
            {
                Console.WriteLine("Hello {0}, your cholesterol level is Normal",hp1.Name);
            }
            else if (hp1.SCholesterol > 200)//check colesterol level larger than 200
            {
                Console.WriteLine("Hello {0}, your cholesterol level is High",hp1.Name);
            }
        }
        else if (hp1.age <= 19)//check age less than or equl to 19
        {
            Console.WriteLine("Hello {0}, your cholesterol level is High",hp1.Name);
        }
    }
}