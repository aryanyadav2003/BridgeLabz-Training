using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System.Xml;
class JsonHandsOn
{
    static void Main()
    {
        ReadJsonAndPrintKeys();
        ObjectsToJsonArray();
        FilterUsersByAge();
        ValidateEmailUsingSchema();
        MergeJsonObjects();
        JsonToXml();
        CsvToJson();
        GenerateJsonReport();
    }

    // Read JSON and print keys & values
    static void ReadJsonAndPrintKeys()
    {
        Console.WriteLine("\n1. Read JSON");
        string json = @"{ 'name':'Aryan', 'age':23, 'city':'Delhi' }";
        JObject obj = JObject.Parse(json);

        foreach (var item in obj)
            Console.WriteLine(item.Key + " : " + item.Value);
    }

    // Convert C# objects to JSON array
    static void ObjectsToJsonArray()
    {
        Console.WriteLine("\n2. Objects to JSON");
        var list = new List<Student>
        {
            new Student{ Id=1, Name="Leo"},
            new Student{ Id=2, Name="Max"}
        };

        Console.WriteLine(JsonConvert.SerializeObject(list, Formatting.Indented));
    }

    // Filter JSON users older than 25
    static void FilterUsersByAge()
    {
        Console.WriteLine("\n3. Filter Users > 25");
        string json = @"[
            {'name':'A','age':24},
            {'name':'B','age':28},
            {'name':'C','age':30}
        ]";

        JArray users = JArray.Parse(json);
        foreach (var u in users)
            if ((int)u["age"] > 25)
                Console.WriteLine(u["name"]);
    }

    // Validate Email using JSON Schema
    static void ValidateEmailUsingSchema()
    {
        Console.WriteLine("\n4. Email Validation");
        string data = @"{ 'email':'test@gmail.com' }";
        string schemaJson = @"{
            'type':'object',
            'properties':{
                'email':{'type':'string','format':'email'}
            },
            'required':['email']
        }";

        JObject obj = JObject.Parse(data);
        JSchema schema = JSchema.Parse(schemaJson);

        Console.WriteLine(obj.IsValid(schema) ? "Valid Email" : "Invalid Email");
    }

    //  Merge two JSON objects
    static void MergeJsonObjects()
    {
        Console.WriteLine("\n5. Merge JSON");
        JObject obj1 = JObject.Parse(@"{ 'name':'Aryan' }");
        JObject obj2 = JObject.Parse(@"{ 'age':23 }");

        obj1.Merge(obj2);
        Console.WriteLine(obj1);
    }

    //  Convert JSON to XML
    static void JsonToXml()
    {
        Console.WriteLine("\n6. JSON to XML");
        string json = @"{ 'name':'Leo','age':25 }";
        XmlDocument xml = JsonConvert.DeserializeXmlNode(json, "Root");

        Console.WriteLine(xml.OuterXml);
    }

    //  Convert CSV to JSON
    static void CsvToJson()
    {
        Console.WriteLine("\n7. CSV to JSON");
        string[] csv =
        {
            "Id,Name,Age",
            "1,Aryan,23",
            "2,Leo,25"
        };

        var list = new List<Dictionary<string, string>>();
        string[] headers = csv[0].Split(',');

        for (int i = 1; i < csv.Length; i++)
        {
            var dict = new Dictionary<string, string>();
            string[] values = csv[i].Split(',');

            for (int j = 0; j < headers.Length; j++)
                dict[headers[j]] = values[j];

            list.Add(dict);
        }

        Console.WriteLine(JsonConvert.SerializeObject(list, Formatting.Indented));
    }

    //  Generate JSON report (DB-like data)
    static void GenerateJsonReport()
    {
        Console.WriteLine("\n8. JSON Report");
        var employees = new[]
        {
            new { Id=1, Name="Leo", Salary=50000 },
            new { Id=2, Name="Max", Salary=60000 }
        };

        var report = new
        {
            GeneratedOn = DateTime.Now,
            TotalEmployees = employees.Length,
            Employees = employees
        };

        Console.WriteLine(JsonConvert.SerializeObject(report, Formatting.Indented));
    }
}
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}
