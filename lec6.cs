using System;

class Operators
{
    static void Main(string[] args)
    {
        int age = int.Parse(args[0]);
        Operators op1 = new Operators();
        string answer = op1.checkAge(age);

        Console.WriteLine("Answer {0}",answer);
    }
    string checkAge(int a)
    {
        String Type = "";
        Type = (a >= 18)? "Adult": "Child";

        return Type;
    }
}