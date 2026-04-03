using System;
class FormatExceptionDemo{
    static void Main(){
        try{
            Console.Write("Enter a number: ");
            string input = "abc";
            int number = int.Parse(input);
            Console.WriteLine("Number: " + number);
        }
        catch(FormatException e)
        {
            Console.WriteLine("FormatException occurred!");
            Console.WriteLine(e.Message);
        }
    }
}
