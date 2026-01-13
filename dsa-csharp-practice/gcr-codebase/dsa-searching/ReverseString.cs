using System;
using System.Text;
class ReverseString
{ 
    static void Main(){
    Console.Write("Enter a string : ");
    string input=Console.ReadLine();
    StringBuilder sb=new StringBuilder();
    for(int i = input.Length - 1; i >= 0;i--)
    {
           sb.Append(input[i]); 
    }
     Console.WriteLine("Reversed String: " + sb.ToString());
    }
}