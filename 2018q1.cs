using System;

class exam
{
    static void Main(string[] args)
    {
        int Count = 1;
        int rCnt = 0;

        Console.Write("Enter the Subject Code: ");
        string subCode = Console.ReadLine();

        Console.Write("Enter the number of Sessions : ");
        float sess = float.Parse(Console.ReadLine());

        while(Count <= sess)
        {
            Console.Write("Attendence for Session No {0}: ",Count);
            string attend = Console.ReadLine();
            if (attend == "Present" || attend == "present")
            {
                rCnt++;
            }
            Count++;
        }
        Console.WriteLine("Total Attendance for Subject {0}: {1}",subCode,rCnt);

        float attper = rCnt/sess * 100f;

        Console.WriteLine("Attendance Percentage is: {0}",attper);

        if(attper < 80)
        {
            Console.WriteLine("The Candidate is not eligible for sit for the final exam.");
        }
        else if(attper >= 80)
        {
            Console.WriteLine("The Candidate is eligible for sit for the final exam.");
        }
    }
}