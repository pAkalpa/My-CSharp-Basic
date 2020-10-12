/*
 * @Author: Pasindu Akalpa 
 * @Date: 2020-10-12 15:45:09 
 * @Last Modified by: Pasindu Akalpa
 * @Last Modified time: 2020-10-12 15:50:32
 */
using System;

class test
{
    static void Main(string[] args)
    {
        int[,] A = new int[2,5];
        for (int i = 0; i < A.GetLength(0); i++)//for Rows
        {
            for (int j = 0; j < A.GetLength(1); j++)//for Columns
            {
                Console.Write("Enter Numbers for Row {0} Columns {1} ",i,j);
                A[i,j] = int.Parse(Console.ReadLine());
            }
        }

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