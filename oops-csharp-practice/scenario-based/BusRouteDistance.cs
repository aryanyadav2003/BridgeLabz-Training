using System;
class User{
	public int userId;
	public bool IsInBus;
	public int DistanceTravelled;
	
	public User(int id){
		userId = id;
		IsInBus = true;
		DistanceTravelled = 0;
	}
	public void AddDistance(int distance){
		DistanceTravelled+=distance;
	}
	public int CalculateFare(int farePerKm){
		return DistanceTravelled * farePerKm;
	}
	public void AskToGetOff(){
		Console.Write("Passenger " + userId + ", do you want to get off? (yes/no): ");
		string choice=Console.ReadLine().ToLower();
		if(choice == "yes"){
			IsInBus = false;
		}
	}
}
class Bus{
	private User[] users = new User[10];
	private int userCount = 0;
	private int totalDistance = 0;
	private int totalCollection = 0;
	
	private const int farePerKm = 2;
	
	public Bus(){
		while(userCount<10){
			users[userCount] = new User(userCount + 1);
			userCount++;
		}
	}
	public void StartJourney(){
		int stop = 1;
		while(userCount>0){
			Console.WriteLine($"--- Stop {stop} ---");
			Console.Write("Enter distance travelled to this stop(in km):");
			int distance = int.Parse(Console.ReadLine());
			totalDistance+=distance;
			int i=0;
			while(i<users.Length){
				if(users[i]!=null && users[i].IsInBus){
					users[i].AddDistance(distance);
					users[i].AskToGetOff();
					
					if(!users[i].IsInBus){
						totalCollection+=users[i].CalculateFare(farePerKm);
						users[i] = null;
						userCount--;
					}
				}
				i++;
			}
			BoardNewPassengers();
			DisplayStatus();
			
			stop++;
		}
		Console.WriteLine("Journey ended.");
	    Console.WriteLine("Total bus collection for the day: ₹" + totalCollection);	
	}
	private void BoardNewPassengers(){
		Console.Write("Do new passengers want to board? (yes/no): ");
		string choice = Console.ReadLine().ToLower();
		while(choice == "yes" && userCount<users.Length){
			int i=0;
			while(i<users.Length){
				if(users[i] == null){
					users[i] = new User(i+1);
					userCount++;
					Console.WriteLine("Passenger boarded at seat " + (i + 1));
					break;
				}
				i++;
			}
			if(userCount < users.Length){
				Console.Write("Add another passenger? (yes/no): ");
                choice = Console.ReadLine().ToLower();
			}
			 else{
                Console.WriteLine("Bus is full.");
                break;
            }
		}
	}
	private void DisplayStatus(){
		Console.WriteLine("Passengers currently in bus: " + userCount);
        Console.WriteLine("Total distance covered: " + totalDistance + " km");
        Console.WriteLine("Total collection so far: ₹" + totalCollection);
	}
}
class Program{
    static void Main(){
        Bus bus = new Bus();
        bus.StartJourney();
    }
}
