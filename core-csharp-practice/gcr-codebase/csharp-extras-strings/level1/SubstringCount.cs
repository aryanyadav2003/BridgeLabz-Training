using System;
class SubstringCount{
  static void Main(){
    string text=Console.ReadLine();
	string sub=Console.ReadLine();
	int cnt=0;
	int idx=0;
	while((idx=text.IndexOf(sub,idx))!=-1){
	   cnt++;
	   idx+=sub.Length;
	}
	Console.Write(cnt);
  }
}