using System; 
class Program
{
    static void Main()
    {
        UserProfile user = new UserProfile("Aryan Yadav");
        Workout w1 = new CardioWorkout("Running", 30, 5);
        Workout w2 = new StrengthWorkout("Pushups", 20, 50);
        user.AddWorkout(w1);
        user.AddWorkout(w2);
        user.ShowWorkouts();
    }
}