using System;
class SubstringExample{
   static string usingCharAt(string s,int st,int end){
     string res="";
	 for(int i=st;i<end;i++){
	   res+=s[i];
	 }
	 return res;
   }
   static void Main(){
     Console.Write("Enter a string: ");
	 string s=Console.ReadLine();
	 int st=int.Parse(Console.ReadLine());
	 int end=int.Parse(Console.ReadLine());
	 string s1=usingCharAt(s,st,end);
	 string s2=s.Substring(st,end-st);
	 Console.WriteLine("Substring using char at logic:" +s1);
	 Console.WriteLine("Substring using substring method:" +s2);
	 if(s1.Equals(s2)){
	   Console.WriteLine("Both are same");
	   
	 }
	 else{
	   Console.WriteLine("different");
	 }
	 
   }
}