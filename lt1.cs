using System;

class lectureT {
    static void Main(String[] args) {
        Console.Write("Enter Marks between 0-30 :");
        double marks = double.Parse(Console.ReadLine());
        double passM = (marks/30)*100;

        if((marks > 0)&&(marks<30)&&(marks >= passM)) {
            Console.WriteLine("Pass");
        }
        else if{
            Console.WriteLine("Failed");
        }
        if(marks)
    }
}