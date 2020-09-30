using System;

class test
{
    static void Main(string[] args)
    {
        int[] A = new int[9];
		
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = int.Parse(Console.ReadLine());
        }
		
        foreach (int item in A)
        {
            Console.WriteLine("{0}",item);
        }
    }    
}