/*
 * @Author: Pasindu Akalpa 
 * @Date: 2020-10-01 00:28:27 
 * @Last Modified by: Pasindu Akalpa 
 * @Last Modified time: 2020-10-01 00:28:27 
 */
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