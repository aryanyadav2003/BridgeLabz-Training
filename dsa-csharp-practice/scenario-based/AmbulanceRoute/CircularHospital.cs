using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.AmbulanceRoute
{
    internal class CircularHospital
    {
        private Unit head;
        // Add hospital unit
        public void AddUnit(string name)
        {
            Unit newUnit = new Unit(name);
            if (head == null)
            {
                head = newUnit;
                newUnit.Next = head;
                return;
            }
            Unit temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newUnit;
            newUnit.Next = head;
        }
        // Set unit under maintenance
        public void SetMaintenance(string name)
        {
            Unit temp = head;
            if (temp == null) return;
            while (true)
            {
                if (temp.Name == name)
                {
                    temp.IsAvailable = false;
                    Console.WriteLine(name + " is under maintenance.");
                    return;
                }
                temp = temp.Next;
                if (temp == head) break;
            }
        }
        //Remove unit completely
        public void RemoveUnit(string name)
        {
            if (head == null) return;
            Unit current = head;
            Unit previous = null;
            while (true)
            {
                if (current.Name == name)
                {
                    if (current == head)
                    {
                        Unit last = head;
                        while (last.Next != head)
                        {
                            last = last.Next;
                        }

                        head = head.Next;
                        last.Next = head;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }

                    Console.WriteLine(name + " removed from hospital route.");
                    return;
                }
                previous = current;
                current = current.Next;
                if (current == head) break;
            }
        }
        //Ambulance routing logic
        public void RouteAmbulance(string startUnit)
        {
            if (head == null)
            {
                Console.WriteLine("No hospital units available.");
                return;
            }
            Unit temp = head;
            while (temp.Name != startUnit)
            {
                temp = temp.Next;
                if (temp == head) return;
            }
            Unit current = temp;
            while (true)
            {
                Console.WriteLine("Checking " + current.Name);
                if (current.IsAvailable)
                {
                    Console.WriteLine("Patient sent to: " + current.Name);
                    return;
                }
                current = current.Next;
                if (current == temp) break;
            }
            Console.WriteLine("No available units found.");
        }
        // Display hospital route
        public void DisplayRoute()
        {
            if (head == null) return;
            Unit temp = head;
            Console.Write("Hospital Route: ");
            while (true)
            {
                Console.Write(temp.Name + " → ");
                temp = temp.Next;
                if (temp == head) break;
            }
            Console.WriteLine("(Back to Start)");
        }
    }
}
