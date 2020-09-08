/*
 * @Author: Pasindu Akalpa 
 * @Date: 2020-09-04 18:26:31 
 * @Last Modified by: Pasindu Akalpa
 * @Last Modified time: 2020-09-08 20:39:29
 */
using System;

class corneaCare
{
    static void Main(string[] args)
    {
        string patientName;
        float lecp, recp;
        int lea, rea;

        while(true)
        {
            //Input Patient Name
            Console.Write("Enter Patient Name: ");
            patientName = Console.ReadLine();

            ;//Convert Left Eye Cylinder Power to float
            Console.Write("Enter the Left Eye Cylinder Power ");
            lecp = float.Parse(Console.ReadLine());

            //convert Left Eye Axis to integer 
            Console.Write("Enter Left Eye Axis ");
            lea = int.Parse(Console.ReadLine());

            //Right Eye
            Console.Write("Enter the Right Eye Cylinder Power ");
            recp = float.Parse(Console.ReadLine());

            //Right Eye
            Console.Write("Enter Right Eye Axis ");
            rea = int.Parse(Console.ReadLine());


            corneaCare np = new corneaCare();
            float ans = np.calculateSpherEq(lecp,recp);

            //print values to console
            Console.WriteLine("\nLeft Eye: {0} {1}\nRight Eye: {2} {3}\nCalculated Spherical Equivalent is: {4}",lecp,lea,recp,rea,ans);

            // check input yes or no
            Console.Write("\nDo you to enter another Prescription (y/n)? ");
            char choise = char.Parse(Console.ReadLine());
            if (choise == 'n'|| choise == 'N')
            {
                // break loop
                break;
            }
            else
            {
                // else continue loop
                continue;
            }
        }

        //print thank you if input is 'n' or 'N'
        Console.WriteLine("Thank you for choosing Cornea Care.");
    }

    // calculate Spherical Equivalent
    float calculateSpherEq(float lecp,float recp)
    {
        float sphEq = (lecp+recp)/2f;
        return sphEq;
    }
}