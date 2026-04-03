using System;
class DataTypes
{
    static void Main()
    {
        byte b = 122;
        short s = 2000;
        int i = 998;
        long l = 9876500000;
        float f = 10.5f;
        double d = 12.22;
        char ch = 'A';
        bool isTrue = true;
        string stringValue = "234";
        string name = "Aryan Yadav";

        Console.WriteLine("Byte : " + b);
        Console.WriteLine("Short : " + s);
        Console.WriteLine("Integer : " + i);
        Console.WriteLine("Long : " + l);
        Console.WriteLine("Float : " + f);
        Console.WriteLine("Double : " + d);
        Console.WriteLine("Character : " + ch);
        Console.WriteLine("Boolean : " + isTrue);
        Console.WriteLine("Name : " + name);

        // Type Casting
        int a = 10;
        double result1 = a;
        Console.WriteLine("Implicit Casting (int to double): " + result1);

        double x = 45.67;
        int y = (int)x;
        Console.WriteLine("Explicit Casting (double to int): " + y);

        int stringToInt = Convert.ToInt32(stringValue);
        Console.WriteLine("String to int: " + stringToInt);

        string intToString = i.ToString();
        Console.WriteLine("Integer to string: " + intToString);
    }
}
