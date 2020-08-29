
/*
 * @Author: Pasindu Akalpa 
 * @Date: 2020-07-30 02:09:58 
 * @Last Modified by: Pasindu Akalpa
 * @Last Modified time: 2020-08-01 19:07:14
 */
using System;

struct employee_data { // data input structure
    public string name; // employee name
    public int dob,mob,yob; // employee date of birth
 // employee year of birth

    public void Display() {
        Console.WriteLine("\nName of the employee :{0}\nEmployee's day of Birth :{1}\nEmployee's month of Birth :{2}\nEmployee's year of Birth :{3}",name,dob,mob,yob); // Display stored data in console
    }
};

class dataStructure {
    static void Main(String[] args) {
    
        employee_data employee1; 
        Console.Write("Name of the employee :"); //Prompt for name
        employee1.name = Console.ReadLine(); //store name in struct
        Console.Write("Input Day of the Birth :"); //Prompt for day of birth
        employee1.dob = int.Parse(Console.ReadLine()); //Parse string into int and save in variable
        Console.Write("Input Month of the Birth :"); //Prompt for month of birth
        employee1.mob = int.Parse(Console.ReadLine()); 
        Console.Write("Input Year of the Birth :"); //Prompt for year of birth
        employee1.yob = int.Parse(Console.ReadLine());
        employee1.Display(); //call display function
    }
}
