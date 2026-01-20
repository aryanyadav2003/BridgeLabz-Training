using System;
class FrequencyOfElement
{
    static void Main()
    {
        string[] input = { "apple", "banana", "apple", "orange" };
        Dictionary<string,int> frequency=new Dictionary<string,int>();
        foreach(string s in input)
        {
            if (frequency.ContainsKey(s))
            {
                frequency[s]++;
            }
            else
            {
                frequency[s]=1;
            }
        }
        foreach(var v in frequency)
        {
            Console.WriteLine(v.Key + " : " + v.Value);
        }
    }
}