using System;
using System.Collections.Generic;
class MyHashMap
{
    private const int size= 10;
    private LinkedList<KeyValuePair<int, int>>[] buckets;
    public MyHashMap()
    {
        buckets = new LinkedList<KeyValuePair<int, int>>[size];
        for (int i = 0; i <size; i++)
            buckets[i] = new LinkedList<KeyValuePair<int, int>>();
    }
    private int Hash(int key)
    {
        return key %size;
    }
    public void Put(int key, int value)
    {
        int index = Hash(key);
        foreach (var pair in buckets[index])
        {
            if (pair.Key == key)
            {
                buckets[index].Remove(pair);
                buckets[index].AddLast(new KeyValuePair<int, int>(key, value));
                return;
            }
        }
        buckets[index].AddLast(new KeyValuePair<int, int>(key, value));
    }
    public int Get(int key)
    {
        int index = Hash(key);
        foreach (var pair in buckets[index])
        {
            if (pair.Key == key)
                return pair.Value;
        }
        return -1; 
    }
    public void Remove(int key)
    {
        int index = Hash(key);
        foreach (var pair in buckets[index])
        {
            if (pair.Key == key)
            {
                buckets[index].Remove(pair);
                return;
            }
        }
    }
}
class Program
{
    static void Main()
    {
        MyHashMap map = new MyHashMap();
        map.Put(1, 100);
        map.Put(2, 200);
        map.Put(12, 1200);
        Console.WriteLine(map.Get(1));  
        Console.WriteLine(map.Get(2));  
        Console.WriteLine(map.Get(12)); 
        map.Remove(2);
        Console.WriteLine(map.Get(2)); 
    }
}
