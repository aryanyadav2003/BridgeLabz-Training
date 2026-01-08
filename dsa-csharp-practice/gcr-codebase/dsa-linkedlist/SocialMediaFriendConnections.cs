using System;
class FriendNode
{
    public int FriendId;
    public FriendNode Next;
    public FriendNode(int id)
    {
        FriendId = id;
        Next = null;
    }
}
class User
{
    public int UserId;
    public string Name;
    public int Age;
    public FriendNode Friends;
    public User Next;
    public User(int id, string name, int age)
    {
        UserId = id;
        Name = name;
        Age = age;
        Friends = null;
        Next = null;
    }
}
class SocialMedia
{
    private User head;
    public void AddUser(int id, string name, int age)
    {
        User newUser = new User(id, name, age);
        newUser.Next = head;
        head = newUser;
    }
    private User FindUserById(int id)
    {
        User temp = head;
        while (temp != null)
        {
            if (temp.UserId == id)
                return temp;
            temp = temp.Next;
        }
        return null;
    }
    public void SearchByName(string name)
    {
        User temp = head;
        while (temp != null)
        {
            if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                DisplayUser(temp);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("User not found");
    }
    public void AddFriend(int id1, int id2)
    {
        User u1 = FindUserById(id1);
        User u2 = FindUserById(id2);
        if (u1 == null || u2 == null)
        {
            Console.WriteLine("User not found");
            return;
        }
        AddFriendNode(u1, id2);
        AddFriendNode(u2, id1);
        Console.WriteLine("Friend connection added");
    }
    private void AddFriendNode(User user, int friendId)
    {
        FriendNode newNode = new FriendNode(friendId);
        newNode.Next = user.Friends;
        user.Friends = newNode;
    }
    public void RemoveFriend(int id1, int id2)
    {
        User u1 = FindUserById(id1);
        User u2 = FindUserById(id2);
        if (u1 == null || u2 == null)
        {
            Console.WriteLine("User not found");
            return;
        }
        RemoveFriendNode(u1, id2);
        RemoveFriendNode(u2, id1);
        Console.WriteLine("Friend connection removed");
    }
    private void RemoveFriendNode(User user, int friendId)
    {
        FriendNode temp = user.Friends;
        FriendNode prev = null;
        while (temp != null)
        {
            if (temp.FriendId == friendId)
            {
                if (prev == null)
                    user.Friends = temp.Next;
                else
                    prev.Next = temp.Next;
                return;
            }
            prev = temp;
            temp = temp.Next;
        }
    }
    public void DisplayFriends(int userId)
    {
        User user = FindUserById(userId);
        if (user == null)
        {
            Console.WriteLine("User not found");
            return;
        }
        Console.Write("Friends of " + user.Name + ": ");
        FriendNode temp = user.Friends;
        if (temp == null)
        {
            Console.WriteLine("No friends");
            return;
        }
        while (temp != null)
        {
            Console.Write(temp.FriendId + " ");
            temp = temp.Next;
        }
        Console.WriteLine();
    }
    public void MutualFriends(int id1, int id2)
    {
        User u1 = FindUserById(id1);
        User u2 = FindUserById(id2);
        if (u1 == null || u2 == null)
        {
            Console.WriteLine("User not found");
            return;
        }
        Console.Write("Mutual Friends: ");
        FriendNode f1 = u1.Friends;
        bool found = false;
        while (f1 != null)
        {
            FriendNode f2 = u2.Friends;
            while (f2 != null)
            {
                if (f1.FriendId == f2.FriendId)
                {
                    Console.Write(f1.FriendId + " ");
                    found = true;
                }
                f2 = f2.Next;
            }
            f1 = f1.Next;
        }

        if (!found)
            Console.Write("None");

        Console.WriteLine();
    }
    public void CountFriends()
    {
        User temp = head;
        while (temp != null)
        {
            int count = 0;
            FriendNode f = temp.Friends;
            while (f != null)
            {
                count++;
                f = f.Next;
            }
            Console.WriteLine(temp.Name + " has " + count + " friends");
            temp = temp.Next;
        }
    }
    private void DisplayUser(User u)
    {
        Console.WriteLine("ID: " + u.UserId +", Name: " + u.Name +", Age: " + u.Age);
    }
}
class SocialMediaFriendConnections
{
    static void Main()
    {
        SocialMedia sm = new SocialMedia();
        sm.AddUser(1, "Aryan", 20);
        sm.AddUser(2, "Rahul", 21);
        sm.AddUser(3, "Neha", 19);
        sm.AddUser(4, "Amit", 22);
        sm.AddFriend(1, 2);
        sm.AddFriend(1, 3);
        sm.AddFriend(2, 3);
        sm.AddFriend(2, 4);
        Console.WriteLine();
        sm.DisplayFriends(1);
        Console.WriteLine();
        sm.MutualFriends(1, 2);
        Console.WriteLine();
        sm.SearchByName("Neha");
        Console.WriteLine();
        sm.CountFriends();
        Console.WriteLine();
        sm.RemoveFriend(1, 2);
        sm.DisplayFriends(1);
    }
}
