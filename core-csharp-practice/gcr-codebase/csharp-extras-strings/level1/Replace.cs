using System;
class Replace{
 static string ReplaceWord(string sentnce,string oldword,string newword){
   string res="";
   string word="";
   for(int i=0;i<=sentnce.Length;i++){
     if(i<sentnce.Length && sentnce[i]!=' '){
	   word+=sentnce[i];
	 }
	 else{
	   if(word==oldword){
	     res+=newword;
	   }
	   else res+=word;
	   if(i<sentnce.Length) res+=" ";
	   
	   word="";
	 }
   }
   return res;
 }
 static void Main(){
        Console.Write("Enter sentence: ");
        string sentence=Console.ReadLine();
        Console.Write("Word to replace: ");
        string oldWord=Console.ReadLine();
        Console.Write("New word: ");
        string newWord=Console.ReadLine();
        string replaced = ReplaceWord(sentence, oldWord, newWord);
        Console.WriteLine("After replacement: " + replaced);
    }
}