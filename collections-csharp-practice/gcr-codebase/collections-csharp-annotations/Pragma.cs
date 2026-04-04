using System;
using System.Collections;

class Program
{
    static void Main()
    {
#pragma warning disable 618   

        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add("Hello");
        list.Add(3.14);

#pragma warning restore 618   

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
