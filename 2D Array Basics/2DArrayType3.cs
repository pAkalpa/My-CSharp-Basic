/*
 * @Author: Pasindu Akalpa 
 * @Date: 2020-10-12 15:45:06 
 * @Last Modified by: Pasindu Akalpa
 * @Last Modified time: 2020-10-12 15:52:52
 */
using System;

class test
{
    static void Main(string[] args)
    {
        int[,] A = new int[2,5];
        A[0,0] = 1;
        A[0,1] = 5;
        A[0,2] = 5;
        A[0,3] = -2;
        A[0,4] = 0;
        A[1,0] = 705;
        A[1,1] = 11;
        A[1,2] = 500;
        A[1,3] = 2000;
        A[1,4] = 8935;

        for (int i = 0; i < A.GetLength(0); i++)//for Rows
        {
            for (int j = 0; j < A.GetLength(1); j++)//for Columns
            {
                Console.Write("{0}\t",A[i,j]);
            }
            Console.WriteLine("");
        }
    }
}