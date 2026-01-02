using System;
class HotelBooking{
  public string GuestName;
  public string RoomType;
  public int Nights;
  
  public HotelBooking(){
    GuestName="Aryan";
	RoomType="Standard";
	Nights=1;
  }
    public HotelBooking(string guestName, string roomType, int nights){
        GuestName = guestName;
        RoomType = roomType;
        Nights = nights;
    }
	public HotelBooking(HotelBooking booking){
	  GuestName = booking.GuestName;
	  RoomType = booking.RoomType;
	  Nights = booking.Nights;
	}
	public void ShowBooking(){
	    Console.WriteLine("Guest Name: " + GuestName);
        Console.WriteLine("Room Type: " + RoomType);
        Console.WriteLine("Nights: " + Nights);
	}
}
class Hotel{
	static void Main(){
  HotelBooking b1 = new HotelBooking();
  b1.ShowBooking();
  
  HotelBooking b2 = new HotelBooking("Aryan", "Deluxe", 3);
  b2.ShowBooking();
  
  HotelBooking b3 = new HotelBooking(b2);
  b3.ShowBooking();
}}