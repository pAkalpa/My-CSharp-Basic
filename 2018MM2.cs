/*
 * @Author: Pasindu Akalpa 
 * @Date: 2020-09-11 23:57:29 
 * @Last Modified by: Pasindu Akalpa 
 * @Last Modified time: 2020-09-11 23:57:29 
 */
using System;

public struct student
{
    public string name;
    public int age, itNu;
}

class mmq1
{
    static void Main(string[] args)
    {
        student s1;
        s1.name = (args[0]);
        s1.age = int.Parse(args[1]);
        s1.itNu = int.Parse(args[2]);

        Console.WriteLine("You Have Entered Following Details\nName: {0}\nAge: {1}\nIT Number: IT{2}",s1.name,s1.age,s1.itNu);
    }
}