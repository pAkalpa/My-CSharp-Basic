using System;

class Arithmetic {
    static void Main(String[] args) {
        string num1, num2;

        Console.Write("Input Number 1 :");
        num1 = Console.ReadLine();
        Console.Write("Input Number 2 :");
        num2 = Console.ReadLine();

        int x = int.Parse(num1);
        int y = int.Parse(num2);

        int sum = x + y;
        int diff = x - y;
        int mul = x * y;
        int div = x / y;
        int mod = x % y;
        int z = 2+9*2-7/4+4-5/(7%30);
        Console.WriteLine("\nSum :{0}\nDiff :{1}\nMul :{2}\nDiv :{3}\nMod :{4}\nValue of z :",sum,diff,mul,div,mod,z);
    }
}