using System;
using System.Text;
using System.Collections.Generic;
class ConcatenateString
{
    static void Main()
    {
        Console.Write("Enter number of strings :");
        int n = int.Parse(Console.ReadLine());
        string[] words=new string[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter string " + (i+1) + ": " );
            words[i]=Console.ReadLine();
        }
         StringBuilder sb = new StringBuilder();
         for(int i = 0; i < n; i++)
        {
            sb.Append(words[i]);
        }
        Console.WriteLine("Concatenated String: " + sb.ToString());
    }
}