// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program
{
    static void Main()
    {
         Console.WriteLine("===== CUSTOM FURNITURE MANUFACTURING SYSTEM =====");
         Console.Write("Enter total wooden rod length (ft): ");
         int length=int.Parse(Console.ReadLine());
         WoodenRod rod=new WoodenRod(length);
         rod.InputPrices();
         CutUtilityImpl cut=new CutUtilityImpl();
         int maxRevenue=cut.MaxRevenue(rod.Price,rod.Length);
         Console.WriteLine(" Maximum Revenue: " + maxRevenue);

         Console.Write("Enter required fixed cut size (ft): ");
         int fixedCut = int.Parse(Console.ReadLine());
         int fixedCutRevenue=cut.RevenueWithFixedCut(rod.Price, rod.Length, fixedCut);
         Console.WriteLine(" Revenue with Fixed Cut : " + fixedCutRevenue);
         Console.Write("Enter allowed waste (ft): ");
         int waste = int.Parse(Console.ReadLine());
         int revenueWithWaste=cut.MaxRevenueWithWaste(rod.Price, rod.Length, waste);
         Console.WriteLine("Revenue with Waste Constraint: " + revenueWithWaste);
    }
}