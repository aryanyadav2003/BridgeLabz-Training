using System;
using System.Text;
class StringConcatenation
{
    static void Main(){
    int n=10;
    Console.WriteLine("Operations: " + n);
    int stringOps = ConcatenateUsingString(n);
    int builderOps = ConcatenateUsingStringBuilder(n);
    Console.WriteLine("String operations count      : " + stringOps);
    Console.WriteLine("StringBuilder operations     : " + builderOps);
}
static int ConcatenateUsingString(int n)
    {
        string result="";
        int operations=0;
        for(int i = 0; i < n; i++)
        {
            result+=result+"a";
            operations+=result.Length;
        }
        return operations;
    }
    static int ConcatenateUsingStringBuilder(int n)
    {
        StringBuilder sb=new StringBuilder();
        int operations=0;
        for(int i = 0; i < n; i++)
        {
            sb.Append("a");
            operations++;
        }
        return operations;
    }
}