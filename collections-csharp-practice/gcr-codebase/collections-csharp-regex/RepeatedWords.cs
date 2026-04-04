using System;
using System.Text.RegularExpressions;
class RepeatedWprds
{
    static void Main()
    {
        string input = "This is is a repeated repeated word test.";
        string pattern = @"\b(\w+)\s+\1\b";
        MatchCollection matches = Regex.Matches(input,pattern,RegexOptions.IgnoreCase);
        foreach (Match match in matches)
        {
            Console.Write(match.Groups[1].Value + ", ");
        }
    }
}
