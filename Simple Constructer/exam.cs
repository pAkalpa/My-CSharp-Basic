using System;
namespace Curtin
{
    public class exam
    {
        public double finalMarks;
        public double midMarks;
        public double assignmentMarks;

        public exam(double fm,double mm,double am)
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