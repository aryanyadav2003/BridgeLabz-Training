using System;
interface IMealPlan
{
    void Prepare();
}
class VegetarianMeal : IMealPlan
{
    public void Prepare() => Console.WriteLine("Preparing Vegetarian Meal");
}
class VeganMeal : IMealPlan
{
    public void Prepare() => Console.WriteLine("Preparing Vegan Meal");
}
class Meal<T> where T : IMealPlan, new()
{
    public void GenerateMeal()
    {
        T meal = new T();
        meal.Prepare();
    }
}
class Program
{
    static void Main()
    {
        Meal<VegetarianMeal> vegMeal = new Meal<VegetarianMeal>();
        vegMeal.GenerateMeal();
    }
}
