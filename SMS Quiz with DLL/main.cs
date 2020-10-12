using basefile;
using System;

namespace Main
{
    class mainProg
    {
        static void Main(string[] args)
        {
            vCnt v1 = new vCnt();
            while (true)
            {
                //User Input 
                string line = Console.ReadLine();

                //If User Input "STOP" Break Loop
                if (line == "STOP")
                {
                    break;
                }
                //Call Vote Count Method
                v1.cntVote(line);
            }
            //Call Vote Display Method
            v1.displayVotes(v1.m1Cnt,v1.m2Cnt,v1.m3Cnt);
        }
    }
}