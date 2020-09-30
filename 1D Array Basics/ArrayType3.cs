/*
 * @Author: Pasindu Akalpa 
 * @Date: 2020-10-01 00:28:19 
 * @Last Modified by: Pasindu Akalpa 
 * @Last Modified time: 2020-10-01 00:28:19 
 */
using System;

class test
{
	static void Main(string[] args)
	{
		int[] A = new int[9]; 
		A[0] = 1;
		A[1] = 5;
		A[2] = 5;
		A[3] = -2;
		A[4] = 0;
		A[5] = 705;
		A[6] = 11;
		A[7] = 500;
		A[8] = 2000;
		
		foreach (int item in A)
        {
            Console.WriteLine(item);
        }
	}
}