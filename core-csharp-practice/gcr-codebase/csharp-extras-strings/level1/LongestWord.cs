using System;
class LongestWord{
  static void Main(){
    string input=Console.ReadLine();
	string[] words=input.Split(' ');
	string longest="";
	foreach(string word in words){
	  if(word.Length>longest.Length){
	    longest=word;
	  }
	}
	Console.Write(longest);
  }
}