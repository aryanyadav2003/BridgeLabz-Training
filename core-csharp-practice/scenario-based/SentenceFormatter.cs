using System;
class SentenceFormatter{
   static void Main(){
     Console.Write("Enter a paragraph: ");
     string input=Console.ReadLine();
	 if(IsNullOrWithSpace(input)){
	   Console.WriteLine("Input is empty or whitespace");
	   return;
	 }
	 string checkP = CheckPunctuation(input);
	 string capitalized=CapitalAfterPunctuation(checkP);
	 string trimmed=TrimExtraSpaces(capitalized);
	 Console.WriteLine("Formatted Paragraph:");
	 Console.WriteLine(trimmed);
	 
	 int wordCount=CountWords(trimmed);
	 Console.WriteLine("Word Count : " +wordCount);
	 string longestWord=LongestWord(trimmed);
	 Console.WriteLine("Longest Word : " + longestWord);
	 Console.Write("Enter word to replace: ");
	 string oldWord=Console.ReadLine();
	 Console.Write("Enter new word: ");
	 string newWord=Console.ReadLine();
	 string replace=ReplaceWord(trimmed,oldWord,newWord);
	 Console.WriteLine(replace);
   }
   static string CheckPunctuation(string input){
     string ans="";
	 foreach(char ch in input){
	   if((ch=='.' || ch==',' || ch=='!'|| ch=='?' ||ch==':' || ch==';')){
			  ans+=ch;
			  ans+=' ';
	   }
	   else{
	     ans+=ch;
	   }
	 }
	return ans; 
   }
    static string CapitalAfterPunctuation(string input){
	   string ans="";
	   bool capital=true;
	   foreach(char ch in input){
	     if(capital && ch>='a' && ch<='z'){
		   ans+=(char)(ch-32);
		   capital=false;
		 }
		 else{
		   ans+=ch;
		   if (capital && ch >= 'A' && ch <= 'Z'){
                capital = false;
            }
		 }
		 if(ch=='.' || ch=='?' || ch=='!'){
		   capital=true;
		 }
	   }
	   return ans;
	}
	static string TrimExtraSpaces(string input){
	  string ans="";
	  bool space=false;
	  foreach(char ch in input){
	    if(ch==' '){
		  if(!space){
		    ans+=ch;
			space=true;
		  }		  
		}
		else{
		  ans+=ch;
		  space=false;
		}
	  }
	  return ans;
	}
	static int CountWords(string input){
	   int cnt=0;
	   bool inWord=false;
	   foreach(char ch in input){
	   if(ch!=' ' && !inWord){
	      cnt++;
		  inWord=true;
	   }
	   else if(ch==' '){
	     inWord=false;
	   }
	   }
	   return cnt;
	}
	static string LongestWord(string input){
	  string curr="";
	  string longest="";
	  foreach(char ch in input){
	     if(ch!=' '){
		   curr+=ch;
		 }
		 else{
		   if(curr.Length>longest.Length){
		    longest=curr;
		   }
		   curr="";
		 }
	  }
	  if(curr.Length>longest.Length){ //for last word
	     longest=curr;
	  }
	  return longest;
	}
	static bool IsNullOrWithSpace(string input){
	  if(input==null){
	    return true;
	  }
	  foreach(char ch in input){
	    if(ch!=' ' && ch!='\t' && ch!='\n' && ch!='\r' && ch!='\v' && ch!='\f'){
		  return false;
		}
	  }
	  return true;
	}
	static string ReplaceWord(string input,string oldWord,string newWord){
	  string res="";
	  string word="";
	  for(int i=0;i<=input.Length;i++){
	    if(i<input.Length && input[i]!=' '){
		   word+=input[i];
		}
		else{
		   if(word.ToLower()==oldWord.ToLower()){
		     res+=newWord;
		   }
		   else{
		     res+=word;
		    }
			if(i<input.Length){
			 res+=input[i];
			 word="";
			}
		 }
	  }
	  return res;
	}
}
