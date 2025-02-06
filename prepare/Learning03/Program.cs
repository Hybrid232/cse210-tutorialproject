using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionNum1 = new Fraction();
        Console.WriteLine(fractionNum1.GetFractionString());
        Console.WriteLine(fractionNum1.GetFractionFloat());
        
        Fraction fractionNum2 = new Fraction();
        fractionNum2.SetTop(5);
        Console.WriteLine(fractionNum2.GetFractionString());
        Console.WriteLine(fractionNum2.GetFractionFloat());
        
        Fraction fractionNum3 = new Fraction();
        fractionNum3.SetBothFraction(3, 4);
        Console.WriteLine(fractionNum3.GetFractionString());
        Console.WriteLine(fractionNum3.GetFractionFloat());

        Fraction fractionNum4 = new Fraction();
        fractionNum4.SetBothFraction(1, 3);
        Console.WriteLine(fractionNum4.GetFractionString());
        Console.WriteLine(fractionNum4.GetFractionFloat());



    }   
    
}