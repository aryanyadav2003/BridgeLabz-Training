using System;
class Item
{
    public int ItemId;
    public string ItemName;
    public int Quantity;
    public double Price;
    public Item Next;
    public Item(int id, string name, int qty, double price)
    {
        ItemId = id;
        ItemName = name;
        Quantity = qty;
        Price = price;
        Next = null;
    }
}
class InventoryList
{
    private Item head;
    public void AddAtBeginning(int id, string name, int qty, double price)
    {
        Item newNode = new Item(id, name, qty, price);
        newNode.Next = head;
        head = newNode;
    }
    public void AddAtEnd(int id, string name, int qty, double price)
    {
        Item newNode = new Item(id, name, qty, price);
        if (head == null)
        {
            head = newNode;
            return;
        }
        Item temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = newNode;
    }
    public void AddAtPosition(int pos, int id, string name, int qty, double price)
    {
        if (pos == 1)
        {
            AddAtBeginning(id, name, qty, price);
            return;
        }
        Item temp = head;
        int count = 1;
        while (count < pos - 1 && temp != null)
        {
            temp = temp.Next;
            count++;
        }
        if (temp == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }
        Item newNode = new Item(id, name, qty, price);
        newNode.Next = temp.Next;
        temp.Next = newNode;
    }
    public void RemoveById(int id)
    {
        if (head == null) return;

        if (head.ItemId == id)
        {
            head = head.Next;
            Console.WriteLine("Item removed");
            return;
        }
        Item temp = head;
        while (temp.Next != null && temp.Next.ItemId != id){
            temp = temp.Next;
        }
        if (temp.Next == null)
        {
            Console.WriteLine("Item not found");
            return;
        }
        temp.Next = temp.Next.Next;
        Console.WriteLine("Item removed");
    }
    public void UpdateQuantity(int id, int newQty)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.ItemId == id)
            {
                temp.Quantity = newQty;
                Console.WriteLine("Quantity updated");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found");
    }
    public void SearchById(int id)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.ItemId == id)
            {
                DisplayItem(temp);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found");
    }
    public void SearchByName(string name)
    {
        Item temp = head;
        bool found = false;
        while (temp != null)
        {
            if (temp.ItemName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                DisplayItem(temp);
                found = true;
            }
            temp = temp.Next;
        }
        if (!found)
            Console.WriteLine("Item not found");
    }
    public void TotalInventoryValue()
    {
        double total = 0;
        Item temp = head;
        while (temp != null)
        {
            total += temp.Price * temp.Quantity;
            temp = temp.Next;
        }
        Console.WriteLine("Total Inventory Value: " + total);
    }
    public void SortByName(bool ascending)
    {
        for (Item i = head; i != null; i = i.Next)
        {
            for (Item j = i.Next; j != null; j = j.Next)
            {
                int cmp = string.Compare(i.ItemName, j.ItemName);
                if ((ascending && cmp > 0) || (!ascending && cmp < 0))
                    SwapData(i, j);
            }
        }
    }
    public void SortByPrice(bool ascending)
    {
        for (Item i = head; i != null; i = i.Next)
        {
            for (Item j = i.Next; j != null; j = j.Next)
            {
                if ((ascending && i.Price > j.Price) ||
                    (!ascending && i.Price < j.Price))
                    SwapData(i, j);
            }
        }
    }
    private void SwapData(Item a, Item b)
    {
        int id = a.ItemId;
        string name = a.ItemName;
        int qty = a.Quantity;
        double price = a.Price;
        a.ItemId = b.ItemId;
        a.ItemName = b.ItemName;
        a.Quantity = b.Quantity;
        a.Price = b.Price;
        b.ItemId = id;
        b.ItemName = name;
        b.Quantity = qty;
        b.Price = price;
    }
    public void DisplayAll()
    {
        Item temp = head;
        if (temp == null)
        {
            Console.WriteLine("No items available");
            return;
        }
        while (temp != null)
        {
            DisplayItem(temp);
            temp = temp.Next;
        }
    }
    private void DisplayItem(Item i)
    {
        Console.WriteLine("ID: " + i.ItemId +", Name: " + i.ItemName +", Qty: " + i.Quantity +", Price: " + i.Price);
    }
}
class Program
{
    static void Main()
    {
        InventoryList inventory = new InventoryList();
        inventory.AddAtEnd(101, "Pen", 50, 10);
        inventory.AddAtEnd(102, "Notebook", 20, 50);
        inventory.AddAtBeginning(103, "Pencil", 100, 5);
        Console.WriteLine("All Items:");
        inventory.DisplayAll();
        Console.WriteLine("Total Value:");
        inventory.TotalInventoryValue();
        Console.WriteLine("Sort by Name (ASC):");
        inventory.SortByName(true);
        inventory.DisplayAll();
        Console.WriteLine("Sort by Price (DESC):");
        inventory.SortByPrice(false);
        inventory.DisplayAll();
    }
}
