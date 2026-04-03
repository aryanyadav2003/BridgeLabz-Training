using System;
class LexicographicallyCompare{
  static int compare(string s1,string s2){
   int minL=s1.Length<s2.Length?s1.Length:s2.Length;
   for(int i=0;i<minL;i++){
    if(s1[i]!=s2[i]){
	  return s1[i]-s2[i];
	}
   }
   return s1.Length-s2.Length;
  }
  static void Main(){
   string s1=Console.ReadLine();
   string s2=Console.ReadLine();
   int res=compare(s1,s2);
   if(res<0){
     Console.WriteLine($"{s1} comes before {s2}");
   }
   else if(res>0){
     Console.WriteLine($"{s2} comes before {s1}");
   }
   else{
     Console.WriteLine("Both strings are equal");
   }
  }
}