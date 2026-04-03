using System;
class SnakeAndLadder{
  static Random r=new Random();
  static string message="";
  static int[] startPositions = { 4, 9, 17, 20, 28, 40, 51, 54, 62, 64, 71, 87, 93, 95, 99 };
  static int[] endPositions   = { 14,31, 7, 38, 84,59, 67, 34, 19, 60, 91, 24, 73, 75, 78 };
  static void Main(){
    Console.Write("Enter number of player(2 to 4): ");
	int playerCount=int.Parse(Console.ReadLine());
	if(playerCount<2 || playerCount>4){
	  Console.WriteLine("Invalid number of players :");
	  return;
	}
	string[] players = new string[playerCount];
    int[] positions = new int[playerCount];
	for(int i=0;i<playerCount;i++){
	  Console.Write($"Enter name of player {i+1} :");
	  players[i] = Console.ReadLine(); 
	  positions[i]=0;
	}
	bool gameWon=false;
    while(!gameWon){
     for(int i=0;i<playerCount;i++){
	  string player=players[i];
	  Console.WriteLine($"{player}'s turn.Press enter to roll dice...");
	  Console.ReadLine();
	  int dice=RollDice();
	  int oldPosition=positions[i];
	  Console.WriteLine($"{player} rolled a {dice}");
	  int newPosition=MovePlayer(oldPosition,dice);
	  if(newPosition>100){
	    Console.WriteLine("Move exceeds 100.Turn skipped.");
		continue;
	  }
	  newPosition=ApplySnakeOrLadder(newPosition);
	  positions[i]=newPosition;
	  Console.WriteLine($"{player}: {oldPosition} -> {newPosition}");
	  if(message!=""){
	    Console.WriteLine(message);
	  }
	  if(checkWin(newPosition)){
	    Console.WriteLine($"{player} Wins the game!");
		gameWon=true;
		break;
	  }
	}
  }
}
   static int RollDice(){
     return r.Next(1,7);
   }
   static int MovePlayer(int currentPosition,int dice){
     return currentPosition+dice;
   }
   static int ApplySnakeOrLadder(int position){
     message="";
	 for(int i=0;i<startPositions.Length;i++){
	 if(position==startPositions[i]){
	   int newPosition=endPositions[i];
	   message=newPosition>position?$"Ladder!Climb up to {newPosition}":$"Snake!Slide down to {newPosition}";
	   return newPosition;
	 }
   }
   	return position;
 }
   static bool checkWin(int position){
    return position==100;
   }
}