using System;

class test
{
    static void Main(string[] args)
    {
        int[] A = {1,5,5,-2,0,705,11,500,2000};
        Array.Sort(A);
        Array.Reverse(A);
		
        foreach (int item in A)
        {
            Console.WriteLine(item);
        }
    }
}