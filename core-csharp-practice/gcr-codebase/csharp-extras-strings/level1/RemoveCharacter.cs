using System;
class RemoveCharacter{
    static string RemoveChar(string text,char ch){
        string result="";
        for(int i=0;i<text.Length;i++){
            if(text[i]!=ch){
                result+=text[i];
            }
        }
        return result;
    }
    static void Main(){
        Console.Write("Enter string: ");
        string input=Console.ReadLine();
        Console.Write("Enter character to remove: ");
        char remove=Console.ReadLine()[0];
        string output=RemoveChar(input, remove);
        Console.WriteLine("Modified String: " + output);
    }
}
