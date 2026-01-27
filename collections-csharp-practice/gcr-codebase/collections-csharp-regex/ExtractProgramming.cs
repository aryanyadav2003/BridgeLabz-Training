using System;
using System.Text.RegularExpressions;
class ExtractProgramming
{
    static void Main()
    {
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        string[] languages = { "Java", "Python", "JavaScript", "Go" };
        string pattern = @"\b(" + string.Join("|", languages) + @")\b";
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches)
        {
            Console.Write(match.Value + ", ");
        }
    }
}
