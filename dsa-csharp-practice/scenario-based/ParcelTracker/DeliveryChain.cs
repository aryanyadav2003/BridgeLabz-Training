using System;

namespace ProductDiscountSort.ParcelTracker
{
    internal class DeliveryChain
    {
        private StageNode head;

        // Add stage at end
        public void AddStage(string stage)
        {
            StageNode newNode = new StageNode(stage);

            if (head == null)
            {
                head = newNode;
                return;
            }

            StageNode temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = newNode;
        }

        // Add checkpoint after given stage
        public void AddCheckPoints(string afterStage, string newStage)
        {
            StageNode temp = head;

            while (temp != null)
            {
                if (temp.StageName == afterStage)
                {
                    StageNode newNode = new StageNode(newStage);
                    newNode.Next = temp.Next;
                    temp.Next = newNode;

                    Console.WriteLine("Checkpoint added successfully.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Stage not found. Cannot add checkpoint.");
        }

        // Track parcel
        public void TrackParcel()
        {
            if (head == null)
            {
                Console.WriteLine("Parcel lost or no stages added.");
                return; 
            }

            StageNode temp = head;
            Console.Write("Parcel Status: ");

            while (temp != null)
            {
                Console.Write(temp.StageName);
                if (temp.Next != null)
                    Console.Write(" -> ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        // Mark lost
        public void MarkLost()
        {
            head = null;
            Console.WriteLine("Parcel marked as lost.");
        }
    }
}
