using System;

class quiz
{
    static void Main(string[] args)
    {
        int m1Cnt = 0;
        int m2Cnt = 0;
        int m3Cnt = 0;

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "STOP")
            {
                break;
            }

            switch (line)
            {
                case "RT TheGodFather 1":
                    m1Cnt++;
                break;
                case "RT Twilight 2":
                    m2Cnt++;
                break;
                case "RT HarryPotter 3":
                    m3Cnt++;
                break;
                default:
                    Console.WriteLine("Error");
                break;
            }
        }
        quiz d1 = new quiz();
        d1.displayVotes(m1Cnt,m2Cnt,m3Cnt);
    }
    void displayVotes(int a,int b,int c)
    {
        Console.WriteLine("\nVotes\nThe God Father = {0}\nTwilight = {1}\nHarry Potter = {2}",a,b,c);
    }
}