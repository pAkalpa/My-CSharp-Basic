using System;

class test
{
    static void Main(string[] args)
    {
        int[] A = new int[9]{1,5,5,-2,0,705,11,500,2000};
        int total = 0;
        for (int i = 0; i < A.Length; i++)
        {
            total += A[i];
        }
        Console.WriteLine("Total is = {0}",total);
    }
}