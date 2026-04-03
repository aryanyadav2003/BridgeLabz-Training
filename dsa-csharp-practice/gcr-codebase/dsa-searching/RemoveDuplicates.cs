using System;
using System.Text;
using System.Collections.Generic;
class RemoveDuplicates
{
    static void Main()
    {
         Console.Write("Enter a string: ");
         string input=Console.ReadLine();
         HashSet<char> seen=new HashSet<char>();
         StringBuilder result=new StringBuilder();
         foreach(char ch in input)
        {
            if (!seen.Contains(ch))
            {
                seen.Add(ch);
                result.Append(ch);
            }
        }
        Console.WriteLine("String after removing duplicates: " + result.ToString());
    }
}