using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Dictionary<string, int> original =
            new Dictionary<string, int>(){{ "A", 1 },{ "B", 2 },{ "C", 1 }
        };

        Dictionary<int, List<string>> inverted = new Dictionary<int, List<string>>();

        foreach (var entry in original)
        {
            int value = entry.Value;
            string key = entry.Key;

            if (!inverted.ContainsKey(value))
            {
                inverted[value] = new List<string>();
            }

            inverted[value].Add(key);
        }
        foreach (var entry in inverted)
        {
            Console.Write(entry.Key + " = [ ");
            foreach (string k in entry.Value)
                Console.Write(k + " ");
            Console.WriteLine("]");
        }
    }
}
