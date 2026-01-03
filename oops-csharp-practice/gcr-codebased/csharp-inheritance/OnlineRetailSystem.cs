using System;
class Order{
   public int OrderId;
   public string OrderDate;
   public virtual string GetOrderStatus(){
     return "Order placed";
   }
}
class ShippedOrder:Order{
  public string TrackingNumber;
  public override string GetOrderStatus(){
    return "Order shipped";
  }
}
class DeliveredOrder:ShippedOrder{
  public string DeliveryDate;
  public override string GetOrderStatus(){
    return "Order Delivered";
  }
}
class OnlineRetailSystem{
    static void Main(){
        Order o1 = new Order{
            OrderId = 1001,
            OrderDate = "01-Jan-2026"
        };
        Order o2 = new ShippedOrder{
            OrderId = 1002,
            OrderDate = "02-Jan-2026",
            TrackingNumber = "TRK12345"
        };
        Order o3 = new DeliveredOrder{
            OrderId = 1003,
            OrderDate = "03-Jan-2026",
            TrackingNumber = "TRK67890",
            DeliveryDate = "05-Jan-2026"
        };

        Console.WriteLine("Order 1 Status: " + o1.GetOrderStatus());
        Console.WriteLine("Order 2 Status: " + o2.GetOrderStatus());
        Console.WriteLine("Order 3 Status: " + o3.GetOrderStatus());
    }
}