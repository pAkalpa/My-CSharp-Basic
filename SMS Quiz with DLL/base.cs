using System;

namespace basefile
{
    public class vCnt
    {
        public int m1Cnt = 0;//Movie 1 Count,Storing Variable
        public int m2Cnt = 0;//Movie 2 Count,Storing Variable
        public int m3Cnt = 0;//Movie 3 Count,Storing Variable

        public void displayVotes(int a,int b,int c)
        {
            //Print Values on Terminal
            Console.WriteLine("\nVotes\nThe God Father = {0}\nTwilight = {1}\nHarry Potter = {2}",a,b,c);
        }
        public (int,int,int) cntVote (string a)
        {
            switch (a)
            {
                case "RT TheGodFather 1":
                    m1Cnt++;//Increment Movie 1 Count by 1
                break;
                case "RT Twilight 2":
                    m2Cnt++;//Increment Movie 2 Count by 1
                break;
                case "RT HarryPotter 3":
                    m3Cnt++;//Increment Movie 3 Count by 1
                break;
                default:
                    Console.WriteLine("Error");//Display Error on Wrong User input
                break;
            }
            //Returning Values for Vote Display Method
            return(m1Cnt,m2Cnt,m3Cnt);
        }
    }
}