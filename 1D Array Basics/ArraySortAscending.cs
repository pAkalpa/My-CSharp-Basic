/*
 * @Author: Pasindu Akalpa 
 * @Date: 2020-10-01 00:26:50 
 * @Last Modified by: Pasindu Akalpa
 * @Last Modified time: 2020-10-01 00:27:41
 */
using System;

class test
{
    static void Main(string[] args)
    {
        int[] A = {1,5,5,-2,0,705,11,500,2000};
        Array.Sort(A);

        foreach (int item in A)
        {
            Console.WriteLine(item);
        }
    }
}