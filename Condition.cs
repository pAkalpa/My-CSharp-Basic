using System;

class Average {
    static void Main(String[] args) {
        Console.Write("Enter Marks Between 0-30 :");
        int marks1 = int.Parse(Console.ReadLine());
        float avg = 30*0.45f;

        if (marks1 >= 0 && marks1 <= 30 && marks1 >= avg) {
            Console.WriteLine("Pass");
        }else if (marks1 < 0 || marks1 > 30) {
            Console.WriteLine("Invalid Input");
        }else{
            Console.WriteLine("Fail");
        }
    }
}