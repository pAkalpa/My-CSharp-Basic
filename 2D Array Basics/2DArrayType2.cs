/*
 * @Author: Pasindu Akalpa 
 * @Date: 2020-10-12 15:45:03 
 * @Last Modified by: Pasindu Akalpa
 * @Last Modified time: 2020-10-12 15:45:23
 */
using System;

class test
{
    static void Main(string[] args)
    {
        int[,] A = new int[2,5]{{1,5,5,-2,0},{705,11,500,2000,8935}};
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