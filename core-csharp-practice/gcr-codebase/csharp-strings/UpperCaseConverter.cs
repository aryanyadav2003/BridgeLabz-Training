using System;
class UpperCaseConverter{
static string ToUpperCase(string input){
  char[] result=new char[input.Length];
  for(int i=0;i<input.Length;i++){
   char ch=input[i];
   if(ch>='a' && ch<='z'){
     result[i]=(char)(ch-32);
   }
   else{
    result[i]=ch;
   }
  }
  return new string(result);
}
  static void Main(){
  string text=Console.ReadLine();
  string s1=ToUpperCase(text);
  string s2=text.ToUpper();
  Console.WriteLine("Uppercase using ASCII logic : " + s1);
  Console.WriteLine("Uppercase using ToUpper()  : " + s2);
  if(s1==s2){
    Console.WriteLine("Both results are same");
  }
  else{
    Console.WriteLine("Results are different");
  }
  }
}