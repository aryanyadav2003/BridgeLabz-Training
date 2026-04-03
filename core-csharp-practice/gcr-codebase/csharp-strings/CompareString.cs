using System;
class CompareString{
   public static bool UsingCharAt(string s1,string s2){
     if(s1.Length!=s2.Length) return false;
	 for(int i=0;i<s1.Length;i++){
	   if(s1[i]!=s2[i]) return false;
	 }
	 return true;
   }
   static void Main(){
     string str1=Console.ReadLine();
	 string str2=Console.ReadLine();
	 bool charAtResult=UsingCharAt(str1,str2);
	 bool equalsResult=string.Equals(str1,str2);
	 Console.WriteLine("using charAt logic :" + charAtResult);
	 Console.WriteLine("using equals :" + equalsResult);
	 
   }
}