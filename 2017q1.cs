using System;

public struct subjectData
{
    public int phys, chem, math;
}

class exam
{
    static void Main(string[] args)
    {
        subjectData sub1;
        Console.Write("Input the marks obtained in Physics :");
        sub1.phys = int.Parse(Console.ReadLine());
        //int phys = int.Parse(Console.ReadLine());
        Console.Write("Input the marks obtained in Chemistry :");
        sub1.chem = int.Parse(Console.ReadLine());
        //int chem = int.Parse(Console.ReadLine());
        Console.Write("Input the marks obtained in Mathematics :");
        sub1.math = int.Parse(Console.ReadLine());
        //int math = int.Parse(Console.ReadLine());

        int total = (sub1.phys + sub1.chem + sub1.math);
        //int total = (phys + chem + math);
        Console.WriteLine("Total: {0}",total);
        
        if (total >= 180 || sub1.math >= 80)
        {
            Console.WriteLine("The Candidate is eligible for admission");
        }
        else
        {
            Console.WriteLine("The Candidate is not eligible for admission");
        }
    }
}