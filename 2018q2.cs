using System;

public struct student
{
    public string Name;
    public int Age, ITNumber;
}

class exam
{
    static void Main(string[] args)
    {
        student s1;
        Console.Write("Enter the Name: ");
        s1.Name = Console.ReadLine();

        Console.Write("Enter the Age: ");
        s1.Age = int.Parse(Console.ReadLine());

        Console.Write("Enter the IT Number: IT");
        s1.ITNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("\nYou Have Entered the Following Details\nName: {0}\nAge:{1}\nIT Number:IT{2}",s1.Name,s1.Age,s1.ITNumber);
    }
}