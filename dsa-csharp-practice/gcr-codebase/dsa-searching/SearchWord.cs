using System;
class SearchWord
{
    static void Main()
    {
        Console.Write("Enter number of sentences: ");
        int n=int.Parse(Console.ReadLine());
        string[] sentences = new string[n];
         for (int i = 0; i < n; i++)
        {
            Console.Write("Enter sentence " + (i + 1) + ": ");
            sentences[i] = Console.ReadLine()!;
        }
        Console.Write("Enter word to search: ");
        string word = Console.ReadLine();
        Console.Write("\nEnter word to search: ");
        int index=-1;
        for(int i = 0; i < n; i++)
        {
            if (sentences[i].Contains(word))
            {
                index=i;
                break;
            }
        }
        if (index != -1)
        {
            Console.WriteLine("Word found in sentence:");
            Console.WriteLine(sentences[index]);
        }
        else
        {
            Console.WriteLine("Word not found in any sentence.");
        }
    }
}