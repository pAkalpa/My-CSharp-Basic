using System;

class mmq1
{
    static void Main(string[] args)
    {
        int physM = int.Parse(args[0]);
        int chemM = int.Parse(args[1]);
        int mathM = int.Parse(args[2]);

        mmq1 t1 = new mmq1();
        int ans1 = t1.calSum(physM, chemM, mathM);
        string ans2 = t1.checkPass(ans1, mathM);

        Console.WriteLine("Total: {0}\nThe Candidate is {1} for admission",ans1,ans2);

    }
    
    int calSum(int a, int b, int c)
    {
        int sum = (a + b + c);
        return sum;
    }

    string checkPass(int d, int e)
    {
        string eli = "";
        eli = (d >= 180 || e >= 80)? "Eligible": "not Eligible";
        return eli;
    }
}