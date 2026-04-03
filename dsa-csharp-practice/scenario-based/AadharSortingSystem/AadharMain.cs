using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Transactions;

namespace ProductDiscountSort.AadharSortingSystem
{
    internal class AadharMain
    {
        static void Main(string[] args)
        {
            Console.Write("Enter total number of records : ");
            int n=int.Parse(Console.ReadLine());

            AadharRecord[] records=new AadharRecord[n];
            for(int i=0; i < n; i++)
            {
                Console.Write($"Enter aadhar number for person {i+1} : ");
                long aadharNumber=System.Convert.ToInt64(Console.ReadLine());
                Console.Write("Enter name : ");
                string name=Console.ReadLine();
                records[i] = new AadharRecord(aadharNumber, name);
            }
            RadixSorter sorter=new RadixSorter();
            SearchService searchService = new SearchService();
            Console.WriteLine("Before Sorting : ");
            Display(records);
            sorter.Sort(records);
            Console.WriteLine("After Sorting : ");
            Display(records);

            Console.WriteLine("Enter aadhar number to search : ");
            long target=System.Convert.ToInt64(Console.ReadLine());
            AadharRecord result = searchService.BinarySearch(records, target);
            if(result != null)
            {
                Console.WriteLine("Found : " + result.Name);
            }
            else
            {
                Console.WriteLine("Aadhar not found");
            }
        }
        static void Display(AadharRecord[] records)
        {
            foreach(var r in records)
            {
                r.Display();
            }
        }
    }
}
