using System;
class UserProfile
{
    public string UserName { get; private set; }
    private Workout[] workouts;  
    private int count;           
    public UserProfile(string userName)
    {
        UserName = userName;
        workouts = new Workout[10]; 
        count = 0;
    }
    public void AddWorkout(Workout workout)
    {
        if (count < workouts.Length)
        {
            workouts[count] = workout;
            count++;
        }
        else
        {
            Console.WriteLine("Workout list is full!");
        }
    }
    public void ShowWorkouts()
    {
        Console.WriteLine($"Workouts of {UserName}:");
        for (int i = 0; i < count; i++)
        {
            workouts[i].Track();
        }
    }
}
