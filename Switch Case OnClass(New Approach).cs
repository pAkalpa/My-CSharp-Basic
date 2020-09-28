using System;

class quiz
{
    int m1Cnt = 0;//Movie 1 Count,Storing Variable
    int m2Cnt = 0;//Movie 2 Count,Storing Variable
    int m3Cnt = 0;//Movie 3 Count,Storing Variable

    static void Main(string[] args)
    {
        //Method Declaration
        quiz d1 = new quiz();

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
            d1.cntVote(line);
        }
        //Call Vote Display Method
        d1.displayVotes(d1.m1Cnt,d1.m2Cnt,d1.m3Cnt);
    }

    //This Method is used for Display Vote Count
    void displayVotes(int a,int b,int c)
    {
        //Print Values on Terminal
        Console.WriteLine("\nVotes\nThe God Father = {0}\nTwilight = {1}\nHarry Potter = {2}",a,b,c);
    }

    /*This method is used for Count Votes
        
        Important Part!!
        Used 3 Integer as Return Type for variable m1Cnt,m2Cnt,m3Cnt
            |
            |
            |
            |
            V     */
    (int,int,int) cntVote (string a)
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