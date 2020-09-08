using System;

class exam 
{
    static void Main(string[] args)
    {
        int Count = 1;
        while(Count <= 7)
        {
            Console.WriteLine("Web Development Project {0}",Count);
            Console.Write("Enter Budget at Completion: ");
            float bac =  float.Parse(Console.ReadLine());// input budget
            Console.Write("Enter Earned Value: ");
            float ev = float.Parse(Console.ReadLine());//input earned value


            double estComp = 7100 + (Math.Log10(bac-ev)); //equation to find estimate at completion
            double rndestComp = Math.Round(estComp,3);  //rounded value of estimate at completion 

            Console.WriteLine("Estimate at Completion: {0}\nRounded Answer {1}",estComp,rndestComp); //print estimate at completion and rounded value of estimate at completion
            Count++;

            if(rndestComp >= 7100)
            {
                Console.WriteLine("The Project is at High Risk.\n");
            }
            else if(rndestComp < 7100)
            {
                Console.WriteLine("The Project is at Low Risk.\n");
            }
            else if(rndestComp < 0)
            {
                Console.WriteLine("Error Calculation\n");
            }
        }
    }
}