jenis attribut:
[Obsolete] -> Marks types and type members outdated
[WebMethod] -> To expose a method as an XML wEB sERVCICE method
[Serialize] -> indicates that a class can be serialized
dan banyak lagi

attribut is a class that inherits from a System.Attribute base class


using System;
using System.Collections.Generic;


public class Calculator
{
    public static int Add2(int FirstNumber, int SecondNumber)
    {
        return FirstNumber + SecondNumber;
    }

    public static int Add3(int FirstNumber, int SecondNumber, int ThirdNumber)
    {
        return FirstNumber + SecondNumber + ThirdNumber;
    }

    public static int AddList(List<int> Numbers)
    {
        int sum = 0;
        foreach (int Number in Numbers)
        {
            sum = sum + Number;
        }
        return sum;
    }
}

class Program
{
    public static void Main()
    {
        Calculator C1 = new Calculator();
        //C1.Add2(10, 20);

        Console.WriteLine(Calculator.Add2(10, 20));
        Console.WriteLine(Calculator.Add3(10, 20, 39));
        Console.WriteLine(Calculator.AddList(new List<int>(){ 12, 21, 23, 45, 54 }));




        Console.Read();
    }
}


access-modifier/return-type ngaruh ke pemanggilan methodnya






using System;
using System.Collections.Generic;

public class Calculator
{
    // warning type casting
    [ObsoleteAttribute("Use Add(List<int> Numbers) Method", true)]

    public static int Add(int FirstNumber, int SecondNumber)
    {
        return FirstNumber + SecondNumber;
    }

    public static int Add3(int FirstNumber, int SecondNumber, int ThirdNumber)
    {
        return FirstNumber + SecondNumber + ThirdNumber;
    }

    public static int Add(List<int> Numbers)
    {
        int sum = 0;
        foreach (int Number in Numbers)
        {
            sum = sum + Number;
        }
        return sum;
    }
}

class Program
{
    public static void Main()
    {
        // Calculator C1 = new Calculator();
        //C1.Add2(10, 20);

        //Console.WriteLine(Calculator.Add(10, 20));
        //Console.WriteLine(Calculator.Add3(10, 20, 39));
        Console.WriteLine(Calculator.Add(new List<int>(){ 12, 21, 23, 45, 54 }));




        Console.Read();
    }
}






if someone use another Add method rather than Add class which is define on Obsolete,
the computer would show an error. 