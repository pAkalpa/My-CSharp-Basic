/*
 * @Author: Pasindu Akalpa 
 * @Date: 2020-09-04 14:22:34 
 * @Last Modified by:   ------------- 
 * @Last Modified time: 2020-09-04 14:22:34 
 */
using System;

public struct patientData
{
    public string name;// varibles to store name 
    public int lea,rea;// variables to store left and right eye axis 
    public float lecp,recp;// variables to strore left and right Cylinder Power 
}

class CorneaCare
{
    static void Main(string[] args)
    {
        patientData p1;//new patientData called p1 
        while(true)//run loop infinite without condition 
        {
            Console.Write("Enter Patient Name: ");
            p1.name = Console.ReadLine();//Input Patient Name 
            Console.Write("Enter the Left Eye Cylinder Power ");
            p1.lecp = float.Parse(Console.ReadLine());//Convert Left Eye Cylinder Power to float 
            Console.Write("Enter Left Eye Axis ");
            p1.lea = int.Parse(Console.ReadLine());//convert Left Eye Axis to integer 
            Console.Write("Enter the Right Eye Cylinder Power ");
            p1.recp = float.Parse(Console.ReadLine());//Right Eye 
            Console.Write("Enter Right Eye Axis ");
            p1.rea = int.Parse(Console.ReadLine());//Right Eye 

            CorneaCare cc = new CorneaCare();

            float answer = cc.CalculateSE(p1.lecp,p1.recp);

            Console.WriteLine("\nLeft Eye: {0} {1}\nRight Eye: {2} {3}\nCalculated Spherical Equivalent is: {4}",p1.lecp,p1.lea,p1.recp,p1.rea,answer);//print values to console
            End();
            
        }
        Console.WriteLine("Thank you for choosing Cornea Care."); //print thank you if input is 'n' or 'N'
    }

    static float CalculateSE(p1.lecp, p1.recp)
    {
        float sphEq = (p1.lecp + p1.recp)/2.0f;// Calculation of Spherical Equivalent
        return sphEq;
    }
    /*static void End()
    {
        Console.Write("\nDo you to enter another Prescription (y/n)? ");
            char choise = char.Parse(Console.ReadLine());
            if (choise == 'n'|| choise == 'N')// check input yes or no
            {
                break; // break loop
            }
            else
            {
                continue;// else continue loop
            }
    }*/
}