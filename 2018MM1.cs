/*
 * @Author: Pasindu Akalpa 
 * @Date: 2020-09-12 11:58:41 
 * @Last Modified by: Pasindu Akalpa
 * @Last Modified time: 2020-09-12 12:18:52
 */
using System;

class exam
{
    static void Main(string[] args)
    {
        int Count = 1;
        int rCnt = 0;
        float attper = 0;

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

        exam e1 = new exam();
        string ans1 = e1.checkEligible(attper);
        float ans2 = e1.calPercent(rCnt, sess);

        Console.WriteLine("Attendance Percentage is: {0}",ans2);
        Console.WriteLine("The Candidate {0} eligible for sit for the final exam.",ans1);

    }
    string checkEligible (float a)
    {
        string word = (a >= 80)?"is":"is not";
        return word;
    }

    float calPercent (int b, float c)
    {
        float attper = b/c * 100f;
        return attper;
    }
}
