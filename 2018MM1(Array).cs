/*
 * @Author: Pasindu Akalpa 
 * @Date: 2020-10-09 10:38:37 
 * @Last Modified by: Pasindu Akalpa
 * @Last Modified time: 2020-10-09 10:40:45
 */
using System;

class exam
{
    int pCnt = 0;
    int abCnt = 0;

    static void Main(string[] args)
    {
        int sessNo = 0;
        string subCode = "";

        Console.Write("Enter the Subject Code: ");
        subCode = Console.ReadLine();
        Console.Write("Enter the No of Sessions: ");
        sessNo = int.Parse(Console.ReadLine());

        exam e1 = new exam();
        e1.attenCnt(sessNo);
        float ans1 = e1.calPercent(e1.pCnt,sessNo);
        string ans2 = e1.checkEligibility(ans1);

        Console.WriteLine("\nTotal attendence for Subject {0}: {1}",subCode,e1.pCnt);
        Console.WriteLine("Attendance Percentage is: {0}",ans1);
        Console.WriteLine("The Candidate {0} eligible for sit for the final exam.",ans2);
    }
    
    (int,int) attenCnt (int a)
    {
        string[] A = new string[a];
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write("Attendance for Session No {0}: ",i+1);
            A[i] = Console.ReadLine();
        }
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == "Present")
            {
                pCnt++;
            }
            else if(A[i] == "Absent")
            {
                abCnt++;
            }
        }
        return(pCnt,abCnt);
    }

    float calPercent (int a, float b)
    {
        float attper = a/b * 100f;
        return attper;
    }

    string checkEligibility (float a)
    {
        string eli = (a > 80)? "is":"is not";
        return eli;
    }
}