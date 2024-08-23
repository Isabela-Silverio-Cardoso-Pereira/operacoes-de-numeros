using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("digite o primeiro numero");
        double num1;
        double num2;
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("digite o segundo numero");
        num2= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("SOMA: " + (num1 + num2));
        Console.WriteLine("SUBTRACAO " + (num1 - num2));
        Console.WriteLine("DIVISAO " + (num1 / num2));
        Console.WriteLine("MULTIPLICACAO" + (num1 * num2));

        
    }
}