using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        string filePath = "input.txt";
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        int totalWords = 0;
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.ToLower().Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        totalWords++;
                        if (wordCount.ContainsKey(word))
                            wordCount[word]++;
                        else
                            wordCount[word] = 1;
                    }
                }
            }
            Console.WriteLine("Total Words: " + totalWords);
            Console.WriteLine("\nTop 5 Most Frequent Words:");
            var topWords = wordCount.OrderByDescending(w => w.Value).Take(5);
            foreach (var item in topWords)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
