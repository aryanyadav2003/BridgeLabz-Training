using System;
class CharArray{
static char[] Helper(string s){
  char[] c=new char[s.Length];
  for(int i=0;i<s.Length;i++){
   c[i]=s[i];
  }
  return c;
}
  static void Main(){
    string s=Console.ReadLine();
	char[] arr1=Helper(s);
	char[] arr2=s.ToCharArray();
	bool isSame=true;
	for(int i=0;i<arr1.Length;i++){
	 if(arr1[i]!=arr2[i]){
	  isSame=false;
	  break;
	 }
	}
	if(isSame){
       Console.WriteLine("Both are same");	
	}
  }
}