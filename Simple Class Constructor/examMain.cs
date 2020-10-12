/*
 * @Author: Pasindu Akalpa 
 * @Date: 2020-10-12 17:26:18 
 * @Last Modified by: Pasindu Akalpa
 * @Last Modified time: 2020-10-12 17:27:01
 */
using Curtin;
using System;

namespace mainProg
{
    class mainP
    {
        static void Main(string[] args)
        {
            exam e = new exam(10,20,30);//Class Constructor
            e.displayMarks();
        }
    }
}