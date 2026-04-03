using System;
class Handshakes{
  static int NumberOfHandshakes(int n){
    return (n*(n-1))/2;
  }
  static void Main(){
    int n=int.Parse(Console.ReadLine());
	int ans=NumberOfHandshakes(n);
	Console.WriteLine(ans);
  }
}