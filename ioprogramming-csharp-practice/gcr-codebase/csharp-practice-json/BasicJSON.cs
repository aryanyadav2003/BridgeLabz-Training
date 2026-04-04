using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace JsonPractice
{
    //Student Class
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Subjects { get; set; }
    }

    //Car Class
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

    //Employee Class
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create Student JSON
            Student student = new Student
            {
                Name = "Aryan",
                Age = 22,
                Subjects = new List<string> { "Maths", "CS", "Networking" }
            };

            string studentJson = JsonConvert.SerializeObject(student, Formatting.Indented);
            Console.WriteLine("Student JSON:\n" + studentJson);

            // Convert Car object to JSON
            Car car = new Car
            {
                Brand = "Tesla",
                Model = "Model 3",
                Year = 2024
            };

            string carJson = JsonConvert.SerializeObject(car, Formatting.Indented);
            Console.WriteLine("\nCar JSON:\n" + carJson);

            //  Read JSON & extract specific fields
            string userJson = @"{
                'name':'John',
                'email':'john@gmail.com',
                'age':30,
                'city':'Delhi'
            }";

            JObject userObj = JObject.Parse(userJson);
            Console.WriteLine("\nExtracted Fields:");
            Console.WriteLine("Name: " + userObj["name"]);
            Console.WriteLine("Email: " + userObj["email"]);

            //  Merge two JSON objects
            JObject obj1 = JObject.Parse(@"{ 'name':'Aryan', 'age':22 }");
            JObject obj2 = JObject.Parse(@"{ 'email':'aryan@gmail.com', 'city':'Pune' }");
            obj1.Merge(obj2);

            Console.WriteLine("\nMerged JSON:\n" + obj1);

            // Validate JSON using Schema
            string schemaJson = @"{
              'type':'object',
              'properties': {
                'name': { 'type':'string' },
                'age': { 'type':'integer' }
              },
              'required':['name','age']
            }";

            JSchema schema = JSchema.Parse(schemaJson);
            bool isValid = obj1.IsValid(schema);
            Console.WriteLine("\nSchema Valid: " + isValid);

            //  Convert List of objects to JSON Array
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Amit" },
                new Employee { Id = 2, Name = "Riya" }
            };

            string empJson = JsonConvert.SerializeObject(employees, Formatting.Indented);
            Console.WriteLine("\nEmployees JSON Array:\n" + empJson);

            //  Filter JSON where age > 25
            string peopleJson = @"[
              { 'name':'Amit', 'age':23 },
              { 'name':'Ravi', 'age':28 },
              { 'name':'Neha', 'age':30 }
            ]";

            JArray peopleArray = JArray.Parse(peopleJson);

            var filtered = peopleArray
                .Where(p => (int)p["age"] > 25);

            Console.WriteLine("\nPeople with age > 25:");
            foreach (var p in filtered)
            {
                Console.WriteLine(p["name"]);
            }
        }
    }
}
