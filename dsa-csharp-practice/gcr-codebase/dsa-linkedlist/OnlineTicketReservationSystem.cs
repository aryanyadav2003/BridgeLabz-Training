using System;
class Ticket
{
    public int TicketId;
    public string CustomerName;
    public string MovieName;
    public string SeatNumber;
    public string BookingTime;
    public Ticket Next;
    public Ticket(int id, string cname, string mname, string seat, string time)
    {
        TicketId = id;
        CustomerName = cname;
        MovieName = mname;
        SeatNumber = seat;
        BookingTime = time;
        Next = null;
    }
}
class TicketReservationSystem
{
    private Ticket head = null;
    private Ticket tail = null;
    public void AddTicket(int id, string cname, string mname, string seat, string time)
    {
        Ticket newTicket = new Ticket(id, cname, mname, seat, time);
        if (head == null)
        {
            head = tail = newTicket;
            tail.Next = head;
        }
        else
        {
            tail.Next = newTicket;
            tail = newTicket;
            tail.Next = head;
        }
    }
    public void RemoveTicket(int id)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets available");
            return;
        }
        Ticket curr = head;
        Ticket prev = tail;
        while (curr.Next != head)
        {
            if (curr.TicketId == id)
                break;
            prev = curr;
            curr = curr.Next;
        }
        if (curr.TicketId != id)
        {
            Console.WriteLine("Ticket not found");
            return;
        }
        if (curr == head && curr == tail)
        {
            head = tail = null;
        }
        else
        {
            prev.Next = curr.Next;
            if (curr == head)
                head = curr.Next;
            if (curr == tail)
                tail = prev;

            tail.Next = head;
        }
        Console.WriteLine("Ticket removed successfully");
    }
    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked");
            return;
        }
        Ticket temp = head;
        while (true)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Ticket ID: " + temp.TicketId);
            Console.WriteLine("Customer: " + temp.CustomerName);
            Console.WriteLine("Movie: " + temp.MovieName);
            Console.WriteLine("Seat: " + temp.SeatNumber);
            Console.WriteLine("Time: " + temp.BookingTime);

            temp = temp.Next;
            if (temp == head)
                break;
        }
    }
    public void Search(string key)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets available");
            return;
        }
        Ticket temp = head;
        bool found = false;
        while (true)
        {
            if (temp.CustomerName == key || temp.MovieName == key)
            {
                Console.WriteLine("Ticket Found:");
                Console.WriteLine("Ticket ID: " + temp.TicketId);
                Console.WriteLine("Customer: " + temp.CustomerName);
                Console.WriteLine("Movie: " + temp.MovieName);
                Console.WriteLine("Seat: " + temp.SeatNumber);
                found = true;
            }
            temp = temp.Next;
            if (temp == head)
                break;
        }
        if (!found)
            Console.WriteLine("No matching ticket found");
    }
    public int CountTickets()
    {
        if (head == null)
            return 0;

        int count = 0;
        Ticket temp = head;

        while (true)
        {
            count++;
            temp = temp.Next;
            if (temp == head)
                break;
        }
        return count;
    }
}
class Program
{
    static void Main()
    {
        TicketReservationSystem trs = new TicketReservationSystem();
        trs.AddTicket(101, "Aryan", "Inception", "A1", "10:30 AM");
        trs.AddTicket(102, "Rahul", "Avatar", "B5", "1:00 PM");
        trs.AddTicket(103, "Neha", "Inception", "C3", "4:00 PM");
        trs.DisplayTickets();
        trs.Search("Inception");
        Console.WriteLine("Total Tickets: " + trs.CountTickets());
        trs.RemoveTicket(102);
        trs.DisplayTickets();
    }
}
