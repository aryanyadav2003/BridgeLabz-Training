using System;
class WordLength{
  static int GetStringLength(string s){
    int cnt=0;
	foreach(char c in s){
	  cnt++;
	}
	return cnt;
  }
  static string[,] splitWords(string text){
    int wordcnt=0;
	bool inWord=false;
	for(int i=0;i<text.Length;i++){
	  if(text[i]!=' ' && !inWord){
	    wordcnt++;
		inWord=true;
	  }
	  else if(text[i]==' '){
	    inWord=false;
	  }
	}
	string[,] result=new string[wordcnt,2];
	int idx=0;
	string word="";
	for(int i=0;i<=text.Length;i++){
	 if(i<text.Length && text[i]!=' '){
	   word+=text[i];
	 }
	 else if(word!=""){
	  result[idx,0]=word;
	  result[idx,1]=GetStringLength(word).ToString();
	  idx++;
	  word="";
	 }
	}
	return result;
  }
  static void Main(){
        Console.Write("Enter a sentence: ");
        string input=Console.ReadLine();
        string[,] words=splitWords(input);
        for (int i=0;i<words.GetLength(0);i++){
            Console.WriteLine(words[i,0] + "  " + words[i,1]);
        }
}}