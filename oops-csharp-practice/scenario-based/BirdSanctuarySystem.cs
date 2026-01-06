using System;
interface IFlyable{
    void Fly();
}
interface ISwimmable{
    void Swim();
}
abstract class Bird{
    public string name;
    public int age;
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Bird name : " + name);
        Console.WriteLine("Age : " + age);
    }
}
class Eagle : Bird , IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Eagle can fly high int the sky");
    }
}
class Sparrow : Bird , IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Sparrow can fly but not high");
    }
}
class Duck : Bird , ISwimmable
{
    public void Swim()
    {
        Console.WriteLine("Duck can swim in lakes , pond but not in river,sea and ocean");
    }
}
class Penguin : Bird , ISwimmable
{
    public void Swim()
    {
        Console.WriteLine("Penguin can swim in river,sea and ocean");
    }
}
class Seagull : Bird, IFlyable, ISwimmable
{
    public void Fly()
    {
        Console.WriteLine("Seagull can swim but swims in sea");
    }
    public void Swim()
    {
        Console.WriteLine("Seagull can swim");
    }
}
class BirdSanctuarySystem
{
    static void Main()
    {
        Bird[] birds = new Bird[5];

        birds[0] = new Eagle{name = "Eagle" , age = 5};
        birds[1] = new Sparrow{name = "Sparrow" , age = 2};
        birds[2] = new Duck{name = "Duck" , age = 2};
        birds[3] = new Penguin{name = "Penguin" , age =6};
        birds[4] = new Seagull{name = "Seagull" , age = 4};
        foreach(Bird b in birds)
        {
            Console.WriteLine("---------------------");
            b.DisplayInfo();
            if(b is IFlyable flyable)
            {
                flyable.Fly();
            }
            if(b is ISwimmable swimable){
                swimable.Swim();
            }
        }
    }
}