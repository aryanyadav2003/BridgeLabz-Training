using System;
class ReverseString{
    static string ReverseText(string text){
        string reversed = "";
        for (int i=text.Length-1;i>=0;i--){
            reversed+=text[i];
        }
        return reversed;
    }
    static void Main(){
        Console.Write("Enter a string: ");
        string input=Console.ReadLine();
        string result=ReverseText(input);
        Console.WriteLine("Reversed String: " + result);
    }
}
