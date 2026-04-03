using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProductDiscountSort.EduResults
{
    internal class StateResult
    {
        private ArrayList allStudents = new ArrayList();
        private ArrayList districts = new ArrayList();
        public void AddDistrict()
        {
            Random random = new Random();
            Console.Write("Enter district name : ");
            string districtName = Console.ReadLine();
            Console.Write("Enter number of students  : ");
            int n = int.Parse(Console.ReadLine());
            Student[] students = new Student[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Student  {i + 1} ");
                Console.Write("Enter name : ");
                string name = Console.ReadLine();
                
                int score = random.Next(80,101);
                Console.Write("Score : "  + score);
                students[i] = new Student(name, score);
                allStudents.Add(students[i]);
                Console.WriteLine();
            }
            DistrictResult distric = new DistrictResult(districtName, students);
            districts.Add(distric);
            Console.WriteLine("District " + districtName + " added successfully.");

        }
        public Student[] GetStateRankList()
        {
            Student[] arr = new Student[allStudents.Count];

            for (int i = 0; i < allStudents.Count; i++)
            {
                arr[i] = (Student)allStudents[i];
            }

            MergeSortImpl.MergeSort(arr, 0, arr.Length - 1);
            return arr;
        }
    }
}
