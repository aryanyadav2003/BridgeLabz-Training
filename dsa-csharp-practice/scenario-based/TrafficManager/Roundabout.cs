using System;

namespace TrafficManager
{
    class Roundabout
    {
        private Vehicle head = null;

        public void AddVehicle(string number)
        {
            Vehicle newVehicle = new Vehicle(number);

            if (head == null)
            {
                head = newVehicle;
                head.Next = head;
                return;
            }

            Vehicle temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newVehicle;
            newVehicle.Next = head;
        }

        public void RemoveVehicle(string number)
        {
            if (head == null)
            {
                Console.WriteLine("Roundabout is empty.");
                return;
            }

            Vehicle current = head;
            Vehicle previous = null;

            do
            {
                if (current.VehicleNumber == number)
                {
                    if (current == head)
                    {
                        if (head.Next == head)
                        {
                            head = null;
                            return;
                        }

                        Vehicle last = head;
                        while (last.Next != head)
                            last = last.Next;

                        head = head.Next;
                        last.Next = head;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }

                    Console.WriteLine("Vehicle removed from roundabout.");
                    return;
                }

                previous = current;
                current = current.Next;

            } while (current != head);

            Console.WriteLine("Vehicle not found.");
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Roundabout is empty.");
                return;
            }

            Vehicle temp = head;
            Console.Write("Roundabout Vehicles: ");

            do
            {
                Console.Write(temp.VehicleNumber + " -> ");
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine("(Back to Start)");
        }
    }
}
