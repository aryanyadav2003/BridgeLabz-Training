using System;
using System.Security.Cryptography;
class WordFrequency
{
    static void Main(){
    string text="Hello world, hello Java!";
    Dictionary<string,int> wordCount=new Dictionary<string,int>();
    char[] separators = { ' ', ',', '.', '!', '?', ';', ':' };
    string[] words = text.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
    foreach(string word in words){
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount[word]=1;
            }
    }
     foreach (var entry in wordCount)
        {
            Console.WriteLine(entry.Key + " : " + entry.Value);
        }
}
}