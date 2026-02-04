using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Net.WebSockets;
using System.Text;
class LexicalTwist
{
    static void Main()
    {
        Console.WriteLine("Enter first word: ");
        string first=Console.ReadLine();
        if (!IsValidWord(first))
        {
            Console.WriteLine(first + "is an invalid word");
        }
        Console.WriteLine("Enter second word: ");
        string second=Console.ReadLine();
        if (!IsValidWord(second))
        {
            Console.WriteLine(second + "is an invalid word");
        }
        if (IsReverse(first, second))
        {
            ProcessReverseCase(first);
        }
        else
        {
            ProcessNonReverseCase(first,second);
        }
    }
    static bool IsValidWord(string word)
    {
        return !word.Contains(" ");
    }
    static bool IsReverse(string word1,string word2)
    {
        char[] arr=word1.ToLower().ToCharArray();
        Array.Reverse(arr);
        string reversed=new string(arr);
        return reversed.Equals(word2.ToLower());
    }
    static bool IsVowel(char c)
    {
        return "AEIOUaeiou".IndexOf(c)!=-1;
    }
    static void ProcessReverseCase(string word)
    {
        char[] arr=word.ToCharArray();
        Array.Reverse(arr);
        string reversed=new string(arr).ToLower();
        StringBuilder result=new StringBuilder();
        foreach(char c in reversed)
        {
            if (IsVowel(c))
            {
                result.Append('@');
            }
            else
            {
                result.Append(c);
            }
        }
        Console.WriteLine(result.ToString());
    }
    static void ProcessNonReverseCase(string w1,string w2)
    {
        string combined=(w1+w2).ToUpper();
        int vowels=0,consonants=0;
        foreach(char c in combined)
        {
            if (char.IsLetter(c))
            {
                if (IsVowel(c))
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
        }
        if (vowels > consonants)
        {
            PrintFirstTwoUnique(combined,true);
        }
         else if (consonants > vowels)
        {
            PrintFirstTwoUnique(combined, false);
        }
        else
        {
            Console.WriteLine("Vowels and consonants are equal");
        }
    }
    static void PrintFirstTwoUnique(string word,bool wantVowels)
    {
        HashSet<char> seen=new HashSet<char>();
        StringBuilder output=new StringBuilder();
        foreach(char c in word)
        {
            if (char.IsLetter(c))
            {
                if(IsVowel(c)==wantVowels && seen.Add(c))
                {
                    output.Append(c);
                    if (output.Length == 2)
                    {
                        break;
                    }
                }
            }
        }
        Console.WriteLine(output.ToString());
    }
}