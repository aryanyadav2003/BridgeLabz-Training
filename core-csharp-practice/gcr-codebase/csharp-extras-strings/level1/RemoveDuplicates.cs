using System;
class RemoveDuplicates{
  static string helper(string s){
    string res="";
	for(int i=0;i<s.Length;i++){
	  bool found=false;
	  for(int j=0;j<res.Length;j++){
	   if(s[i]==res[j]){
	     found=true;
		 break;
	   }
	  }
	  if(!found) res+=s[i];
	}
	return res;
  }
  static void Main(){
    string input=Console.ReadLine();
	Console.Write(helper(input));
  }
}