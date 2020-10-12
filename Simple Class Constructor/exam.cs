/*
 * @Author: Pasindu Akalpa 
 * @Date: 2020-10-12 17:26:21 
 * @Last Modified by: Pasindu Akalpa
 * @Last Modified time: 2020-10-12 17:27:08
 */
using System;
namespace Curtin
{
    public class exam
    {
        public double finalMarks;
        public double midMarks;
        public double assignmentMarks;

        public exam(double fm,double mm,double am)//Class Construtor Declration
        {
            this.finalMarks = fm;
            this.midMarks = mm;
            this.assignmentMarks = am;
        }

        public void displayMarks()
        {
            Console.WriteLine("{0} {1} {2}",finalMarks,midMarks,assignmentMarks);
        }
    }
}